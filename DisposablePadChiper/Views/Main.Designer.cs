namespace DisposablePadChiper
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenText = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveText = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.GeneratePassword = new System.Windows.Forms.Button();
            this.chiperText = new System.Windows.Forms.TextBox();
            this.ProcessGroup = new System.Windows.Forms.GroupBox();
            this.radioEncrypt = new System.Windows.Forms.RadioButton();
            this.radioDecrypt = new System.Windows.Forms.RadioButton();
            this.ProcessText = new System.Windows.Forms.Button();
            this.passwordLenght = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ProcessGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Name = "MainMenu";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenText,
            this.SaveText});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // OpenText
            // 
            this.OpenText.Name = "OpenText";
            resources.ApplyResources(this.OpenText, "OpenText");
            this.OpenText.Click += new System.EventHandler(this.OpenText_Click);
            // 
            // SaveText
            // 
            this.SaveText.Name = "SaveText";
            resources.ApplyResources(this.SaveText, "SaveText");
            this.SaveText.Click += new System.EventHandler(this.SaveText_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chiperText);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.passwordLenght);
            this.groupBox2.Controls.Add(this.GeneratePassword);
            this.groupBox2.Controls.Add(this.passwordBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // passwordBox
            // 
            resources.ApplyResources(this.passwordBox, "passwordBox");
            this.passwordBox.Name = "passwordBox";
            // 
            // GeneratePassword
            // 
            resources.ApplyResources(this.GeneratePassword, "GeneratePassword");
            this.GeneratePassword.Name = "GeneratePassword";
            this.GeneratePassword.UseVisualStyleBackColor = true;
            this.GeneratePassword.Click += new System.EventHandler(this.GeneratePassword_Click);
            // 
            // chiperText
            // 
            resources.ApplyResources(this.chiperText, "chiperText");
            this.chiperText.Name = "chiperText";
            // 
            // ProcessGroup
            // 
            this.ProcessGroup.Controls.Add(this.ProcessText);
            this.ProcessGroup.Controls.Add(this.radioDecrypt);
            this.ProcessGroup.Controls.Add(this.radioEncrypt);
            resources.ApplyResources(this.ProcessGroup, "ProcessGroup");
            this.ProcessGroup.Name = "ProcessGroup";
            this.ProcessGroup.TabStop = false;
            // 
            // radioEncrypt
            // 
            resources.ApplyResources(this.radioEncrypt, "radioEncrypt");
            this.radioEncrypt.Name = "radioEncrypt";
            this.radioEncrypt.TabStop = true;
            this.radioEncrypt.UseVisualStyleBackColor = true;
            // 
            // radioDecrypt
            // 
            resources.ApplyResources(this.radioDecrypt, "radioDecrypt");
            this.radioDecrypt.Name = "radioDecrypt";
            this.radioDecrypt.TabStop = true;
            this.radioDecrypt.UseVisualStyleBackColor = true;
            // 
            // ProcessText
            // 
            resources.ApplyResources(this.ProcessText, "ProcessText");
            this.ProcessText.Name = "ProcessText";
            this.ProcessText.UseVisualStyleBackColor = true;
            this.ProcessText.Click += new System.EventHandler(this.ProcessText_Click);
            // 
            // passwordLenght
            // 
            resources.ApplyResources(this.passwordLenght, "passwordLenght");
            this.passwordLenght.Name = "passwordLenght";
            this.passwordLenght.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProcessGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ProcessGroup.ResumeLayout(false);
            this.ProcessGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenText;
        private System.Windows.Forms.ToolStripMenuItem SaveText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox chiperText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GeneratePassword;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.GroupBox ProcessGroup;
        private System.Windows.Forms.RadioButton radioDecrypt;
        private System.Windows.Forms.RadioButton radioEncrypt;
        private System.Windows.Forms.Button ProcessText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown passwordLenght;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

