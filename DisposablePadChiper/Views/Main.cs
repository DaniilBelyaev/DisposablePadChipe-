using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisposablePadChiper
{
    public partial class Main : Form
    {
        Chiper.DisposablePadChiper chiper;
        public Main()
        {
            chiper = new Chiper.DisposablePadChiper();
            InitializeComponent();
        }

        private void OpenText_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text File (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var fileContent = reader.ReadToEnd();

                        chiperText.Text = fileContent;
                    }
                }
            }
        }

        private void SaveText_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text File (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream writeStream;
                    if ((writeStream = saveFileDialog.OpenFile()) != null)
                    {
                        using(StreamWriter writer = new StreamWriter(writeStream))
                        {
                            writer.Write(chiperText.Text);
                            writer.Close();
                        }
                    }
                }
            }
        }

        private void GeneratePassword_Click(object sender, EventArgs e)
        {
            var key = new byte[(int)passwordLenght.Value];
            // Создаем случайный криптографический генератор ключей.
            using (var randomGenerator = new RNGCryptoServiceProvider())
                randomGenerator.GetBytes(key);

            passwordBox.Text = Encoding.GetEncoding(1251).GetString(key);

        }

        private void ProcessText_Click(object sender, EventArgs e)
        {
            if (chiperText.TextLength == 0)
            {
                MessageBox.Show("Шифротекст не может быть пустым!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioEncrypt.Checked && !radioDecrypt.Checked)
            {
                MessageBox.Show("Должен быть выбран тип обработки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passwordBox.TextLength <= 5)
            {
                MessageBox.Show("Пароль должен быть не меньше 5 символов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chiper.GenerateKey(() =>
            {
                return Encoding.GetEncoding(1251).GetBytes(passwordBox.Text);
            });

            if (!radioEncrypt.Checked)
            {
                chiperText.Text = chiper.Encrypt(chiperText.Text);
                return;
            }

            if (!radioDecrypt.Checked)
            {
                chiperText.Text = chiper.Decrypt(chiperText.Text);
                return;
            }
        }
    }
}
