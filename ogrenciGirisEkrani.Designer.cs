
namespace ogrenciGirisSistemi
{
    partial class ogrenciGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciGirisEkrani));
            labelOgrGirisTitle = new Label();
            tBoxOgrSifre = new TextBox();
            tBoxOgrNo = new TextBox();
            gBoxOgrGiris = new GroupBox();
            labelOgrSifre = new Label();
            labelOgrNo = new Label();
            btnOgrKayit = new Button();
            btnAkaFormGidis = new Button();
            btnOgrGiris = new Button();
            gBoxOgrGiris.SuspendLayout();
            SuspendLayout();
            // 
            // labelOgrGirisTitle
            // 
            labelOgrGirisTitle.AutoSize = true;
            labelOgrGirisTitle.BackColor = Color.Transparent;
            labelOgrGirisTitle.BorderStyle = BorderStyle.FixedSingle;
            labelOgrGirisTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOgrGirisTitle.Location = new Point(42, 9);
            labelOgrGirisTitle.Name = "labelOgrGirisTitle";
            labelOgrGirisTitle.Size = new Size(318, 65);
            labelOgrGirisTitle.TabIndex = 0;
            labelOgrGirisTitle.Text = "TEKİRDAĞ NAMIK KEMAL ÜNİVERSİTESİ \r\nÖĞRENCİ SİSTEMİ \r\nGİRİŞ PANELİ";
            labelOgrGirisTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBoxOgrSifre
            // 
            tBoxOgrSifre.Font = new Font("Segoe UI", 9F);
            tBoxOgrSifre.Location = new Point(240, 31);
            tBoxOgrSifre.Name = "tBoxOgrSifre";
            tBoxOgrSifre.Size = new Size(106, 23);
            tBoxOgrSifre.TabIndex = 1;
            // 
            // tBoxOgrNo
            // 
            tBoxOgrNo.Font = new Font("Segoe UI", 9F);
            tBoxOgrNo.Location = new Point(85, 31);
            tBoxOgrNo.Name = "tBoxOgrNo";
            tBoxOgrNo.Size = new Size(109, 23);
            tBoxOgrNo.TabIndex = 3;
            // 
            // gBoxOgrGiris
            // 
            gBoxOgrGiris.BackColor = SystemColors.Control;
            gBoxOgrGiris.Controls.Add(labelOgrSifre);
            gBoxOgrGiris.Controls.Add(labelOgrNo);
            gBoxOgrGiris.Controls.Add(tBoxOgrSifre);
            gBoxOgrGiris.Controls.Add(tBoxOgrNo);
            gBoxOgrGiris.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gBoxOgrGiris.Location = new Point(12, 104);
            gBoxOgrGiris.Name = "gBoxOgrGiris";
            gBoxOgrGiris.Size = new Size(360, 70);
            gBoxOgrGiris.TabIndex = 5;
            gBoxOgrGiris.TabStop = false;
            gBoxOgrGiris.Text = "ÖĞRENCİ GİRİŞ ALANI";
            // 
            // labelOgrSifre
            // 
            labelOgrSifre.AutoSize = true;
            labelOgrSifre.Font = new Font("Segoe UI", 9F);
            labelOgrSifre.Location = new Point(200, 34);
            labelOgrSifre.Name = "labelOgrSifre";
            labelOgrSifre.Size = new Size(33, 15);
            labelOgrSifre.TabIndex = 7;
            labelOgrSifre.Text = "Şifre:";
            // 
            // labelOgrNo
            // 
            labelOgrNo.AutoSize = true;
            labelOgrNo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOgrNo.Location = new Point(6, 34);
            labelOgrNo.Name = "labelOgrNo";
            labelOgrNo.Size = new Size(73, 15);
            labelOgrNo.TabIndex = 6;
            labelOgrNo.Text = "Öğrenci NO:";
            // 
            // btnOgrKayit
            // 
            btnOgrKayit.BackColor = Color.Transparent;
            btnOgrKayit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOgrKayit.Location = new Point(12, 180);
            btnOgrKayit.Name = "btnOgrKayit";
            btnOgrKayit.Size = new Size(360, 30);
            btnOgrKayit.TabIndex = 6;
            btnOgrKayit.Text = "Eğer sisteme kayıtlı değilseniz kayıt olarak hesabınızı ilişkilendirin!";
            btnOgrKayit.UseVisualStyleBackColor = false;
            btnOgrKayit.Click += btnOgrKayit_Click;
            // 
            // btnAkaFormGidis
            // 
            btnAkaFormGidis.BackColor = Color.Transparent;
            btnAkaFormGidis.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAkaFormGidis.Location = new Point(12, 252);
            btnAkaFormGidis.Name = "btnAkaFormGidis";
            btnAkaFormGidis.Size = new Size(360, 30);
            btnAkaFormGidis.TabIndex = 7;
            btnAkaFormGidis.Text = "AKADEMİSYEN GİRİŞİ";
            btnAkaFormGidis.UseVisualStyleBackColor = false;
            btnAkaFormGidis.Click += btnAkaFormGidis_Click;
            // 
            // btnOgrGiris
            // 
            btnOgrGiris.BackColor = Color.Transparent;
            btnOgrGiris.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOgrGiris.Location = new Point(12, 216);
            btnOgrGiris.Name = "btnOgrGiris";
            btnOgrGiris.Size = new Size(360, 30);
            btnOgrGiris.TabIndex = 8;
            btnOgrGiris.Text = "GİRİŞ";
            btnOgrGiris.UseVisualStyleBackColor = false;
            btnOgrGiris.Click += btnOgrGiris_Click;
            // 
            // ogrenciGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(384, 291);
            Controls.Add(btnOgrGiris);
            Controls.Add(btnAkaFormGidis);
            Controls.Add(btnOgrKayit);
            Controls.Add(gBoxOgrGiris);
            Controls.Add(labelOgrGirisTitle);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ogrenciGirisEkrani";
            Text = "ÖĞRENCİ GİRİŞ SİSTEMİ";
            gBoxOgrGiris.ResumeLayout(false);
            gBoxOgrGiris.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOgrGirisTitle;
        private TextBox tBoxOgrSifre;
        private TextBox tBoxOgrNo;
        private GroupBox gBoxOgrGiris;
        private Label labelOgrNo;
        private Label labelOgrSifre;
        private Button btnOgrKayit;
        private Button btnAkaFormGidis;
        private Button btnOgrGiris;
        private PictureBox pictureBox1;
    }
}
