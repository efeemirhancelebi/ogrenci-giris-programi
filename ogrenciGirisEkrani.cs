using System.Data.SqlClient;

namespace ogrenciGirisSistemi
{
    public partial class ogrenciGirisEkrani : Form
    {
        public ogrenciGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnOgrKayit_Click(object sender, EventArgs e)
        {
            ogrenciKayitEkrani ogrenciKayitEkrani = new ogrenciKayitEkrani();
            ogrenciKayitEkrani.Show();
            this.Hide();
        }

        private void btnAkaFormGidis_Click(object sender, EventArgs e)
        {
            akademisyenGirisEkrani akademisyenGirisEkrani = new akademisyenGirisEkrani();
            akademisyenGirisEkrani.Show();
            this.Hide();
        }

        private void btnOgrGiris_Click(object sender, EventArgs e)
        {
            string ogrNo = tBoxOgrNo.Text;
            string ogrSifre = tBoxOgrSifre.Text;

            string query = "SELECT COUNT(*) FROM ogrenciBilgileri WHERE ogrNo = @ogrNoSorgulama AND ogrSifre = @ogrSifreSorgulama";

            using (SqlCommand command = new SqlCommand(query, Program.connection))
            {
                command.Parameters.AddWithValue("@ogrNoSorgulama", ogrNo);
                command.Parameters.AddWithValue("@ogrSifreSorgulama", ogrSifre);

                bool connectionInitiallyClosed = Program.connection.State == System.Data.ConnectionState.Closed;

                if (connectionInitiallyClosed)
                {
                    Program.connection.Open();
                }

                int count = (int)command.ExecuteScalar();

                if (connectionInitiallyClosed)
                {
                    Program.connection.Close();
                }

                if (count > 0)
                {
                    ogrGirisBasarili ogrGirisBasarili = new ogrGirisBasarili();
                    ogrGirisBasarili.Show();
                }
                else
                {
                    this.Close();
                    ogrGirisBasarisiz ogrGirisBasarisiz = new ogrGirisBasarisiz();
                    ogrGirisBasarisiz.Show();
                }
            }
        }
    }
}