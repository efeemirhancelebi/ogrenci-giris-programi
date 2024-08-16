namespace ogrenciGirisSistemi
{
    partial class ogrGirisBasarisiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrGirisBasarisiz));
            labelOgrGirisBasarisiz = new Label();
            btnOgrDonus = new Button();
            SuspendLayout();
            // 
            // labelOgrGirisBasarisiz
            // 
            labelOgrGirisBasarisiz.AutoSize = true;
            labelOgrGirisBasarisiz.Location = new Point(36, 9);
            labelOgrGirisBasarisiz.Name = "labelOgrGirisBasarisiz";
            labelOgrGirisBasarisiz.Size = new Size(232, 45);
            labelOgrGirisBasarisiz.TabIndex = 0;
            labelOgrGirisBasarisiz.Text = "Öğrenci üyemiz giriş işleminiz başarısızlıkla\r\nsonuçlandı. Lütfen bilgilerinizi kontrol edip\r\ntekrar giriş yapmayı deneyin.";
            labelOgrGirisBasarisiz.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnOgrDonus
            // 
            btnOgrDonus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgrDonus.Location = new Point(36, 57);
            btnOgrDonus.Name = "btnOgrDonus";
            btnOgrDonus.Size = new Size(232, 23);
            btnOgrDonus.TabIndex = 1;
            btnOgrDonus.Text = "Giriş sayfasına dön.";
            btnOgrDonus.UseVisualStyleBackColor = true;
            btnOgrDonus.Click += btnOgrDonus_Click;
            // 
            // ogrGirisBasarisiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 86);
            Controls.Add(btnOgrDonus);
            Controls.Add(labelOgrGirisBasarisiz);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ogrGirisBasarisiz";
            Text = "GİRİŞ BAŞARISIZ!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOgrGirisBasarisiz;
        private Button btnOgrDonus;
    }
}