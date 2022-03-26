
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Select_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connect_B
            // 
            this.Connect_B.Location = new System.Drawing.Point(298, 287);
            this.Connect_B.Name = "Connect_B";
            this.Connect_B.Size = new System.Drawing.Size(89, 32);
            this.Connect_B.TabIndex = 0;
            this.Connect_B.Text = "Connect";
            this.Connect_B.UseVisualStyleBackColor = true;
            this.Connect_B.Click += new System.EventHandler(this.Connect_B_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 152);
            this.textBox1.TabIndex = 1;
            // 
            // Select_B
            // 
            this.Select_B.Location = new System.Drawing.Point(416, 287);
            this.Select_B.Name = "Select_B";
            this.Select_B.Size = new System.Drawing.Size(89, 32);
            this.Select_B.TabIndex = 0;
            this.Select_B.Text = "Select";
            this.Select_B.UseVisualStyleBackColor = true;
            this.Select_B.Click += new System.EventHandler(this.Select_B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Select_B);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Connect_B);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_B;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Select_B;
    }
}

