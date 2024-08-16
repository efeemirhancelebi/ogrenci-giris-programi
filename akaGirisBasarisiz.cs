using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciGirisSistemi
{
    public partial class akaGirisBasarisiz : Form
    {
        public akaGirisBasarisiz()
        {
            InitializeComponent();
        }

        private void btnAkaDonus_Click(object sender, EventArgs e)
        {
            this.Close();
            akademisyenGirisEkrani akademisyenGirisEkrani = new akademisyenGirisEkrani();
            akademisyenGirisEkrani.Show();
        }
    }
}
