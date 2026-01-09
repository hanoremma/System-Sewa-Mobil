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
            lvwDaftarPenyewa.View = System.Windows.Forms.View.Details;
            lvwDaftarPenyewa.FullRowSelect = true;
            lvwDaftarPenyewa.GridLines = true;

            lvwDaftarPenyewa.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwDaftarPenyewa.Columns.Add("ID Penyewa", 120, HorizontalAlignment.Center);
            lvwDaftarPenyewa.Columns.Add("Nama Penyewa", 160, HorizontalAlignment.Center);
            lvwDaftarPenyewa.Columns.Add("Alamat Penyewa", 200, HorizontalAlignment.Center);
            lvwDaftarPenyewa.Columns.Add("KTP", 150, HorizontalAlignment.Center);
            lvwDaftarPenyewa.Columns.Add("No HP", 150, HorizontalAlignment.Center);
        }

        private void dataMobilTersediaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormMobil menuInfo = new FormMobil();
            menuInfo.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetailSewa menuInfo = new FormDetailSewa();
            menuInfo.Show();
        }

        private void infoPenyewa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormPenyewa_Load(object sender, EventArgs e)
        {

        }
    }
}
