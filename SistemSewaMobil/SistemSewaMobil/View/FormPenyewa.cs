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
    public partial class FormPenyewa : Form
    {
        public FormPenyewa()
        {
            InitializeComponent();
            InisialisasiListPenyewaView();
        }
        private void InisialisasiListPenyewaView()
        {
            infoPenyewa.View = System.Windows.Forms.View.Details;
            infoPenyewa.FullRowSelect = true;
            infoPenyewa.GridLines = true;

            infoPenyewa.Columns.Add("No.", 30, HorizontalAlignment.Center);
            infoPenyewa.Columns.Add("Nama", 120, HorizontalAlignment.Center);
            infoPenyewa.Columns.Add("Alamat", 100, HorizontalAlignment.Center);
            infoPenyewa.Columns.Add("No HP", 100, HorizontalAlignment.Center);
            infoPenyewa.Columns.Add("KTP", 100, HorizontalAlignment.Center);
            infoPenyewa.Columns.Add("Sewa Mobil", 100, HorizontalAlignment.Center);
            infoPenyewa.Columns.Add("Tanggal Sewa", 100, HorizontalAlignment.Center);
            infoPenyewa.Columns.Add("Tanggal Kembali", 100, HorizontalAlignment.Center);
            infoPenyewa.Columns.Add("Total", 100, HorizontalAlignment.Center);
            infoPenyewa.Columns.Add("Status Pembayaran", 115, HorizontalAlignment.Center);
        }

        private void dataMobilTersediaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormMobil menuInfo = new FormMobil();
            menuInfo.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMain menuInfo = new FormMain();
            menuInfo.Show();
        }

        private void infoPenyewa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
