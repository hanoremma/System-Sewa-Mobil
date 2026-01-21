using SistemSewaMobil.Controller;
using SistemSewaMobil.Model;
using SistemSewaMobil.Model.Context;
using SistemSewaMobil.Model.Entity;
using SistemSewaMobil.Model.Repository;
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
    public delegate void CreateUpdateDetailSewaEventHandler(DetailSewa detailsewa);
    public partial class FormEntryDetailSewa : Form
    {
        public FormEntryDetailSewa()
        {
            InitializeComponent();
            controller = new DetailSewaController();
            isNewData = true;


            InitPetugasCombo();
            InitMobilCombo();

            txtIdPenyewaDetailSewa.Text = "(Otomatis)";
            txtIdPenyewaDetailSewa.Enabled = false;
            txtTotalDetailSewa.ReadOnly = true;
            txtTotalDetailSewa.Enabled = false;
        }
        private void InitPetugasCombo()
        {
            PetugasRepository repoPetugas = new PetugasRepository(new DbContext());
            List<Petugas> daftarPetugas = repoPetugas.ReadAll();
            cmbPetugasDetailSewa.DataSource = daftarPetugas;
            cmbPetugasDetailSewa.DisplayMember = "namaPetugas";
            cmbPetugasDetailSewa.ValueMember = "idPetugas";
            cmbPetugasDetailSewa.SelectedIndex = -1;
        }
        private void InitMobilCombo()
        {
            MobilRepository repoMobil = new MobilRepository(new DbContext());

            List<Mobil> daftarMobil = repoMobil.ReadMobilTersedia();

            cmbMobilYangDisewaDetailSewa.DataSource = daftarMobil;
            cmbMobilYangDisewaDetailSewa.DisplayMember = "merkMobil";
            cmbMobilYangDisewaDetailSewa.ValueMember = "idMobil";
            cmbMobilYangDisewaDetailSewa.SelectedIndex = -1;
        }
        private void HitungTotalBiayaPreview()
        {
            if (cmbMobilYangDisewaDetailSewa.SelectedItem == null)
                return;

            Mobil mobil = (Mobil)cmbMobilYangDisewaDetailSewa.SelectedItem;

            DateTime pinjam = dtPinjam.Value.Date;
            DateTime kembali = dtKembali.Value.Date;


            if (kembali <= pinjam)
            {
                txtTotalDetailSewa.Text = "0";
                return;
            }

            int hari = (kembali - pinjam).Days;

            // minimal 1 hari sewa
            if (hari < 1)
                hari = 1;

            int total = hari * mobil.hargaSewa;

            txtTotalDetailSewa.Text = total.ToString("N0");
        }
        public event CreateUpdateDetailSewaEventHandler OnCreate;

        public event CreateUpdateDetailSewaEventHandler OnUpdate;

        private DetailSewaController controller;

        private bool isNewData = true;

        private DetailSewa detailsewa;
        private string _idPenyewa;

        private PenyewaController penyewaController = new PenyewaController();

        public FormEntryDetailSewa(string title, DetailSewaController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = true;
        }
        public FormEntryDetailSewa(string title, DetailSewa obj, DetailSewaController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            detailsewa = obj;

            txtIdPenyewaDetailSewa.Text = obj.idDetailSewa;
            txtIdPenyewaDetailSewa.Enabled = false;
            txtNamaPenyewaDetailSewa.Text = obj.namaPenyewa;
            txtAlamatDetailSewa.Text = obj.alamatPenyewa;
            ktpNoKtpDetailSewa.Text = obj.noKtpPenyewa;
            txtNoHpDetailSewa.Text = obj.noHpPenyewa;
            cmbPetugasDetailSewa.SelectedValue = obj.idPetugas;
            cmbMobilYangDisewaDetailSewa.SelectedValue = obj.idMobil;
            dtPinjam.Value = obj.tglPinjam;
            dtKembali.Value = obj.tglKembali;
            txtTotalDetailSewa.Text = obj.totalBiaya.ToString();
            txtTotalDetailSewa.ReadOnly = true;

            GetStatusPenyewaan();

            btnSimpanDetailSewa.Text = "Update";
        }
        private void btnSimpanDetailSewa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdPenyewaDetailSewa.Text))
                {
                    MessageBox.Show("ID Penyewa belum diisi");
                    return;
                }

                if (cmbPetugasDetailSewa.SelectedIndex < 0)
                {
                    MessageBox.Show("Petugas belum dipilih");
                    return;
                }

                if (cmbMobilYangDisewaDetailSewa.SelectedIndex < 0)
                {
                    MessageBox.Show("Mobil belum dipilih");
                    return;
                }

                string status = GetStatusPenyewaan();
                if (string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Status penyewaan belum dipilih");
                    return;
                }
                bool tersedia = controller.CekKetersediaanMobil(cmbMobilYangDisewaDetailSewa.SelectedValue.ToString(), dtPinjam.Value, dtKembali.Value, isNewData ? null : txtIdPenyewaDetailSewa.Text);

                if (!tersedia)
                {
                    MessageBox.Show(
                        "Mobil ini sudah disewa pada rentang tanggal tersebut.\nSilakan pilih tanggal atau mobil lain.",
                        "Bentrok Jadwal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                string idPenyewa = textBoxIDPenyewa.Text;

                if (string.IsNullOrEmpty(idPenyewa))
                {
                    Penyewa p = new Penyewa
                    {
                        namaPenyewa = txtNamaPenyewaDetailSewa.Text,
                        alamatPenyewa = txtAlamatDetailSewa.Text,
                        noKtpPenyewa = ktpNoKtpDetailSewa.Text,
                        noHpPenyewa = txtNoHpDetailSewa.Text,
                    };

                    idPenyewa = penyewaController.CreateAndGetId(p);

                    textBoxIDPenyewa.Text = idPenyewa;
                }

                DetailSewa detailsewa = new DetailSewa
                {
                    // ID (WAJIB UNTUK DATABASE)
                    idDetailSewa = txtIdPenyewaDetailSewa.Text,
                    idPenyewa = idPenyewa,
                    idPetugas = cmbPetugasDetailSewa.SelectedValue.ToString(),
                    idMobil = cmbMobilYangDisewaDetailSewa.SelectedValue.ToString(),

                    // DATA TAMBAHAN (UNTUK TAMPILAN)
                    namaPenyewa = txtNamaPenyewaDetailSewa.Text,
                    alamatPenyewa = txtAlamatDetailSewa.Text,
                    noKtpPenyewa = ktpNoKtpDetailSewa.Text,
                    noHpPenyewa = txtNoHpDetailSewa.Text,

                    // TANGGAL
                    tglPinjam = dtPinjam.Value,
                    tglKembali = dtKembali.Value,

                    // STATUS
                    statusPenyewaan = status
                };

                int result;

                // ===== CREATE / UPDATE =====
                if (isNewData)
                {
                    result = controller.Create(detailsewa);
                }
                else
                {
                    result = controller.Update(detailsewa);
                }

                // ===== HASIL =====
                if (result > 0)
                {
                    MessageBox.Show(
                        isNewData ? "Detail sewa berhasil disimpan" : "Detail sewa berhasil diperbarui",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    LoadFormDetailSewa();
                }
                else
                {
                    MessageBox.Show("Data gagal diproses",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadFormDetailSewa()
        {
            // ID
            txtIdPenyewaDetailSewa.Text = "(Otomatis)";
            textBoxIDPenyewa.Clear();

            // Penyewa
            txtNamaPenyewaDetailSewa.Clear();
            txtAlamatDetailSewa.Clear();
            ktpNoKtpDetailSewa.Clear();
            txtNoHpDetailSewa.Clear();

            // ComboBox
            cmbPetugasDetailSewa.SelectedIndex = -1;
            cmbMobilYangDisewaDetailSewa.SelectedIndex = -1;

            // Tanggal
            dtPinjam.Value = DateTime.Now;
            dtKembali.Value = DateTime.Now;

            // RadioButton Status
            rbBerlangsung.Checked = false;
            rbSelesai.Checked = false;
            rbDibatalkan.Checked = false;

            // Total
            txtTotalDetailSewa.Clear();

            // MODE BALIK KE INSERT
            isNewData = true;
        }

        private string GetStatusPenyewaan()
        {
            if (rbBerlangsung.Checked)
                return "Sedang Berlangsung";
            if (rbSelesai.Checked)
                return "Selesai";
            if (rbDibatalkan.Checked)
                return "Dibatalkan";

            return "";
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void lbljam_Click(object sender, EventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = panel1; // atau Form

        }

        private void jam_Tick(object sender, EventArgs e)
        {
            lbljam.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormBeranda fp = new FormBeranda();
            fp.Show();
            this.Hide();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            FormEntryDetailSewa fp = new FormEntryDetailSewa();
            fp.Show();
            this.Hide();
        }

        private void btnDetailSewa_Click(object sender, EventArgs e)
        {
            FormDetailSewa menuInfo = new FormDetailSewa();
            menuInfo.Show();
        }

        private void txtNamaPenyewaDetailSewa_TextChanged_1(object sender, EventArgs e)
        {
            string nama = txtNamaPenyewaDetailSewa.Text.Trim();

            // kalau kosong → kosongkan ID
            if (string.IsNullOrEmpty(nama))
            {
                textBoxIDPenyewa.Text = "";
                //txtAlamatDetailSewa.Text = "";
                return;
            }

            string idPenyewa = penyewaController.GetIdPenyewaByNama(nama);
            //string alamatPenyewa = penyewaController.GetIdPenyewaByNama(nama);

            if (!string.IsNullOrEmpty(idPenyewa))
            {
                textBoxIDPenyewa.Text = idPenyewa;
            }
            else
            {
                textBoxIDPenyewa.Text = "";
            }
        }

        private void dtPinjam_ValueChanged(object sender, EventArgs e)
        {
            HitungTotalBiayaPreview();
        }

        private void dtKembali_ValueChanged(object sender, EventArgs e)
        {
            HitungTotalBiayaPreview();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            FormPembayaran fp = new FormPembayaran();
            fp.Show();
            this.Hide();
        }

        private void cmbMobilYangDisewaDetailSewa_SelectedIndexChanged(object sender, EventArgs e)
        {
            HitungTotalBiayaPreview();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormPembayaran fp = new FormPembayaran();
            fp.Show();
            this.Hide();
        }

        private void cmbMobilYangDisewaDetailSewa_SelectedIndexChanged(object sender, EventArgs e)
        {
            HitungTotalBiayaPreview();
        }
    }
}
