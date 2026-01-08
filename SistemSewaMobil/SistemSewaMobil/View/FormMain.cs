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
    public partial class FormMain : Form
    {
        public FormMain()
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
        List<Mobil> listMobil = new List<Mobil>()
        {
            new Mobil(){ No=1, Merk="Toyota Avanza", Kategori="MPV", Plat="B 1234 ABC", Tahun=2020 },
            new Mobil(){ No=2, Merk="Honda Brio", Kategori="Hatchback", Plat="B 5678 DEF", Tahun=2019 },
            new Mobil(){ No=3, Merk="Suzuki Ertiga", Kategori="MPV", Plat="B 9999 XYZ", Tahun=2021 },
            new Mobil(){ No=4, Merk="Toyota Innova", Kategori="MPV", Plat="D 1111 CCC", Tahun=2018 },
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMobil.DataSource = listMobil;
            comboBoxMobil.DisplayMember = "Merk";
        }

        private void comboBoxMobil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mobil mobilDipilih = (Mobil)comboBoxMobil.SelectedItem;

            infoMobilTerpilih.Items.Clear(); // Hapus isi ListView sebelum diisi ulang

            ListViewItem item = new ListViewItem(mobilDipilih.No.ToString());
            item.SubItems.Add(mobilDipilih.Merk);
            item.SubItems.Add(mobilDipilih.Kategori);
            item.SubItems.Add(mobilDipilih.Plat);
            item.SubItems.Add(mobilDipilih.Tahun.ToString());

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
    }
}
