using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemSewaMobil.Model.Entity;
using SistemSewaMobil.Controller;
using SistemSewaMobil.View;

namespace SistemSewaMobil
{
    public partial class FormMobil : Form
    {
        private List<Mobil> listMobil = new List<Mobil>();
        private MobilController controller;
        public FormMobil()
        {
            InitializeComponent();
            controller = new MobilController();
            InisialisasiListMobilView();
            LoadMobilData();
        }
        private void InisialisasiListMobilView()
        {
            infoMobil.View = System.Windows.Forms.View.Details; // FIX: Use fully qualified enum
            infoMobil.FullRowSelect = true;
            infoMobil.GridLines = true;

            infoMobil.Columns.Add("No.", 30, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Id Mobil", 100, HorizontalAlignment.Left);
            infoMobil.Columns.Add("No Polisi", 100, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Merk Mobil", 120, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Tahun", 50, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Status sedia", 70, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Harga Sewa/hari", 145, HorizontalAlignment.Center);
        }

        private void LoadMobilData()
        {
            infoMobil.Items.Clear();
            listMobil = controller.GetAllMobil();

            // This method should load data into the infoMobil ListView
            // Implementation depends on how data is stored/retrieved

            foreach (var mobil in listMobil)
            {
                var noUrut = infoMobil.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mobil.idMobil);
                item.SubItems.Add(mobil.noPolisi);
                item.SubItems.Add(mobil.merkMobil);
                item.SubItems.Add(mobil.tahunMobil.ToString());
                item.SubItems.Add(mobil.statusKetersediaan);
                item.SubItems.Add(mobil.hargaSewa.ToString("Rp.")); // Format as currency
                infoMobil.Items.Add(item);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMain menuInfo = new FormMain();
            menuInfo.Show();
        }

        private void infoMobilTersedia_Load(object sender, EventArgs e)
        {

        }



        private void OnCreateEventHandler(Mobil mobil)
        {
            listMobil.Add(mobil);
            int noUrut = infoMobil.Items.Count + 1;

            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(mobil.idMobil);
            item.SubItems.Add(mobil.noPolisi);
            item.SubItems.Add(mobil.merkMobil);
            item.SubItems.Add(mobil.tahunMobil);
            item.SubItems.Add(mobil.statusKetersediaan);
            item.SubItems.Add(mobil.hargaSewa.ToString("Rp."));
            infoMobil.Items.Add(item);
        }

        private void OnUpdateEventHandler(Mobil mobil)
        {
            int index = infoMobil.SelectedIndices[0];

            ListViewItem itemRow = infoMobil.Items[index];
            itemRow.SubItems[1].Text = mobil.idMobil;
            itemRow.SubItems[2].Text = mobil.noPolisi;
            itemRow.SubItems[3].Text = mobil.merkMobil;
            itemRow.SubItems[4].Text = mobil.tahunMobil;
            itemRow.SubItems[5].Text = mobil.statusKetersediaan;
            itemRow.SubItems[6].Text = mobil.hargaSewa.ToString("Rp.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEntryMobil formEntryMobil = new FormEntryMobil("Tambah Data Mobil", controller);
            formEntryMobil.OnCreate += OnCreateEventHandler;
            if (formEntryMobil.ShowDialog() == DialogResult.OK)
            {
                LoadMobilData();
            }
            /*
                using (FormEntryMobil formEntryMobil = new FormEntryMobil())
                {
                     if (formEntryMobil.ShowDialog() == DialogResult.OK)
                {
                    LoadMobilData();
                }
                     */
        }
        private void button3_Click(object sender, EventArgs e)
        {
            /*
            if (infoMobil.SelectedItems.Count > 0)
            {
                Mobil mobil = listMobil[infoMobil.SelectedIndices[0]];
                FormEntryMobil formEntryMobil = new FormEntryMobil("Edit Data Mobil", mobil, controller);
                formEntryMobil.OnUpdate += OnUpdateEventHandler;
                if (formEntryMobil.ShowDialog() == DialogResult.OK)
                {
                    LoadMobilData();
                }
                else
                {
                    MessageBox.Show("Silakan pilih data mobil yang akan diubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            */
            if (infoMobil.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Silakan pilih data mobil yang akan diubah.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // ambil index baris yang dipilih
            int index = infoMobil.SelectedIndices[0];

            // ambil data dari listMobil
            Mobil mobil = listMobil[index];

            // buka form edit
            FormEntryMobil formEntryMobil =
                new FormEntryMobil("Edit Data Mobil", mobil, controller);

            formEntryMobil.OnUpdate += OnUpdateEventHandler;

            if (formEntryMobil.ShowDialog() == DialogResult.OK)
            {
                LoadMobilData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (infoMobil.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data mobil ingin dihapus?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                );
                if (konfirmasi == DialogResult.Yes)
                {
                    Mobil mobil = listMobil[infoMobil.SelectedIndices[0]];
                    var result = controller.Delete(mobil);
                    if (result > 0) LoadMobilData();
                }
            }
            else
            {
                MessageBox.Show(
                    "Silakan pilih data mobil yang akan dihapus.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadMobilData();
                return;
            }
            infoMobil.Items.Clear();
            listMobil = controller.ReadByMerk(keyword);

            foreach (var mobil in listMobil)
            {
                var noUrut = infoMobil.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mobil.idMobil);
                item.SubItems.Add(mobil.noPolisi);
                item.SubItems.Add(mobil.merkMobil);
                item.SubItems.Add(mobil.tahunMobil.ToString());
                item.SubItems.Add(mobil.statusKetersediaan);
                item.SubItems.Add(mobil.hargaSewa.ToString("Rp.")); // Format as currency
                infoMobil.Items.Add(item);
            }
            if (listMobil.Count == 0)
            {
                MessageBox.Show("Data mobil dengan merk " + keyword + " tidak ditemukan.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMobilData();
            }
        }
    }
}
