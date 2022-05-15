
namespace Proiect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connect_B = new System.Windows.Forms.Button();
            this.Text_from_file = new System.Windows.Forms.TextBox();
            this.Save_metrics = new System.Windows.Forms.Button();
            this.List_Crypto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Open_File_B = new System.Windows.Forms.Button();
            this.Crypt_B = new System.Windows.Forms.Button();
            this.Decrypt_B = new System.Windows.Forms.Button();
            this.Console = new System.Windows.Forms.TextBox();
            this.Console_labe = new System.Windows.Forms.Label();
            this.File_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Connect_B
            // 
            this.Connect_B.Location = new System.Drawing.Point(12, 406);
            this.Connect_B.Name = "Connect_B";
            this.Connect_B.Size = new System.Drawing.Size(89, 32);
            this.Connect_B.TabIndex = 0;
            this.Connect_B.Text = "Connect";
            this.Connect_B.UseVisualStyleBackColor = true;
            this.Connect_B.Click += new System.EventHandler(this.Connect_B_Click);
            // 
            // Text_from_file
            // 
            this.Text_from_file.Location = new System.Drawing.Point(12, 33);
            this.Text_from_file.Multiline = true;
            this.Text_from_file.Name = "Text_from_file";
            this.Text_from_file.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_from_file.Size = new System.Drawing.Size(647, 269);
            this.Text_from_file.TabIndex = 1;
            // 
            // Save_metrics
            // 
            this.Save_metrics.Enabled = false;
            this.Save_metrics.Location = new System.Drawing.Point(665, 100);
            this.Save_metrics.Name = "Save_metrics";
            this.Save_metrics.Size = new System.Drawing.Size(140, 32);
            this.Save_metrics.TabIndex = 0;
            this.Save_metrics.Text = "Salvati performantele";
            this.Save_metrics.UseVisualStyleBackColor = true;
            this.Save_metrics.Click += new System.EventHandler(this.Select_B_Click);
            // 
            // List_Crypto
            // 
            this.List_Crypto.FormattingEnabled = true;
            this.List_Crypto.Items.AddRange(new object[] {
            "1- ASN1",
            "2- AES",
            "3- DES",
            "4- RSA",
            "5- SHA1",
            "6- SHA256"});
            this.List_Crypto.Location = new System.Drawing.Point(665, 33);
            this.List_Crypto.Name = "List_Crypto";
            this.List_Crypto.Size = new System.Drawing.Size(140, 23);
            this.List_Crypto.TabIndex = 2;
            this.List_Crypto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selectati Algoritmul";
            // 
            // Open_File_B
            // 
            this.Open_File_B.Location = new System.Drawing.Point(202, 406);
            this.Open_File_B.Name = "Open_File_B";
            this.Open_File_B.Size = new System.Drawing.Size(89, 32);
            this.Open_File_B.TabIndex = 4;
            this.Open_File_B.Text = "Open File";
            this.Open_File_B.UseVisualStyleBackColor = true;
            this.Open_File_B.Click += new System.EventHandler(this.Open_B_Click);
            // 
            // Crypt_B
            // 
            this.Crypt_B.Enabled = false;
            this.Crypt_B.Location = new System.Drawing.Point(665, 62);
            this.Crypt_B.Name = "Crypt_B";
            this.Crypt_B.Size = new System.Drawing.Size(67, 32);
            this.Crypt_B.TabIndex = 5;
            this.Crypt_B.Text = "Criptati";
            this.Crypt_B.UseVisualStyleBackColor = true;
            this.Crypt_B.Click += new System.EventHandler(this.Crypt_B_Click);
            // 
            // Decrypt_B
            // 
            this.Decrypt_B.Enabled = false;
            this.Decrypt_B.Location = new System.Drawing.Point(738, 62);
            this.Decrypt_B.Name = "Decrypt_B";
            this.Decrypt_B.Size = new System.Drawing.Size(67, 32);
            this.Decrypt_B.TabIndex = 6;
            this.Decrypt_B.Text = "Decriptati";
            this.Decrypt_B.UseVisualStyleBackColor = true;
            this.Decrypt_B.Click += new System.EventHandler(this.Decrypt_B_Click);
            // 
            // Console
            // 
            this.Console.Location = new System.Drawing.Point(12, 323);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Console.Size = new System.Drawing.Size(421, 73);
            this.Console.TabIndex = 7;
            // 
            // Console_labe
            // 
            this.Console_labe.AutoSize = true;
            this.Console_labe.Location = new System.Drawing.Point(12, 305);
            this.Console_labe.Name = "Console_labe";
            this.Console_labe.Size = new System.Drawing.Size(97, 15);
            this.Console_labe.TabIndex = 8;
            this.Console_labe.Text = "MYSQL_Console:";
            // 
            // File_Name
            // 
            this.File_Name.AutoSize = true;
            this.File_Name.Location = new System.Drawing.Point(12, 12);
            this.File_Name.Name = "File_Name";
            this.File_Name.Size = new System.Drawing.Size(0, 15);
            this.File_Name.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.File_Name);
            this.Controls.Add(this.Console_labe);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.Decrypt_B);
            this.Controls.Add(this.Crypt_B);
            this.Controls.Add(this.Open_File_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_Crypto);
            this.Controls.Add(this.Save_metrics);
            this.Controls.Add(this.Text_from_file);
            this.Controls.Add(this.Connect_B);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_B;
        private System.Windows.Forms.TextBox Text_from_file;
        private System.Windows.Forms.Button Save_metrics;
        private System.Windows.Forms.ComboBox List_Crypto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Open_File_B;
        private System.Windows.Forms.Button Crypt_B;
        private System.Windows.Forms.Button Decrypt_B;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.Label Console_labe;
        private System.Windows.Forms.Label File_Name;
    }
}

