using SistemSewaMobil.Controller;
using SistemSewaMobil.Model.Context;
using SistemSewaMobil.Model.Entity;
using SistemSewaMobil.Model.Repository;
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
    public partial class FormPembayaran : Form
    {
        private List<Pembayaran> listPembayaran = new List<Pembayaran>();
        private PembayaranController controller;
        private DetailSewaController detailSewaController;
        private bool isEdit = false;
        private int selectedIndex = -1;
        private decimal totalDasar = 0;
        public FormPembayaran()
        {
            InitializeComponent();

            controller = new PembayaranController();
            detailSewaController = new DetailSewaController();

            InisialisasiListPembayaranView();
            InitPenyewaCombo();
            InitMetodePembayaranCombo();
            InitStatusPembayaranCombo();

            LoadPembayaran();
            ClearFormPembayaran();

            txtIdPembayaran.Text = "(Otomatis)";
            txtIdPembayaran.Enabled = false;
            txtIDDSPB.Enabled = false;

            lvwPembayaran.SelectedIndexChanged += lvwPembayaran_SelectedIndexChanged;
        }
        private void InisialisasiListPembayaranView()
        {
            lvwPembayaran.View = System.Windows.Forms.View.Details; // FIX: Use fully qualified enum
            lvwPembayaran.FullRowSelect = true;
            lvwPembayaran.GridLines = true;
            lvwPembayaran.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("ID Sewa", 100, HorizontalAlignment.Left);
            lvwPembayaran.Columns.Add("Nama Penyewa", 150, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("ID Pembayaran", 100, HorizontalAlignment.Left);
            lvwPembayaran.Columns.Add("Tanggal Pembayaran", 150, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Metode Pembayaran", 150, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Biaya Servis", 150, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Diskon", 150, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Total Pembayaran", 150, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Status Pembayaran", 150, HorizontalAlignment.Center);
        }
        private void LoadPembayaran()
        {
            lvwPembayaran.Items.Clear();
            listPembayaran = controller.GetAllPembayaran();

            foreach (var p in listPembayaran)
            {
                var no = lvwPembayaran.Items.Count + 1;
                ListViewItem item = new ListViewItem(no.ToString());

                item.SubItems.Add(p.idDetailSewa);
                item.SubItems.Add(p.namaPenyewa);
                item.SubItems.Add(p.idPembayaran);
                item.SubItems.Add(p.tglPembayaran.ToString("dd-MM-yyyy"));
                item.SubItems.Add(p.metodePembayaran);
                item.SubItems.Add(p.biayaServis.ToString("Rp #,##0"));
                item.SubItems.Add(p.diskon.ToString("Rp #,##0"));
                item.SubItems.Add(p.totalPembayaran.ToString("Rp #,##0"));
                item.SubItems.Add(p.statusPembayaran);

                lvwPembayaran.Items.Add(item);
            }
        }
        private void InitPenyewaCombo()
        {
            DetailSewaRepository repoPenyewa = new DetailSewaRepository(new DbContext());
            List<DetailSewa> daftarPenyewa = repoPenyewa.ReadAll();
            cmbNamaPenyewaPB.DataSource = daftarPenyewa;
            cmbNamaPenyewaPB.DisplayMember = "namaPenyewa";
            cmbNamaPenyewaPB.ValueMember = "idDetailSewa";
            cmbNamaPenyewaPB.SelectedIndex = -1;
        }

        private void cmbNamaPenyewaPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamaPenyewaPB.SelectedItem is DetailSewa ds)
            {
                txtIDDSPB.Text = ds.idDetailSewa;
                txtTotal.Text = ds.totalBiaya.ToString("Rp #,##0");
                totalDasar = ds.totalBiaya;


                HitungTotal();
            }
        }
        private void InitMetodePembayaranCombo()
        {
            cmbMetode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetode.Items.Clear();
            cmbMetode.Items.Add("Cash");
            cmbMetode.Items.Add("Transfer");
            cmbMetode.Items.Add("E-Wallet");
            cmbMetode.SelectedIndex = 0;
        }
        private void InitStatusPembayaranCombo()
        {
            cmbStatusPembayaran.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusPembayaran.Items.Clear();
            cmbStatusPembayaran.Items.Add("Lunas");
            cmbStatusPembayaran.Items.Add("Belum Lunas");
            cmbStatusPembayaran.SelectedIndex = 0;
        }
        private decimal ParseDecimal(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            text = text.Replace("Rp", "")
                       .Replace(".", "")
                       .Replace(",", "")
                       .Trim();

            decimal.TryParse(text, out decimal result);
            return result;
        }

        private void HitungTotal()
        {
            decimal biayaServis = ParseDecimal(txtBiayaServis.Text);
            decimal diskon = ParseDecimal(txtBiayaDiskon.Text);

            decimal total = totalDasar + biayaServis - diskon;

            if (total < 0)
                total = 0;

            txtTotal.Text = total.ToString("Rp #,##0");
        }

        private void txtBiayaServis_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void txtBiayaDiskon_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void btnTambahPembayaran_Click(object sender, EventArgs e)
        {
            if (!(cmbNamaPenyewaPB.SelectedItem is DetailSewa ds))
            {
                MessageBox.Show("Nama penyewa belum dipilih");
                return;
            }

            if (isEdit)
            {
                if (string.IsNullOrWhiteSpace(txtIdPembayaran.Text) ||
                    txtIdPembayaran.Text == "(Otomatis)")
                {
                    MessageBox.Show("ID pembayaran tidak valid");
                    return;
                }

                Pembayaran pembayaran = new Pembayaran
                {
                    idPembayaran = txtIdPembayaran.Text,
                    idDetailSewa = txtIDDSPB.Text,
                    tglPembayaran = dtPembayaran.Value,
                    metodePembayaran = cmbMetode.Text,
                    biayaServis = (int)ParseDecimal(txtBiayaServis.Text),
                    diskon = (int)ParseDecimal(txtBiayaDiskon.Text),
                    totalPembayaran = (int)ParseDecimal(txtTotal.Text),
                    statusPembayaran = cmbStatusPembayaran.Text
                };

                int result = controller.Update(pembayaran);
                if (result > 0)
                {
                    MessageBox.Show("Pembayaran berhasil diupdate");
                    LoadPembayaran();
                    ClearFormPembayaran();
                }

                return; // ⬅️ PENTING: stop di sini
            }

            // 🔹 MODE TAMBAH
            Pembayaran pembayaranBaru = new Pembayaran
            {
                idDetailSewa = ds.idDetailSewa,
                namaPenyewa = ds.namaPenyewa,
                tglPembayaran = dtPembayaran.Value,
                metodePembayaran = cmbMetode.Text,
                biayaServis = (int)ParseDecimal(txtBiayaServis.Text),
                diskon = (int)ParseDecimal(txtBiayaDiskon.Text),
                totalPembayaran = (int)ParseDecimal(txtTotal.Text),
                statusPembayaran = cmbStatusPembayaran.Text
            };

            int insert = controller.Create(pembayaranBaru);
            if (insert > 0)
            {
                controller.UpdateStatusDetailSewa(pembayaranBaru.idDetailSewa, "Selesai");

                MessageBox.Show("Pembayaran berhasil disimpan");
                LoadPembayaran();
                ClearFormPembayaran();
            }
        }

        private void lvwPembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPembayaran.SelectedItems.Count == 0)
                return;

            selectedIndex = lvwPembayaran.SelectedIndices[0];
            Pembayaran p = listPembayaran[selectedIndex];

            txtIdPembayaran.Text = p.idPembayaran;
            txtIDDSPB.Text = p.idDetailSewa;

            cmbNamaPenyewaPB.Text = p.namaPenyewa;
            dtPembayaran.Value = p.tglPembayaran;
            cmbMetode.Text = p.metodePembayaran;
            txtBiayaServis.Text = p.biayaServis.ToString();
            txtBiayaDiskon.Text = p.diskon.ToString();
            txtTotal.Text = p.totalPembayaran.ToString("Rp #,##0");
            cmbStatusPembayaran.Text = p.statusPembayaran;

            txtIdPembayaran.Enabled = false;
            txtIDDSPB.Enabled = false;
            cmbNamaPenyewaPB.Enabled = false;

            totalDasar = p.totalPembayaran + p.diskon - p.biayaServis;

            isEdit = true;
            btnTambahPembayaran.Text = "Update";
        }
        private void ClearFormPembayaran()
        {
            txtIdPembayaran.Text = "(Otomatis)";
            txtIDDSPB.Clear();
            totalDasar = 0;

            cmbNamaPenyewaPB.SelectedIndex = -1;
            cmbMetode.SelectedIndex = 0;
            cmbStatusPembayaran.SelectedIndex = 0;

            txtBiayaServis.Clear();
            txtBiayaDiskon.Clear();
            txtTotal.Text = "Rp 0";

            dtPembayaran.Value = DateTime.Now;

            lvwPembayaran.SelectedItems.Clear();

            isEdit = false;
            btnTambahPembayaran.Text = "Simpan";
            selectedIndex = -1;
            totalDasar = 0;

            cmbNamaPenyewaPB.Enabled = true;
        }

        private void btnCariPenyewa_Click(object sender, EventArgs e)
        {
            string keyword = txtCariPenyewaDS.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadPembayaran();
                return;
            }
            lvwPembayaran.Items.Clear();
            listPembayaran = controller.ReadByNamaPenyewaPembayaran(keyword);

            foreach (var pembayaran in listPembayaran)
            {
                var noUrut = lvwPembayaran.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());

                item.SubItems.Add(pembayaran.idDetailSewa);
                item.SubItems.Add(pembayaran.namaPenyewa);
                item.SubItems.Add(pembayaran.idPembayaran);
                item.SubItems.Add(pembayaran.tglPembayaran.ToString("dd-MM-yyyy"));
                item.SubItems.Add(pembayaran.metodePembayaran);
                item.SubItems.Add(pembayaran.biayaServis.ToString("Rp #,##0"));
                item.SubItems.Add(pembayaran.diskon.ToString("Rp #,##0"));
                item.SubItems.Add(pembayaran.totalPembayaran.ToString("Rp #,##0"));
                item.SubItems.Add(pembayaran.statusPembayaran);

                lvwPembayaran.Items.Add(item);
            }
            if (listPembayaran.Count == 0)
            {
                MessageBox.Show("Data detail sewa dengan nama " + keyword + " tidak ditemukan.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPembayaran();
            }
        }

        private void btnHapusPembayaran_Click(object sender, EventArgs e)
        {
            if (lvwPembayaran.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                );
                if (konfirmasi == DialogResult.Yes)
                {
                    Pembayaran pembayaran = listPembayaran[lvwPembayaran.SelectedIndices[0]];
                    var result = controller.Delete(pembayaran);
                    if (result > 0) LoadPembayaran();
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

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditDS_Click(object sender, EventArgs e)
        {
            FormDetailSewa menuInfo = new FormDetailSewa();
            menuInfo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            FormBeranda fp = new FormBeranda();
            fp.Show();
            this.Hide();
        }

        private void btnPenyewa_Click(object sender, EventArgs e)
        {
            FormEntryDetailSewa fp = new FormEntryDetailSewa();
            fp.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Yakin ingin keluar?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        bool sidebarExpand;
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            int step = 10;

            if (sidebarExpand)
            {
                sidebar.Width -= step;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += step;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
    }

}
