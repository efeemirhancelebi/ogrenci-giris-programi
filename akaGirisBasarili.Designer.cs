﻿namespace ogrenciGirisSistemi
{
    partial class akaGirisBasarili
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(akaGirisBasarili));
            labelAkaGirisBasarili = new Label();
            SuspendLayout();
            // 
            // labelAkaGirisBasarili
            // 
            labelAkaGirisBasarili.AutoSize = true;
            labelAkaGirisBasarili.Location = new Point(20, 17);
            labelAkaGirisBasarili.Name = "labelAkaGirisBasarili";
            labelAkaGirisBasarili.Size = new Size(271, 30);
            labelAkaGirisBasarili.TabIndex = 2;
            labelAkaGirisBasarili.Text = "Akademisyen giriş işleminiz başarıyla tamamlandı.\r\nBu sekmeyi kapatabilirsiniz.";
            labelAkaGirisBasarili.TextAlign = ContentAlignment.TopCenter;
            // 
            // akaGirisBasarili
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 86);
            Controls.Add(labelAkaGirisBasarili);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "akaGirisBasarili";
            Text = "GİRİŞ İŞLEMİNİZ BAŞARILI!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAkaGirisBasarili;
    }
}