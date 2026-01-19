using SistemSewaMobil.Controller;
using SistemSewaMobil.Model.Entity;
using SistemSewaMobil.View;
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
        private List<Penyewa> listPenyewa = new List<Penyewa>();
        private PenyewaController controller;
        public FormPenyewa()
        {
            InitializeComponent();
            controller = new PenyewaController();
            InisialisasiListPenyewaView();
            LoadPenyewaData();
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

        private void LoadPenyewaData()
        {
            lvwDaftarPenyewa.Items.Clear();
            listPenyewa = controller.GetAllPenyewa();

            // This method should load data into the infoMobil ListView
            // Implementation depends on how data is stored/retrieved

            foreach (var penyewa in listPenyewa)
            {
                var noUrut = lvwDaftarPenyewa.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(penyewa.idPenyewa);
                item.SubItems.Add(penyewa.namaPenyewa);
                item.SubItems.Add(penyewa.alamatPenyewa);
                item.SubItems.Add(penyewa.noKtpPenyewa);
                item.SubItems.Add(penyewa.noHpPenyewa);
                lvwDaftarPenyewa.Items.Add(item);
            }
        }
        private void OnCreateEventHandler(Penyewa penyewa)
        {
            listPenyewa.Add(penyewa);
            int noUrut = lvwDaftarPenyewa.Items.Count + 1;

            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(penyewa.idPenyewa);
            item.SubItems.Add(penyewa.namaPenyewa);
            item.SubItems.Add(penyewa.alamatPenyewa);
            item.SubItems.Add(penyewa.noKtpPenyewa);
            item.SubItems.Add(penyewa.noHpPenyewa);
            lvwDaftarPenyewa.Items.Add(item);
        }

        private void OnUpdateEventHandler(Penyewa penyewa)
        {
            int index = lvwDaftarPenyewa.SelectedIndices[0];

            ListViewItem itemRow = lvwDaftarPenyewa.Items[index];
            itemRow.SubItems[1].Text = penyewa.idPenyewa;
            itemRow.SubItems[2].Text = penyewa.namaPenyewa;
            itemRow.SubItems[2].Text = penyewa.alamatPenyewa;
            itemRow.SubItems[3].Text = penyewa.noKtpPenyewa;
            itemRow.SubItems[4].Text = penyewa.noHpPenyewa;
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

        private void btnTambahPenyewa_Click(object sender, EventArgs e)
        {
            FormEntryPenyewa formEntryPenyewa = new FormEntryPenyewa("Tambah Data Penyewa", controller);
            formEntryPenyewa.OnCreate += OnCreateEventHandler;
            if (formEntryPenyewa.ShowDialog() == DialogResult.OK)
            {
                LoadPenyewaData();
            }
        }

        private void btnUpdatePenyewa_Click(object sender, EventArgs e)
        {
            if (lvwDaftarPenyewa.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Silakan pilih data penyewa yang akan diubah.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int index = lvwDaftarPenyewa.SelectedIndices[0];
            Penyewa penyewa = listPenyewa[index];
            FormEntryPenyewa formEntryPenyewa =
                new FormEntryPenyewa("Edit Data Penyewa", penyewa, controller);

            formEntryPenyewa.OnUpdate += OnUpdateEventHandler;

            if (formEntryPenyewa.ShowDialog() == DialogResult.OK)
            {
                LoadPenyewaData();
            }
        }

        private void btnHapusPenyewa_Click(object sender, EventArgs e)
        {
            if (lvwDaftarPenyewa.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data penyewa ingin dihapus?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                );
                if (konfirmasi == DialogResult.Yes)
                {
                    Penyewa penyewa = listPenyewa[lvwDaftarPenyewa.SelectedIndices[0]];
                    var result = controller.Delete(penyewa);
                    if (result > 0) LoadPenyewaData();
                }
            }
            else
            {
                MessageBox.Show(
                    "Silakan pilih data penyewa yang akan dihapus.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
        }

        private void btnCariPenyewa_Click(object sender, EventArgs e)
        {
            string keyword = txtCariPenyewa.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadPenyewaData();
                return;
            }
            lvwDaftarPenyewa.Items.Clear();
            listPenyewa = controller.ReadByNamaPenyewa(keyword);

            foreach (var penyewa in listPenyewa)
            {
                var noUrut = lvwDaftarPenyewa.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(penyewa.idPenyewa);
                item.SubItems.Add(penyewa.namaPenyewa);
                item.SubItems.Add(penyewa.alamatPenyewa);
                item.SubItems.Add(penyewa.noKtpPenyewa);
                item.SubItems.Add(penyewa.noHpPenyewa);
                lvwDaftarPenyewa.Items.Add(item);
            }
            if (listPenyewa.Count == 0)
            {
                MessageBox.Show("Data penyewa dengan nama " + keyword + " tidak ditemukan.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPenyewaData();
            }
        }

        private void btnSelesaiPenyewa_Click(object sender, EventArgs e)
        {
            FormStatistik fp = new FormStatistik();
            fp.Show();
            this.Hide();
        }
    }
}
