namespace ogrenciGirisSistemi
{
    partial class ogrKayitBasarisiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrKayitBasarisiz));
            labelOgrKayitBasarisiz = new Label();
            btnHataKodu = new Button();
            SuspendLayout();
            // 
            // labelOgrKayitBasarisiz
            // 
            labelOgrKayitBasarisiz.AutoSize = true;
            labelOgrKayitBasarisiz.Location = new Point(33, 17);
            labelOgrKayitBasarisiz.Name = "labelOgrKayitBasarisiz";
            labelOgrKayitBasarisiz.Size = new Size(258, 30);
            labelOgrKayitBasarisiz.TabIndex = 1;
            labelOgrKayitBasarisiz.Text = "Öğrenci kayıt işleminiz başarısızlıkla sonuçlandı.\r\nLütfen tekrar kayıt olmayı deneyin.";
            labelOgrKayitBasarisiz.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnHataKodu
            // 
            btnHataKodu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHataKodu.Location = new Point(125, 51);
            btnHataKodu.Name = "btnHataKodu";
            btnHataKodu.Size = new Size(75, 23);
            btnHataKodu.TabIndex = 2;
            btnHataKodu.Text = "Hata Kodu";
            btnHataKodu.UseVisualStyleBackColor = true;
            btnHataKodu.Click += btnHataKodu_Click;
            // 
            // ogrKayitBasarisiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 86);
            Controls.Add(btnHataKodu);
            Controls.Add(labelOgrKayitBasarisiz);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ogrKayitBasarisiz";
            Text = "KAYIT BAŞARISIZ!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOgrKayitBasarisiz;
        private Button btnHataKodu;
    }
}