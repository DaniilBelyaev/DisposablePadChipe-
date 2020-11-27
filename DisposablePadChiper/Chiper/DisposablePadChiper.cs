using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposablePadChiper.Chiper
{
    public class DisposablePadChiper
    {
        // Кодировка для последующей обработки текста
        private Encoding chipperEncoding;
        // Гамма(ключ)
        private byte[] _key;

        //Конструкторк класса шифратора. По умолчанию устанавливаем кодировку Windows-1251
        public DisposablePadChiper(int encodingKey = 1251)
        {
            chipperEncoding = Encoding.GetEncoding(encodingKey);
        }
        //Генерация ключа. Отдаем управление генерацией ключа пользователю, для возможности выбора
        //различных подходов к случайному созданию ключа
        public void GenerateKey(Func<byte[]> keyGenerationLambda)
        {
            _key = keyGenerationLambda();
        }
        public byte[] GetKey()
        {
            return _key;
        }
        public void SetKey(byte[] _key)
        {
            this._key = _key;
        }
        //Публичная функция кодирования
        public string Encrypt(String text)
        {
            var planeText = chipperEncoding.GetBytes(text);

            return chipperEncoding.GetString(XORStrimmed(_key, planeText).ToArray());
        }
        //Публичная функция декодирования
        public string Decrypt(String text)
        {
            var chipperText = chipperEncoding.GetBytes(text);

            return chipperEncoding.GetString(XORStrimmed(_key, chipperText).ToArray());
        }
        //Главнная функция кодирования/декодирования ключом гамма, потока символов в двоичном представлении.
        //В соответствии с подходом однаразового блокнота, если ключ меньше длинны строки, 
        //повторяем ключ до конца строки.
        private IEnumerable<byte> XORStrimmed(byte[] gamma, IEnumerable<byte> data)
        {

            var gammaIndex = 0;
            foreach (var bb in data)
            {
                // XOR
                yield return (byte)(bb ^ gamma[gammaIndex]);

                if (gammaIndex < gamma.Length - 1)
                    gammaIndex++;
                else
                    gammaIndex = 0;
            }
        }
    }
}
