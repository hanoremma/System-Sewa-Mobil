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
    public partial class FormStatistik : Form
    {
        public FormStatistik()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void FormStatistik_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPenyewa_Click(object sender, EventArgs e)
        {
            FormPenyewa fp = new FormPenyewa();
            fp.Show();
            this.Hide();
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            FormPetugas fp = new FormPetugas();
            fp.Show();
            this.Hide();
        }

        private void btnMobil_Click(object sender, EventArgs e)
        {
            FormMobil fp = new FormMobil();
            fp.Show();
            this.Hide();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FormKategori fp = new FormKategori();
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

      
        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
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

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            FormBeranda fp = new FormBeranda();
            fp.Show();
            this.Hide();
        }

        private void btnPenyewaan_Click(object sender, EventArgs e)
        {
            FormDetailSewa fp = new FormDetailSewa();
            fp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
