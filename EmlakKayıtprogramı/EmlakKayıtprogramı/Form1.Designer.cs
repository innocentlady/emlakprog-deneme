
namespace EmlakKayıtprogramı
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
            this.button1 = new System.Windows.Forms.Button();
            this.kullaniciadi = new System.Windows.Forms.Label();
            this.textBoxkullaniciadi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ink Free", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(219, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoSize = true;
            this.kullaniciadi.Font = new System.Drawing.Font("Ink Free", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.kullaniciadi.Location = new System.Drawing.Point(71, 93);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(109, 22);
            this.kullaniciadi.TabIndex = 1;
            this.kullaniciadi.Text = "Kullanıcı Adı";
            // 
            // textBoxkullaniciadi
            // 
            this.textBoxkullaniciadi.Location = new System.Drawing.Point(204, 88);
            this.textBoxkullaniciadi.Name = "textBoxkullaniciadi";
            this.textBoxkullaniciadi.Size = new System.Drawing.Size(125, 27);
            this.textBoxkullaniciadi.TabIndex = 2;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Ink Free", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.sifre.Location = new System.Drawing.Point(127, 155);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(53, 22);
            this.sifre.TabIndex = 3;
            this.sifre.Text = "Şifre";
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(204, 155);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(125, 27);
            this.textBoxsifre.TabIndex = 4;
            this.textBoxsifre.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 327);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.textBoxkullaniciadi);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Site Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label kullaniciadi;
        private System.Windows.Forms.TextBox textBoxkullaniciadi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox textBoxsifre;
    }
}

