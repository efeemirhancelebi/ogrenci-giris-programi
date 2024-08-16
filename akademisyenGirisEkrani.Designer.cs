namespace ogrenciGirisSistemi
{
    partial class akademisyenGirisEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(akademisyenGirisEkrani));
            labelAkaTitle = new Label();
            gBoxAkaGiris = new GroupBox();
            labelAkaMail = new Label();
            tBoxAkaMail = new TextBox();
            labelAkaSifre = new Label();
            labelAkaTc = new Label();
            tBoxAkaSifre = new TextBox();
            tBoxAkaTc = new TextBox();
            btnAkaGiris = new Button();
            gBoxAkaGiris.SuspendLayout();
            SuspendLayout();
            // 
            // labelAkaTitle
            // 
            labelAkaTitle.AutoSize = true;
            labelAkaTitle.BackColor = Color.Transparent;
            labelAkaTitle.BorderStyle = BorderStyle.FixedSingle;
            labelAkaTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAkaTitle.Location = new Point(42, 9);
            labelAkaTitle.Name = "labelAkaTitle";
            labelAkaTitle.Size = new Size(318, 65);
            labelAkaTitle.TabIndex = 2;
            labelAkaTitle.Text = "TEKİRDAĞ NAMIK KEMAL ÜNİVERSİTESİ \r\nAKADEMİSYEN SİSTEMİ \r\nGİRİŞ PANELİ";
            labelAkaTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gBoxAkaGiris
            // 
            gBoxAkaGiris.Controls.Add(labelAkaMail);
            gBoxAkaGiris.Controls.Add(tBoxAkaMail);
            gBoxAkaGiris.Controls.Add(labelAkaSifre);
            gBoxAkaGiris.Controls.Add(labelAkaTc);
            gBoxAkaGiris.Controls.Add(tBoxAkaSifre);
            gBoxAkaGiris.Controls.Add(tBoxAkaTc);
            gBoxAkaGiris.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gBoxAkaGiris.Location = new Point(10, 105);
            gBoxAkaGiris.Name = "gBoxAkaGiris";
            gBoxAkaGiris.Size = new Size(365, 109);
            gBoxAkaGiris.TabIndex = 6;
            gBoxAkaGiris.TabStop = false;
            gBoxAkaGiris.Text = "AKADEMİSYEN GİRİŞ ALANI";
            // 
            // labelAkaMail
            // 
            labelAkaMail.AutoSize = true;
            labelAkaMail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAkaMail.Location = new Point(6, 60);
            labelAkaMail.Name = "labelAkaMail";
            labelAkaMail.Size = new Size(84, 15);
            labelAkaMail.TabIndex = 9;
            labelAkaMail.Text = "E-posta adresi:";
            // 
            // tBoxAkaMail
            // 
            tBoxAkaMail.Font = new Font("Segoe UI", 9F);
            tBoxAkaMail.Location = new Point(96, 60);
            tBoxAkaMail.Name = "tBoxAkaMail";
            tBoxAkaMail.Size = new Size(261, 23);
            tBoxAkaMail.TabIndex = 8;
            // 
            // labelAkaSifre
            // 
            labelAkaSifre.AutoSize = true;
            labelAkaSifre.Font = new Font("Segoe UI", 9F);
            labelAkaSifre.Location = new Point(211, 34);
            labelAkaSifre.Name = "labelAkaSifre";
            labelAkaSifre.Size = new Size(33, 15);
            labelAkaSifre.TabIndex = 7;
            labelAkaSifre.Text = "Şifre:";
            // 
            // labelAkaTc
            // 
            labelAkaTc.AutoSize = true;
            labelAkaTc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAkaTc.Location = new Point(46, 31);
            labelAkaTc.Name = "labelAkaTc";
            labelAkaTc.Size = new Size(44, 15);
            labelAkaTc.TabIndex = 6;
            labelAkaTc.Text = "TC NO:";
            // 
            // tBoxAkaSifre
            // 
            tBoxAkaSifre.Font = new Font("Segoe UI", 9F);
            tBoxAkaSifre.Location = new Point(251, 31);
            tBoxAkaSifre.Name = "tBoxAkaSifre";
            tBoxAkaSifre.Size = new Size(106, 23);
            tBoxAkaSifre.TabIndex = 1;
            // 
            // tBoxAkaTc
            // 
            tBoxAkaTc.Font = new Font("Segoe UI", 9F);
            tBoxAkaTc.Location = new Point(96, 31);
            tBoxAkaTc.Name = "tBoxAkaTc";
            tBoxAkaTc.Size = new Size(109, 23);
            tBoxAkaTc.TabIndex = 3;
            // 
            // btnAkaGiris
            // 
            btnAkaGiris.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAkaGiris.Location = new Point(10, 220);
            btnAkaGiris.Name = "btnAkaGiris";
            btnAkaGiris.Size = new Size(365, 30);
            btnAkaGiris.TabIndex = 7;
            btnAkaGiris.Text = "GİRİŞ";
            btnAkaGiris.UseVisualStyleBackColor = true;
            btnAkaGiris.Click += btnAkaGiris_Click;
            // 
            // akademisyenGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(384, 291);
            Controls.Add(btnAkaGiris);
            Controls.Add(gBoxAkaGiris);
            Controls.Add(labelAkaTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "akademisyenGirisEkrani";
            Text = "AKADEMİSYEN GİRİŞ SİSTEMİ";
            gBoxAkaGiris.ResumeLayout(false);
            gBoxAkaGiris.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAkaTitle;
        private GroupBox gBoxAkaGiris;
        private Label labelAkaMail;
        private TextBox tBoxAkaMail;
        private Label labelAkaSifre;
        private Label labelAkaTc;
        private TextBox tBoxAkaSifre;
        private TextBox tBoxAkaTc;
        private Button btnAkaGiris;
    }
}