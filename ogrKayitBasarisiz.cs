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
    public partial class ogrKayitBasarisiz : Form
    {
        public string HataMesaji { get; set; }

        public ogrKayitBasarisiz()
        {
            InitializeComponent();
        }

        private void btnHataKodu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HataMesaji);
        }
    }
}
