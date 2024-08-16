using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ogrenciGirisSistemi
{
    public partial class ogrenciKayitEkrani : Form
    {
        public ogrenciKayitEkrani()
        {
            InitializeComponent();
        }

        private void btnOgrKayitGirisDon_Click(object sender, EventArgs e)
        {
            ogrenciGirisEkrani ogrenciGirisEkrani = new ogrenciGirisEkrani();
            ogrenciGirisEkrani.Show();
            this.Hide();
        }

        private void btnOgrKayitTamamla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBoxOgrAd.Text) ||
                string.IsNullOrWhiteSpace(tBoxOgrSoyad.Text) ||
                string.IsNullOrWhiteSpace(tBoxOgrTc.Text) ||
                string.IsNullOrWhiteSpace(tBoxOgrAnne.Text) ||
                string.IsNullOrWhiteSpace(tBoxOgrBaba.Text) ||
                string.IsNullOrWhiteSpace(tBoxOgrSifre.Text) ||
                string.IsNullOrWhiteSpace(tBoxOgrMail.Text) ||
                dateTimePickerOgrDogum.Value == DateTime.MinValue)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ogrAd = tBoxOgrAd.Text; 
            string ogrSoyad = tBoxOgrSoyad.Text;
            string ogrTc = "";
            string input = tBoxOgrTc.Text;
            string ogrSifre = "";
            string ogrMail = tBoxOgrMail.Text;
            string OgrSifreTekrar = tBoxOgrSifre.Text;
            if (input.Length == 11)
            {
                bool isAlphabetic = input.All(char.IsLetter);

                if (isAlphabetic)
                {
                    MessageBox.Show("TC Kimlik numaranız harflerden oluşamaz.");
                    return;
                }
                else
                {
                    ogrTc = input;
                }
            }
            else
            {
                MessageBox.Show("TC Kimlik numarası tam olarak 11 karakter uzunluğunda olmalıdır.");
                return;
            }

            string ogrAnne = tBoxOgrAnne.Text;
            string ogrBaba = tBoxOgrBaba.Text;
            DateTime ogrDogum = dateTimePickerOgrDogum.Value;
            DateTime bugun = DateTime.Today;
            int ogrYas = bugun.Year - ogrDogum.Year;
            if (bugun < ogrDogum.AddYears(ogrYas))
            {
                ogrYas--;
            }
            else
            {

            }
            if (ogrYas < 18)
            {
                MessageBox.Show("Doğum tarihiniz hatalı. Üniversite öğrencilerinin yaşı 18'den küçük olamaz");
                return;
            }

            if (tBoxOgrSifre.TextLength < 8)
            {
                MessageBox.Show("Hesap şifreniz minimum 8 karakter uzunluğunda olmalıdır.");
                return;
            }
            else if (tBoxOgrSifre.TextLength > 32)
            {
                MessageBox.Show("Hesap şifreniz maksimum 32 karakter uzunluğunda olmalıdır.");
                return;
            }
            else if (tBoxOgrSifre.Text != tBoxOgrSifreTekrar.Text)
            {
                MessageBox.Show("Girdiğiniz şifreler birbiri ile uyuşmamaktadır. Lütfen kontrol ediniz.");
                return;
            }
            else if (tBoxOgrSifre.Text == tBoxOgrSifreTekrar.Text && tBoxOgrSifre.TextLength > 8 && tBoxOgrSifre.TextLength < 32)
            {
                ogrSifre = tBoxOgrSifre.Text;
            }
            else
            {
                return;
            }

            string[] mailParts = ogrMail.Split('@');
            if (mailParts.Length != 2 || string.IsNullOrEmpty(mailParts[0]) || string.IsNullOrEmpty(mailParts[1]))
            {
                MessageBox.Show("Geçersiz bir e-posta adresi girdiniz. Lütfen doğru bir e-posta adresi girin.");
                return;
            }
            string userPart = mailParts[0];
            if (userPart.Length < 4)
            {
                MessageBox.Show("E-posta adresinizin kullanıcı adı kısmı en az 4 karakter uzunluğunda olmalıdır.");
                return;
            }
            else if (userPart.Length > 32)
            {
                MessageBox.Show("E-posta adresinizin kullanıcı adı kısmı en fazla 32 karakter uzunluğunda olabilir.");
                return;
            }
            else
            {

            }

        string eklemeTarihi = DateTime.Now.ToString("ddMMyyyy");

            string query = "INSERT INTO ogrenciBilgileri (ogrNo, ogrAd, ogrSoyad, ogrTc, ogrAnne, ogrBaba, ogrDogum, ogrSifre, ogrMail) " +
                   "VALUES (@ogrNo, @ogrAd, @ogrSoyad, @ogrTc, @ogrAnne, @ogrBaba, @ogrDogum, @ogrSifre, @ogrMail)";

            int count = 0;

            using (SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM ogrenciBilgileri WHERE ogrNo LIKE @EklemeTarihi + '%'", Program.connection))
            {
                countCommand.Parameters.AddWithValue("@EklemeTarihi", eklemeTarihi);
                count = (int)countCommand.ExecuteScalar();
            }

            string ogrNo = eklemeTarihi + (count + 1).ToString("D4");



            using (SqlCommand command = new SqlCommand(query, Program.connection))
            {
                command.Parameters.AddWithValue("@ogrNo", ogrNo);
                command.Parameters.AddWithValue("@ogrAd", ogrAd);
                command.Parameters.AddWithValue("@ogrSoyad", ogrSoyad);
                command.Parameters.AddWithValue("@ogrTc", ogrTc);
                command.Parameters.AddWithValue("@ogrAnne", ogrAnne);
                command.Parameters.AddWithValue("@ogrBaba", ogrBaba);
                command.Parameters.AddWithValue("@ogrDogum", ogrDogum);
                command.Parameters.AddWithValue("@ogrSifre", ogrSifre);
                command.Parameters.AddWithValue("@ogrMail", ogrMail);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        ogrKayitBasarili ogrKayitBasarili = new ogrKayitBasarili();
                        ogrKayitBasarili.Show();
                    }

                    else
                    {
                        {
                            ogrKayitBasarisiz ogrKayitBasarisiz = new ogrKayitBasarisiz();
                            ogrKayitBasarisiz.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ogrKayitBasarisiz ogrKayitBasarisiz = new ogrKayitBasarisiz();
                    ogrKayitBasarisiz.Show();
                    ogrKayitBasarisiz.HataMesaji = ex.Message;
                }
            }
        }

        private void tBoxOgrAd_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
