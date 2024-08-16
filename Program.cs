using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ogrenciGirisSistemi
{
    internal static class Program
    {
        public static SqlConnection connection;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // App.config dosyasındaki bağlantı dizesini al
            string connectionString = ConfigurationManager.ConnectionStrings["OkulGirisSistemiConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ogrenciGirisEkrani());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
        }
    }
}