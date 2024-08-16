namespace ogrenciGirisSistemi
{
    partial class ogrenciKayitEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciKayitEkrani));
            labelOgrKayitTitle = new Label();
            labelOgrAd = new Label();
            labelOgrSoyad = new Label();
            labelOgrAnne = new Label();
            labelOgrTc = new Label();
            labelOgrDogum = new Label();
            labelOgrBaba = new Label();
            tBoxOgrAd = new TextBox();
            tBoxOgrSoyad = new TextBox();
            tBoxOgrTc = new TextBox();
            tBoxOgrAnne = new TextBox();
            tBoxOgrBaba = new TextBox();
            dateTimePickerOgrDogum = new DateTimePicker();
            tBoxOgrSifre = new TextBox();
            labelOgrSifre = new Label();
            labelOgrSifreTekrar = new Label();
            tBoxOgrSifreTekrar = new TextBox();
            labelOgrMail = new Label();
            tBoxOgrMail = new TextBox();
            gBoxOgrKayit = new GroupBox();
            btnOgrKayitTamamla = new Button();
            btnOgrKayitGirisDon = new Button();
            gBoxOgrKayit.SuspendLayout();
            SuspendLayout();
            // 
            // labelOgrKayitTitle
            // 
            labelOgrKayitTitle.AutoSize = true;
            labelOgrKayitTitle.BackColor = Color.Transparent;
            labelOgrKayitTitle.BorderStyle = BorderStyle.FixedSingle;
            labelOgrKayitTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOgrKayitTitle.Location = new Point(42, 9);
            labelOgrKayitTitle.Name = "labelOgrKayitTitle";
            labelOgrKayitTitle.Size = new Size(318, 65);
            labelOgrKayitTitle.TabIndex = 1;
            labelOgrKayitTitle.Text = "TEKİRDAĞ NAMIK KEMAL ÜNİVERSİTESİ \r\nÖĞRENCİ SİSTEMİ \r\nKAYIT PANELİ";
            labelOgrKayitTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOgrAd
            // 
            labelOgrAd.AutoSize = true;
            labelOgrAd.Font = new Font("Segoe UI", 9F);
            labelOgrAd.ImageAlign = ContentAlignment.TopCenter;
            labelOgrAd.Location = new Point(79, 22);
            labelOgrAd.Name = "labelOgrAd";
            labelOgrAd.Size = new Size(25, 15);
            labelOgrAd.TabIndex = 2;
            labelOgrAd.Text = "Ad:";
            // 
            // labelOgrSoyad
            // 
            labelOgrSoyad.AutoSize = true;
            labelOgrSoyad.Font = new Font("Segoe UI", 9F);
            labelOgrSoyad.ImageAlign = ContentAlignment.TopCenter;
            labelOgrSoyad.Location = new Point(62, 51);
            labelOgrSoyad.Name = "labelOgrSoyad";
            labelOgrSoyad.Size = new Size(42, 15);
            labelOgrSoyad.TabIndex = 3;
            labelOgrSoyad.Text = "Soyad:";
            // 
            // labelOgrAnne
            // 
            labelOgrAnne.AutoSize = true;
            labelOgrAnne.Font = new Font("Segoe UI", 9F);
            labelOgrAnne.ImageAlign = ContentAlignment.TopCenter;
            labelOgrAnne.Location = new Point(45, 109);
            labelOgrAnne.Name = "labelOgrAnne";
            labelOgrAnne.Size = new Size(59, 15);
            labelOgrAnne.TabIndex = 5;
            labelOgrAnne.Text = "Anne Adı:";
            // 
            // labelOgrTc
            // 
            labelOgrTc.AutoSize = true;
            labelOgrTc.Font = new Font("Segoe UI", 9F);
            labelOgrTc.ImageAlign = ContentAlignment.TopCenter;
            labelOgrTc.Location = new Point(60, 80);
            labelOgrTc.Name = "labelOgrTc";
            labelOgrTc.Size = new Size(44, 15);
            labelOgrTc.TabIndex = 4;
            labelOgrTc.Text = "TC NO:";
            // 
            // labelOgrDogum
            // 
            labelOgrDogum.AutoSize = true;
            labelOgrDogum.Font = new Font("Segoe UI", 9F);
            labelOgrDogum.Location = new Point(23, 167);
            labelOgrDogum.Name = "labelOgrDogum";
            labelOgrDogum.Size = new Size(81, 15);
            labelOgrDogum.TabIndex = 7;
            labelOgrDogum.Text = "Doğum Tarihi:";
            // 
            // labelOgrBaba
            // 
            labelOgrBaba.AutoSize = true;
            labelOgrBaba.Font = new Font("Segoe UI", 9F);
            labelOgrBaba.ImageAlign = ContentAlignment.TopCenter;
            labelOgrBaba.Location = new Point(47, 138);
            labelOgrBaba.Name = "labelOgrBaba";
            labelOgrBaba.Size = new Size(57, 15);
            labelOgrBaba.TabIndex = 6;
            labelOgrBaba.Text = "Baba Adı:";
            // 
            // tBoxOgrAd
            // 
            tBoxOgrAd.Font = new Font("Segoe UI", 9F);
            tBoxOgrAd.Location = new Point(110, 22);
            tBoxOgrAd.Name = "tBoxOgrAd";
            tBoxOgrAd.Size = new Size(200, 23);
            tBoxOgrAd.TabIndex = 8;
            tBoxOgrAd.TextChanged += tBoxOgrAd_TextChanged;
            // 
            // tBoxOgrSoyad
            // 
            tBoxOgrSoyad.Font = new Font("Segoe UI", 9F);
            tBoxOgrSoyad.Location = new Point(110, 51);
            tBoxOgrSoyad.Name = "tBoxOgrSoyad";
            tBoxOgrSoyad.Size = new Size(200, 23);
            tBoxOgrSoyad.TabIndex = 9;
            // 
            // tBoxOgrTc
            // 
            tBoxOgrTc.Font = new Font("Segoe UI", 9F);
            tBoxOgrTc.Location = new Point(110, 80);
            tBoxOgrTc.Name = "tBoxOgrTc";
            tBoxOgrTc.Size = new Size(200, 23);
            tBoxOgrTc.TabIndex = 10;
            // 
            // tBoxOgrAnne
            // 
            tBoxOgrAnne.Font = new Font("Segoe UI", 9F);
            tBoxOgrAnne.Location = new Point(110, 109);
            tBoxOgrAnne.Name = "tBoxOgrAnne";
            tBoxOgrAnne.Size = new Size(200, 23);
            tBoxOgrAnne.TabIndex = 11;
            // 
            // tBoxOgrBaba
            // 
            tBoxOgrBaba.Font = new Font("Segoe UI", 9F);
            tBoxOgrBaba.Location = new Point(110, 138);
            tBoxOgrBaba.Name = "tBoxOgrBaba";
            tBoxOgrBaba.Size = new Size(200, 23);
            tBoxOgrBaba.TabIndex = 12;
            // 
            // dateTimePickerOgrDogum
            // 
            dateTimePickerOgrDogum.Font = new Font("Segoe UI", 9F);
            dateTimePickerOgrDogum.Location = new Point(110, 167);
            dateTimePickerOgrDogum.Name = "dateTimePickerOgrDogum";
            dateTimePickerOgrDogum.Size = new Size(200, 23);
            dateTimePickerOgrDogum.TabIndex = 13;
            // 
            // tBoxOgrSifre
            // 
            tBoxOgrSifre.Font = new Font("Segoe UI", 9F);
            tBoxOgrSifre.Location = new Point(110, 196);
            tBoxOgrSifre.Name = "tBoxOgrSifre";
            tBoxOgrSifre.Size = new Size(200, 23);
            tBoxOgrSifre.TabIndex = 14;
            // 
            // labelOgrSifre
            // 
            labelOgrSifre.AutoSize = true;
            labelOgrSifre.Font = new Font("Segoe UI", 9F);
            labelOgrSifre.Location = new Point(71, 196);
            labelOgrSifre.Name = "labelOgrSifre";
            labelOgrSifre.Size = new Size(33, 15);
            labelOgrSifre.TabIndex = 15;
            labelOgrSifre.Text = "Şifre:";
            // 
            // labelOgrSifreTekrar
            // 
            labelOgrSifreTekrar.AutoSize = true;
            labelOgrSifreTekrar.Font = new Font("Segoe UI", 9F);
            labelOgrSifreTekrar.Location = new Point(34, 225);
            labelOgrSifreTekrar.Name = "labelOgrSifreTekrar";
            labelOgrSifreTekrar.Size = new Size(70, 15);
            labelOgrSifreTekrar.TabIndex = 17;
            labelOgrSifreTekrar.Text = "Şifre Tekrarı:";
            // 
            // tBoxOgrSifreTekrar
            // 
            tBoxOgrSifreTekrar.Font = new Font("Segoe UI", 9F);
            tBoxOgrSifreTekrar.Location = new Point(110, 225);
            tBoxOgrSifreTekrar.Name = "tBoxOgrSifreTekrar";
            tBoxOgrSifreTekrar.Size = new Size(200, 23);
            tBoxOgrSifreTekrar.TabIndex = 16;
            // 
            // labelOgrMail
            // 
            labelOgrMail.AutoSize = true;
            labelOgrMail.Font = new Font("Segoe UI", 9F);
            labelOgrMail.Location = new Point(18, 254);
            labelOgrMail.Name = "labelOgrMail";
            labelOgrMail.Size = new Size(86, 15);
            labelOgrMail.TabIndex = 19;
            labelOgrMail.Text = "E-posta Adresi:";
            // 
            // tBoxOgrMail
            // 
            tBoxOgrMail.Font = new Font("Segoe UI", 9F);
            tBoxOgrMail.Location = new Point(110, 254);
            tBoxOgrMail.Name = "tBoxOgrMail";
            tBoxOgrMail.Size = new Size(200, 23);
            tBoxOgrMail.TabIndex = 18;
            // 
            // gBoxOgrKayit
            // 
            gBoxOgrKayit.Controls.Add(tBoxOgrAd);
            gBoxOgrKayit.Controls.Add(labelOgrMail);
            gBoxOgrKayit.Controls.Add(labelOgrTc);
            gBoxOgrKayit.Controls.Add(tBoxOgrMail);
            gBoxOgrKayit.Controls.Add(labelOgrAnne);
            gBoxOgrKayit.Controls.Add(labelOgrSifreTekrar);
            gBoxOgrKayit.Controls.Add(labelOgrBaba);
            gBoxOgrKayit.Controls.Add(tBoxOgrSifreTekrar);
            gBoxOgrKayit.Controls.Add(labelOgrSoyad);
            gBoxOgrKayit.Controls.Add(labelOgrSifre);
            gBoxOgrKayit.Controls.Add(labelOgrDogum);
            gBoxOgrKayit.Controls.Add(tBoxOgrSifre);
            gBoxOgrKayit.Controls.Add(labelOgrAd);
            gBoxOgrKayit.Controls.Add(dateTimePickerOgrDogum);
            gBoxOgrKayit.Controls.Add(tBoxOgrSoyad);
            gBoxOgrKayit.Controls.Add(tBoxOgrBaba);
            gBoxOgrKayit.Controls.Add(tBoxOgrTc);
            gBoxOgrKayit.Controls.Add(tBoxOgrAnne);
            gBoxOgrKayit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            gBoxOgrKayit.Location = new Point(42, 97);
            gBoxOgrKayit.Name = "gBoxOgrKayit";
            gBoxOgrKayit.Size = new Size(316, 290);
            gBoxOgrKayit.TabIndex = 20;
            gBoxOgrKayit.TabStop = false;
            gBoxOgrKayit.Text = "ÖĞRENCİ KAYIT EKRANI";
            // 
            // btnOgrKayitTamamla
            // 
            btnOgrKayitTamamla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgrKayitTamamla.Location = new Point(42, 393);
            btnOgrKayitTamamla.Name = "btnOgrKayitTamamla";
            btnOgrKayitTamamla.Size = new Size(316, 30);
            btnOgrKayitTamamla.TabIndex = 21;
            btnOgrKayitTamamla.Text = "Kayıt işlemini tamamla!";
            btnOgrKayitTamamla.UseVisualStyleBackColor = true;
            btnOgrKayitTamamla.Click += btnOgrKayitTamamla_Click;
            // 
            // btnOgrKayitGirisDon
            // 
            btnOgrKayitGirisDon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgrKayitGirisDon.Location = new Point(42, 429);
            btnOgrKayitGirisDon.Name = "btnOgrKayitGirisDon";
            btnOgrKayitGirisDon.Size = new Size(316, 30);
            btnOgrKayitGirisDon.TabIndex = 22;
            btnOgrKayitGirisDon.Text = "Giriş sayfasına dön.";
            btnOgrKayitGirisDon.UseVisualStyleBackColor = true;
            btnOgrKayitGirisDon.Click += btnOgrKayitGirisDon_Click;
            // 
            // ogrenciKayitEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(384, 471);
            Controls.Add(btnOgrKayitGirisDon);
            Controls.Add(btnOgrKayitTamamla);
            Controls.Add(gBoxOgrKayit);
            Controls.Add(labelOgrKayitTitle);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ogrenciKayitEkrani";
            Text = "ÖĞRENCİ KAYIT SİSTEMİ";
            gBoxOgrKayit.ResumeLayout(false);
            gBoxOgrKayit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOgrKayitTitle;
        private Label labelOgrAd;
        private Label labelOgrSoyad;
        private Label labelOgrAnne;
        private Label labelOgrTc;
        private Label labelOgrDogum;
        private Label labelOgrBaba;
        private TextBox tBoxOgrAd;
        private TextBox tBoxOgrSoyad;
        private TextBox tBoxOgrTc;
        private TextBox tBoxOgrAnne;
        private TextBox tBoxOgrBaba;
        private DateTimePicker dateTimePickerOgrDogum;
        private TextBox tBoxOgrSifre;
        private Label labelOgrSifre;
        private Label labelOgrSifreTekrar;
        private TextBox tBoxOgrSifreTekrar;
        private Label labelOgrMail;
        private TextBox tBoxOgrMail;
        private GroupBox gBoxOgrKayit;
        private Button btnOgrKayitTamamla;
        private Button btnOgrKayitGirisDon;
    }
}