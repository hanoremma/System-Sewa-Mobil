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
    public partial class FormPetugas : Form
    {
        private List<Petugas> listPetugas = new List<Petugas>();
        private PetugasController controller;
        public FormPetugas()
        {
            InitializeComponent();
            controller = new PetugasController();
            InisialisasiListPetugasView();
            LoadPetugasData();
        }
        private void InisialisasiListPetugasView()
        {
            lvwDaftarPetugas.View = System.Windows.Forms.View.Details;
            lvwDaftarPetugas.FullRowSelect = true;
            lvwDaftarPetugas.GridLines = true;

            lvwDaftarPetugas.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwDaftarPetugas.Columns.Add("ID Petugas", 120, HorizontalAlignment.Center);
            lvwDaftarPetugas.Columns.Add("Nama Petugas", 160, HorizontalAlignment.Center);
            lvwDaftarPetugas.Columns.Add("Alamat Petugas", 200, HorizontalAlignment.Center);
            lvwDaftarPetugas.Columns.Add("No HP", 150, HorizontalAlignment.Center);
        }
        private void LoadPetugasData()
        {
            lvwDaftarPetugas.Items.Clear();
            listPetugas = controller.GetAllPetugas();

            // This method should load data into the infoMobil ListView
            // Implementation depends on how data is stored/retrieved

            foreach (var petugas in listPetugas)
            {
                var noUrut = lvwDaftarPetugas.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(petugas.idPetugas);
                item.SubItems.Add(petugas.namaPetugas);
                item.SubItems.Add(petugas.alamatPetugas);
                item.SubItems.Add(petugas.noHpPetugas);
                lvwDaftarPetugas.Items.Add(item);
            }
        }
        private void OnCreateEventHandler(Petugas petugas)
        {
            listPetugas.Add(petugas);
            int noUrut = lvwDaftarPetugas.Items.Count + 1;

            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(petugas.idPetugas);
            item.SubItems.Add(petugas.namaPetugas);
            item.SubItems.Add(petugas.alamatPetugas);
            item.SubItems.Add(petugas.noHpPetugas);
            lvwDaftarPetugas.Items.Add(item);
        }
        private void OnUpdateEventHandler(Petugas petugas)
        {
            int index = lvwDaftarPetugas.SelectedIndices[0];

            ListViewItem itemRow = lvwDaftarPetugas.Items[index];
            itemRow.SubItems[1].Text = petugas.idPetugas;
            itemRow.SubItems[2].Text = petugas.namaPetugas;
            itemRow.SubItems[2].Text = petugas.alamatPetugas;
            itemRow.SubItems[4].Text = petugas.noHpPetugas;
        }

        private void FormPetugas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahPetugas_Click(object sender, EventArgs e)
        {
            FormEntryPetugas formEntryPetugas = new FormEntryPetugas("Tambah Data Petugas", controller);
            formEntryPetugas.OnCreate += OnCreateEventHandler;
            if (formEntryPetugas.ShowDialog() == DialogResult.OK)
            {
                LoadPetugasData();
            }
        }

        private void btnUpdatePetugas_Click(object sender, EventArgs e)
        {
            if (lvwDaftarPetugas.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Silakan pilih data petugas yang akan diubah.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int index = lvwDaftarPetugas.SelectedIndices[0];
            Petugas petugas = listPetugas[index];
            FormEntryPetugas formEntryPetugas =
                new FormEntryPetugas("Edit Data Petugas", petugas, controller);

            formEntryPetugas.OnUpdate += OnUpdateEventHandler;

            if (formEntryPetugas.ShowDialog() == DialogResult.OK)
            {
                LoadPetugasData();
            }
        }

        private void btnHapusPetugas_Click(object sender, EventArgs e)
        {
            if (lvwDaftarPetugas.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data petugas ingin dihapus?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                );
                if (konfirmasi == DialogResult.Yes)
                {
                    Petugas petugas = listPetugas[lvwDaftarPetugas.SelectedIndices[0]];
                    var result = controller.Delete(petugas);
                    if (result > 0) LoadPetugasData();
                }
            }
            else
            {
                MessageBox.Show(
                    "Silakan pilih data petugas yang akan dihapus.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
        }

        private void btnCariPetugas_Click(object sender, EventArgs e)
        {
            string keyword = txtCariPetugas.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadPetugasData();
                return;
            }
            lvwDaftarPetugas.Items.Clear();
            listPetugas = controller.ReadByNamaPetugas(keyword);

            foreach (var petugas in listPetugas)
            {
                var noUrut = lvwDaftarPetugas.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(petugas.idPetugas);
                item.SubItems.Add(petugas.namaPetugas);
                item.SubItems.Add(petugas.alamatPetugas);
                item.SubItems.Add(petugas.noHpPetugas);
                lvwDaftarPetugas.Items.Add(item);
            }
            if (listPetugas.Count == 0)
            {
                MessageBox.Show("Data petugas dengan nama " + keyword + " tidak ditemukan.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPetugasData();
            }
        }

        private void btnSelesaiPetugas_Click(object sender, EventArgs e)
        {
            FormStatistik fp = new FormStatistik();
            fp.Show();
            this.Hide();
        }
    }
}
