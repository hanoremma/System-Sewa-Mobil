using SistemSewaMobil.Controller;
using SistemSewaMobil.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemSewaMobil.View
{
    public partial class FormDetailSewa : Form
    {
        private List<DetailSewa> listDetailSewa = new List<DetailSewa>();
        private DetailSewaController controller;
        public FormDetailSewa()
        {
            InitializeComponent();
            controller = new DetailSewaController();
            InisialisasiListDetailSewalView();
            InisialisasiListPembayaranView();
            LoadDetailSewaData();
        }
        private void InisialisasiListDetailSewalView()
        {
            lvwDaftarDS.View = System.Windows.Forms.View.Details; // FIX: Use fully qualified enum
            lvwDaftarDS.FullRowSelect = true;
            lvwDaftarDS.GridLines = true;

            lvwDaftarDS.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Id Detail Sewa", 100, HorizontalAlignment.Left);
            lvwDaftarDS.Columns.Add("Nama", 100, HorizontalAlignment.Left);
            lvwDaftarDS.Columns.Add("Alamat", 100, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("No KTP", 120, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("No HP", 50, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Petugas", 70, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("No Polisi", 70, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Merk Mobil", 70, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Tanggal Pinjam", 70, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Tanggal Kembali", 70, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Status Penyewaan", 70, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Total Biaya", 70, HorizontalAlignment.Center);
        }
        private void InisialisasiListPembayaranView()
        {
            lvwDaftarDS.View = System.Windows.Forms.View.Details; // FIX: Use fully qualified enum
            lvwDaftarDS.FullRowSelect = true;
            lvwDaftarDS.GridLines = true;

            lvwDaftarDS.Columns.Add("ID Pembayaran", 100, HorizontalAlignment.Left);
            lvwDaftarDS.Columns.Add("Tanggal Pembayaran", 150, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Metode Pembayaran", 150, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Biaya Servis", 150, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Biaya Diskon", 150, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Total Pembayaran", 150, HorizontalAlignment.Center);
            lvwDaftarDS.Columns.Add("Status Pembayaran", 150, HorizontalAlignment.Center);
        }
        private void LoadDetailSewaData()
        {
            lvwDaftarDS.Items.Clear();
            listDetailSewa = controller.GetAllDetailSewa();

            // This method should load data into the infoMobil ListView
            // Implementation depends on how data is stored/retrieved

            foreach (var detailsewa in listDetailSewa)
            {
                var noUrut = lvwDaftarDS.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(detailsewa.idDetailSewa);
                item.SubItems.Add(detailsewa.namaPenyewa);
                item.SubItems.Add(detailsewa.alamatPenyewa);
                item.SubItems.Add(detailsewa.noKtpPenyewa);
                item.SubItems.Add(detailsewa.noHpPenyewa);
                item.SubItems.Add(detailsewa.namaPetugas);
                item.SubItems.Add(detailsewa.noPolisi);
                item.SubItems.Add(detailsewa.merkMobil);
                item.SubItems.Add(detailsewa.tglPinjam.ToString("dd-MM-yyyy"));
                item.SubItems.Add(detailsewa.tglKembali.ToString("dd-MM-yyyy"));
                item.SubItems.Add(detailsewa.statusPenyewaan);
                item.SubItems.Add(detailsewa.totalBiaya.ToString("Rp.")); // Format as currency
                lvwDaftarDS.Items.Add(item);
            }
        }
        private void OnCreateEventHandler(DetailSewa detailsewa)
        {
            listDetailSewa.Add(detailsewa);
            int noUrut = lvwDaftarDS.Items.Count + 1;

            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(detailsewa.idDetailSewa);
            item.SubItems.Add(detailsewa.namaPenyewa);
            item.SubItems.Add(detailsewa.alamatPenyewa);
            item.SubItems.Add(detailsewa.noKtpPenyewa);
            item.SubItems.Add(detailsewa.noHpPenyewa);
            item.SubItems.Add(detailsewa.namaPetugas);
            item.SubItems.Add(detailsewa.noPolisi);
            item.SubItems.Add(detailsewa.merkMobil);
            item.SubItems.Add(detailsewa.tglPinjam.ToString("dd-MM-yyyy"));
            item.SubItems.Add(detailsewa.tglKembali.ToString("dd-MM-yyyy"));
            item.SubItems.Add(detailsewa.statusPenyewaan);
            item.SubItems.Add(detailsewa.totalBiaya.ToString("Rp.")); // Format as currency
            lvwDaftarDS.Items.Add(item);
        }
        private void OnUpdateEventHandler(DetailSewa detailsewa)
        {
            int index = lvwDaftarDS.SelectedIndices[0];

            ListViewItem itemRow = lvwDaftarDS.Items[index];
            itemRow.SubItems[2].Text = detailsewa.namaPenyewa;
            itemRow.SubItems[3].Text = detailsewa.alamatPenyewa;
            itemRow.SubItems[4].Text = detailsewa.noKtpPenyewa;
            itemRow.SubItems[5].Text = detailsewa.noHpPenyewa;
            itemRow.SubItems[6].Text = detailsewa.namaPetugas;
            itemRow.SubItems[7].Text = detailsewa.noPolisi;
            itemRow.SubItems[8].Text = detailsewa.merkMobil;
            itemRow.SubItems[9].Text = detailsewa.tglPinjam.ToString("dd-MM-yyyy");
            itemRow.SubItems[10].Text = detailsewa.tglKembali.ToString("dd-MM-yyyy");
            itemRow.SubItems[11].Text = detailsewa.statusPenyewaan;
            itemRow.SubItems[12].Text = detailsewa.totalBiaya.ToString("Rp.");
        }

        private void btnTambahDS_Click(object sender, EventArgs e)
        {
            FormEntryDetailSewa formEntryDetailSewa = new FormEntryDetailSewa("Tambah Data Mobil", controller);
            formEntryDetailSewa.OnCreate += OnCreateEventHandler;
            if (formEntryDetailSewa.ShowDialog() == DialogResult.OK)
            {
                LoadDetailSewaData();
            }
        }

        private void btnUpdateDS_Click(object sender, EventArgs e)
        {
            if (lvwDaftarDS.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Silakan pilih data yang akan diubah.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // ambil index baris yang dipilih
            int index = lvwDaftarDS.SelectedIndices[0];

            // ambil data dari listMobil
            DetailSewa detailsewa = listDetailSewa[index];

            // buka form edit
            FormEntryDetailSewa formDetailSewa =
                new FormEntryDetailSewa("Edit Data detail sewa", detailsewa, controller);

            formDetailSewa.OnUpdate += OnUpdateEventHandler;

            if (formDetailSewa.ShowDialog() == DialogResult.OK)
            {
                LoadDetailSewaData();
            }
        }

        private void btnHapusDS_Click(object sender, EventArgs e)
        {
            if (lvwDaftarDS.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                );
                if (konfirmasi == DialogResult.Yes)
                {
                    DetailSewa detailsewa = listDetailSewa[lvwDaftarDS.SelectedIndices[0]];
                    var result = controller.Delete(detailsewa);
                    if (result > 0) LoadDetailSewaData();
                }
            }
            else
            {
                MessageBox.Show(
                    "Silakan pilih data detail sewa yang akan dihapus.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
        }

        private void btnCariDS_Click(object sender, EventArgs e)
        {
            string keyword = txtCariDS.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadDetailSewaData();
                return;
            }
            lvwDaftarDS.Items.Clear();
            listDetailSewa = controller.ReadByNamaPenyewaDetailSewa(keyword);

            foreach (var detailsewa in listDetailSewa)
            {
                var noUrut = lvwDaftarDS.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(detailsewa.idDetailSewa);
                item.SubItems.Add(detailsewa.namaPenyewa);
                item.SubItems.Add(detailsewa.alamatPenyewa);
                item.SubItems.Add(detailsewa.noKtpPenyewa);
                item.SubItems.Add(detailsewa.noHpPenyewa);
                item.SubItems.Add(detailsewa.namaPetugas);
                item.SubItems.Add(detailsewa.noPolisi);
                item.SubItems.Add(detailsewa.merkMobil);
                item.SubItems.Add(detailsewa.tglPinjam.ToString("dd-MM-yyyy"));
                item.SubItems.Add(detailsewa.tglKembali.ToString("dd-MM-yyyy"));
                item.SubItems.Add(detailsewa.statusPenyewaan);
                item.SubItems.Add(detailsewa.totalBiaya.ToString("Rp.")); // Format as currency
                lvwDaftarDS.Items.Add(item);
            }
            if (listDetailSewa.Count == 0)
            {
                MessageBox.Show("Data detail sewa dengan nama " + keyword + " tidak ditemukan.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDetailSewaData();
            }
        }

        private void btnSelesaiDS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
