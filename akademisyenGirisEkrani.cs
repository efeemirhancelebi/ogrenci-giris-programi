using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciGirisSistemi
{
    public partial class akademisyenGirisEkrani : Form
    {
        public akademisyenGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnAkaGiris_Click(object sender, EventArgs e)
        {
            string akaTc = tBoxAkaSifre.Text;
            string akaSifre = tBoxAkaSifre.Text;
            string akaMail = tBoxAkaMail.Text;

            string query = "SELECT COUNT(*) FROM akademisyenBilgileri WHERE akaTc = @akaTcSorgulama AND akaSifre = @akaSifreSorgulama AND akaMail = @akaMailSorgulama";

            using (SqlCommand command = new SqlCommand(query, Program.connection))
            {
                command.Parameters.AddWithValue("@akaTcSorgulama", akaTc);
                command.Parameters.AddWithValue("@akaSifreSorgulama", akaSifre);
                command.Parameters.AddWithValue("@akaMailSorgulama", akaMail);

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
                    akaGirisBasarili akaGirisBasarili = new akaGirisBasarili();
                    akaGirisBasarili.Show();
                }
                else
                {
                    akaGirisBasarisiz akaGirisBasarisiz = new akaGirisBasarisiz();
                    akaGirisBasarisiz.Show();
                    this.Close();
                }
            }
        }
    }
}