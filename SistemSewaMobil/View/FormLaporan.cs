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
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
            InisialisasiListLaporanView();
            LoadLaporan();
            txtTotal.ReadOnly = true;
            txtTotal.Enabled = false;
        }
        private void InisialisasiListLaporanView()
        {
            lvwLaporan.View = System.Windows.Forms.View.Details; // FIX: Use fully qualified enum
            lvwLaporan.FullRowSelect = true;
            lvwLaporan.GridLines = true;
            lvwLaporan.Columns.Clear();

            lvwLaporan.Columns.Add("No", 40, HorizontalAlignment.Center);
            lvwLaporan.Columns.Add("ID Detail Sewa", 120);
            lvwLaporan.Columns.Add("Tgl Pinjam", 100);
            lvwLaporan.Columns.Add("Tgl Kembali", 100);
            lvwLaporan.Columns.Add("Status Sewa", 120);
            lvwLaporan.Columns.Add("Total Biaya Sewa", 130, HorizontalAlignment.Right);
            lvwLaporan.Columns.Add("Nama Penyewa", 150);
            lvwLaporan.Columns.Add("Alamat", 180);
            lvwLaporan.Columns.Add("No KTP", 130);
            lvwLaporan.Columns.Add("No HP", 110);
            lvwLaporan.Columns.Add("Petugas", 120);
            lvwLaporan.Columns.Add("No Polisi", 110);
            lvwLaporan.Columns.Add("Merk Mobil", 120);
            lvwLaporan.Columns.Add("ID Pembayaran", 120);
            lvwLaporan.Columns.Add("Tgl Pembayaran", 120);
            lvwLaporan.Columns.Add("Metode", 100);
            lvwLaporan.Columns.Add("Biaya Servis", 120, HorizontalAlignment.Right);
            lvwLaporan.Columns.Add("Diskon", 100, HorizontalAlignment.Right);
            lvwLaporan.Columns.Add("Total Bayar", 130, HorizontalAlignment.Right);
            lvwLaporan.Columns.Add("Status Bayar", 100);
        }
        private void LoadLaporan()
        {
            lvwLaporan.Items.Clear();

            LaporanController controller = new LaporanController();
            List<Laporan> list = controller.GetLaporanLunas();

            // ambil total keseluruhan
            int totalPendapatan = controller.GetTotalPendapatanLunas();

            int no = 1;
            foreach (var l in list)
            {
                ListViewItem item = new ListViewItem(no.ToString());

                // Detail Sewa
                item.SubItems.Add(l.idDetailSewa);
                item.SubItems.Add(l.tglPinjam.ToString("dd-MM-yyyy"));
                item.SubItems.Add(l.tglKembali.ToString("dd-MM-yyyy"));
                item.SubItems.Add(l.statusPenyewaan);
                item.SubItems.Add(l.totalBiayaSewa.ToString("Rp #,##0"));

                // Penyewa
                item.SubItems.Add(l.namaPenyewa);
                item.SubItems.Add(l.alamatPenyewa);
                item.SubItems.Add(l.noKtpPenyewa);
                item.SubItems.Add(l.noHpPenyewa);

                // Petugas
                item.SubItems.Add(l.namaPetugas);

                // Mobil
                item.SubItems.Add(l.noPolisi);
                item.SubItems.Add(l.merkMobil);

                // Pembayaran
                item.SubItems.Add(l.idPembayaran);
                item.SubItems.Add(l.tglPembayaran?.ToString("dd-MM-yyyy") ?? "-");
                item.SubItems.Add(l.metodePembayaran);
                item.SubItems.Add(l.biayaServis.ToString("Rp #,##0"));
                item.SubItems.Add(l.diskon.ToString("Rp #,##0"));
                item.SubItems.Add(l.totalPembayaran.ToString("Rp #,##0"));
                item.SubItems.Add(l.statusBayar);

                lvwLaporan.Items.Add(item);
                no++;
                txtTotal.Text = totalPendapatan.ToString("Rp #,##0");
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
