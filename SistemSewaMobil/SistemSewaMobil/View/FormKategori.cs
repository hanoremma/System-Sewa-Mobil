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
    public partial class FormKategori : Form
    {
        private List<Kategori> listKategori = new List<Kategori>();
        private KategoriController controller;
        private bool isEdit = false;
        private int selectedIndex = -1;
        public FormKategori()
        {
            InitializeComponent();
            controller = new KategoriController();
            InisialisasiListKategoriView();
            LoadKategori();

            txtIdKategoriMobil.Text = "(Otomatis)";
            txtIdKategoriMobil.Enabled = false;

            lvwDaftarKategori.SelectedIndexChanged += lvwDaftarKategori_SelectedIndexChanged;
        }
        private void InisialisasiListKategoriView()
        {
            lvwDaftarKategori.View = System.Windows.Forms.View.Details; // FIX: Use fully qualified enum
            lvwDaftarKategori.FullRowSelect = true;
            lvwDaftarKategori.GridLines = true;

            lvwDaftarKategori.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwDaftarKategori.Columns.Add("Id Mobil", 100, HorizontalAlignment.Left);
            lvwDaftarKategori.Columns.Add("Nama Kategori", 150, HorizontalAlignment.Center);
        }
        private void LoadKategori()
        {
            lvwDaftarKategori.Items.Clear();
            listKategori = controller.GetAllKategori();

            foreach (var kategori in listKategori)
            {
                var noUrut = lvwDaftarKategori.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(kategori.idKategori);
                item.SubItems.Add(kategori.namaKategori);
                lvwDaftarKategori.Items.Add(item);
            }
        }
        private void OnCreateEventHandler(Kategori kategori)
        {
            listKategori.Add(kategori);
            int noUrut = lvwDaftarKategori.Items.Count + 1;

            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(kategori.idKategori);
            item.SubItems.Add(kategori.namaKategori);
            lvwDaftarKategori.Items.Add(item);
        }
        private void OnUpdateEventHandler(Kategori kategori)
        {
            // pastikan ada row yang dipilih
            if (lvwDaftarKategori.SelectedItems.Count == 0)
                return;

            // ambil index row yang sedang dipilih
            int index = lvwDaftarKategori.SelectedIndices[0];

            // ambil ListViewItem sesuai index
            ListViewItem itemRow = lvwDaftarKategori.Items[index];

            // update kolom
            itemRow.SubItems[1].Text = kategori.idKategori;      // kolom ID
            itemRow.SubItems[2].Text = kategori.namaKategori;    // kolom Nama

            // jika ingin, bisa reset form agar ID bisa diedit ulang
            txtIdKategoriMobil.Enabled = true;

            // set isEdit false supaya tidak salah mode edit
            isEdit = false;
        }

        private void lvwDaftarKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDaftarKategori.SelectedItems.Count == 0)
                return;

            // Ambil index baris yang dipilih
            selectedIndex = lvwDaftarKategori.SelectedIndices[0];

            // Ambil data kategori dari list
            Kategori kategori = listKategori[selectedIndex];

            // Pastikan textbox enabled sebelum assign text
            txtIdKategoriMobil.Enabled = true;
            txtIdKategoriMobil.Text = kategori.idKategori;
            txtNamaKategori.Text = kategori.namaKategori;

            // Lock ID supaya tidak bisa diubah
            txtIdKategoriMobil.Enabled = false;

            isEdit = true;
        }


        private void btnTambahKategori_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdKategoriMobil.Text) ||
        string.IsNullOrWhiteSpace(txtNamaKategori.Text))
            {
                MessageBox.Show("Lengkapi data kategori");
                return;
            }

            Kategori kategori = new Kategori
            {
                idKategori = txtIdKategoriMobil.Text,
                namaKategori = txtNamaKategori.Text
            };

            int result = controller.Create(kategori);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil disimpan");

                OnCreateEventHandler(kategori);
                LoadKategori();

                ClearForm();
            }
        }

        private void btnUpdateKategori_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                MessageBox.Show("Pilih data yang akan di edit");
                return;
            }

            // ambil kategori dari list
            Kategori kategori = listKategori[selectedIndex];

            // ambil nama baru dari textbox
            kategori.namaKategori = txtNamaKategori.Text;

            // pastikan ID kategori ada (tidak kosong)
            if (string.IsNullOrWhiteSpace(kategori.idKategori))
            {
                MessageBox.Show("ID kategori tidak valid!");
                return;
            }

            // panggil controller untuk update
            int result = controller.Update(kategori);

            if (result > 0)
            {
                MessageBox.Show("Data berhasil diupdate");

                // update ListView
                OnUpdateEventHandler(kategori);

                ClearForm();

            }
            else
            {
                MessageBox.Show("Gagal update data! Periksa ID kategori.");
            }
        }
        private void ClearForm()
        {
            txtIdKategoriMobil.Text = "(Otomatis)";
            txtIdKategoriMobil.Enabled = false;
            txtNamaKategori.Clear();
            lvwDaftarKategori.SelectedItems.Clear();
            isEdit = false;
            selectedIndex = -1;
        }

        private void btnHapusKategori_Click(object sender, EventArgs e)
        {
            if (lvwDaftarKategori.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data kategori ingin dihapus?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                );
                if (konfirmasi == DialogResult.Yes)
                {
                    Kategori kategori = listKategori[lvwDaftarKategori.SelectedIndices[0]];
                    var result = controller.Delete(kategori);
                    if (result > 0) LoadKategori();
                }
            }
            else
            {
                MessageBox.Show(
                    "Silakan pilih data kategori yang akan dihapus.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
        }

        private void btnSelesaiKategori_Click(object sender, EventArgs e)
        {
            FormStatistik fp = new FormStatistik();
            fp.Show();
            this.Hide();
        }

        private void FormKategori_Load(object sender, EventArgs e)
        {

        }

        private void btnCariKategori_Click(object sender, EventArgs e)
        {
            string keyword = txtCariKategori.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                ClearForm();
                return;
            }
            lvwDaftarKategori.Items.Clear();
            listKategori = controller.ReadByNamaKategori(keyword);

            foreach (var kategori in listKategori)
            {
                var noUrut = lvwDaftarKategori.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(kategori.idKategori);
                item.SubItems.Add(kategori.namaKategori);
                lvwDaftarKategori.Items.Add(item);
            }
            if (listKategori.Count == 0)
            {
                MessageBox.Show("Data mobil dengan merk " + keyword + " tidak ditemukan.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }
    }
}
