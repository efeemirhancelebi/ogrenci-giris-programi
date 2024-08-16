namespace ogrenciGirisSistemi
{
    partial class ogrKayitBasarili
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrKayitBasarili));
            labelOgrKayitBasarili = new Label();
            SuspendLayout();
            // 
            // labelOgrKayitBasarili
            // 
            labelOgrKayitBasarili.AutoSize = true;
            labelOgrKayitBasarili.Location = new Point(32, 17);
            labelOgrKayitBasarili.Name = "labelOgrKayitBasarili";
            labelOgrKayitBasarili.Size = new Size(245, 30);
            labelOgrKayitBasarili.TabIndex = 0;
            labelOgrKayitBasarili.Text = "Öğrenci kayıt işleminiz başarıyla tamamlandı.\r\nBu sekmeyi kapatabilirsiniz.";
            labelOgrKayitBasarili.TextAlign = ContentAlignment.TopCenter;
            // 
            // ogrKayitBasarili
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 86);
            Controls.Add(labelOgrKayitBasarili);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ogrKayitBasarili";
            Text = "KAYIT İŞLEMİ BAŞARILI!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOgrKayitBasarili;
    }
}