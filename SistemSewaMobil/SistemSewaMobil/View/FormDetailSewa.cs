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
            /*infoMobilTerpilih.View = System.Windows.Forms.View.Details;
            infoMobilTerpilih.FullRowSelect = true;
            infoMobilTerpilih.GridLines = true;

            infoMobilTerpilih.Columns.Add("No.", 30, HorizontalAlignment.Center);
            infoMobilTerpilih.Columns.Add("Merk Mobil", 120, HorizontalAlignment.Center);
            infoMobilTerpilih.Columns.Add("Kategori", 100, HorizontalAlignment.Left);
            infoMobilTerpilih.Columns.Add("No Polisi", 100, HorizontalAlignment.Center);
            infoMobilTerpilih.Columns.Add("Tahun", 50, HorizontalAlignment.Center);
            infoMobilTerpilih.Columns.Add("Status sedia", 70, HorizontalAlignment.Center);
            infoMobilTerpilih.Columns.Add("Harga Sewa/hari", 100, HorizontalAlignment.Center);*/
        }

        private void comboBoxMobil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mobil mobilDipilih = (Mobil)cmbMobilYangDisewaDetailSewa.SelectedItem;

            /*infoMobilTerpilih.Items.Clear(); // Hapus isi ListView sebelum diisi ulang

            ListViewItem item = new ListViewItem(mobilDipilih.idMobil);
            item.SubItems.Add(mobilDipilih.noPolisi);
            item.SubItems.Add(mobilDipilih.merkMobil);
            item.SubItems.Add(mobilDipilih.tahunMobil);
            item.SubItems.Add(mobilDipilih.statusKetersediaan);
            item.SubItems.Add(mobilDipilih.hargaSewa.ToString());

            infoMobilTerpilih.Items.Add(item);*/
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

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

        private void button4_Click_1(object sender, EventArgs e)
        {
            FormStatistik fp = new FormStatistik();
            fp.Show();
            this.Hide();
        }
    }
}
