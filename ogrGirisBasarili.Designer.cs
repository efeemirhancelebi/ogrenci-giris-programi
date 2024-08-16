namespace ogrenciGirisSistemi
{
    partial class ogrGirisBasarili
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrGirisBasarili));
            labelOgrGirisBasarili = new Label();
            SuspendLayout();
            // 
            // labelOgrGirisBasarili
            // 
            labelOgrGirisBasarili.AutoSize = true;
            labelOgrGirisBasarili.Location = new Point(32, 17);
            labelOgrGirisBasarili.Name = "labelOgrGirisBasarili";
            labelOgrGirisBasarili.Size = new Size(242, 30);
            labelOgrGirisBasarili.TabIndex = 1;
            labelOgrGirisBasarili.Text = "Öğrenci giriş işleminiz başarıyla tamamlandı.\r\nBu sekmeyi kapatabilirsiniz.";
            labelOgrGirisBasarili.TextAlign = ContentAlignment.TopCenter;
            // 
            // ogrGirisBasarili
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 86);
            Controls.Add(labelOgrGirisBasarili);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ogrGirisBasarili";
            Text = "GİRİŞ İŞLEMİNİZ BAŞARILI!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOgrGirisBasarili;
    }
}