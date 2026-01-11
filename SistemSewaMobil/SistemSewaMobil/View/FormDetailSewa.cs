using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemSewaMobil.Model;
using SistemSewaMobil.Model.Entity;
using SistemSewaMobil.View;

namespace SistemSewaMobil
{
    public partial class FormDetailSewa : Form
    {
        public FormDetailSewa()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            infoMobilTerpilih.View = System.Windows.Forms.View.Details;
            infoMobilTerpilih.FullRowSelect = true;
            infoMobilTerpilih.GridLines = true;

            infoMobilTerpilih.Columns.Add("No.", 30, HorizontalAlignment.Center);
            infoMobilTerpilih.Columns.Add("Merk Mobil", 120, HorizontalAlignment.Center);
            infoMobilTerpilih.Columns.Add("Kategori", 100, HorizontalAlignment.Left);
            infoMobilTerpilih.Columns.Add("No Polisi", 100, HorizontalAlignment.Center);
            infoMobilTerpilih.Columns.Add("Tahun", 50, HorizontalAlignment.Center);
            infoMobilTerpilih.Columns.Add("Status sedia", 70, HorizontalAlignment.Center);
            infoMobilTerpilih.Columns.Add("Harga Sewa/hari", 100, HorizontalAlignment.Center);
        }

        private void comboBoxMobil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mobil mobilDipilih = (Mobil)cmbMobilYangDisewaDetailSewa.SelectedItem;

            infoMobilTerpilih.Items.Clear(); // Hapus isi ListView sebelum diisi ulang

            ListViewItem item = new ListViewItem(mobilDipilih.idMobil);
            item.SubItems.Add(mobilDipilih.noPolisi);
            item.SubItems.Add(mobilDipilih.merkMobil);
            item.SubItems.Add(mobilDipilih.tahunMobil);
            item.SubItems.Add(mobilDipilih.statusKetersediaan);
            item.SubItems.Add(mobilDipilih.hargaSewa.ToString());

            infoMobilTerpilih.Items.Add(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPenyewa menuInfo = new FormPenyewa();
            menuInfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMobil menuInfo = new FormMobil();
            menuInfo.Show();
        }

        private void dataMobilTersediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMobil menuInfo = new FormMobil();
            menuInfo.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
