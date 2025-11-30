using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemSewaMobil
{
    public partial class infoMobilTersedia : Form
    {
        public infoMobilTersedia()
        {
            InitializeComponent();
            InisialisasiListMobilView();
        }
        private void InisialisasiListMobilView()
        {
            infoMobil.View = View.Details;
            infoMobil.FullRowSelect = true;
            infoMobil.GridLines = true;

            infoMobil.Columns.Add("No.", 30, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Merk Mobil", 120, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Kategori", 100, HorizontalAlignment.Left);
            infoMobil.Columns.Add("No Polisi", 100, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Tahun", 50, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Status sedia", 70, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Harga Sewa/hari", 145, HorizontalAlignment.Center);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menuInfo = new Form1();
            menuInfo.Show();
        }
    }
}
