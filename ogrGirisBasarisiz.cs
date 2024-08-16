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
    public partial class ogrGirisBasarisiz : Form
    {
        public ogrGirisBasarisiz()
        {
            InitializeComponent();
        }

        private void btnOgrDonus_Click(object sender, EventArgs e)
        {
            this.Close();
            ogrenciGirisEkrani ogrenciGirisEkrani = new ogrenciGirisEkrani();
            ogrenciGirisEkrani.Show();
        }
    }
}
