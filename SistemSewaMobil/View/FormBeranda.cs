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
    public partial class FormBeranda : Form
    {
        public FormBeranda()
        {
            InitializeComponent();
        }

        bool sidebarExpand;
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick_1(object sender, EventArgs e)
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

        private void jam_Tick(object sender, EventArgs e)
        {
            lbljam.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FormBeranda_Load(object sender, EventArgs e)
        {
            jam.Start();
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

        private void btnPenyewa_Click(object sender, EventArgs e)
        {
            FormPenyewa fp = new FormPenyewa();
            fp.Show();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FormKategori fp = new FormKategori();
            fp.Show();
        }

        private void btnMobil_Click(object sender, EventArgs e)
        {
            FormMobil fp = new FormMobil();
            fp.Show();
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            FormPetugas fp = new FormPetugas();
            fp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEntryDetailSewa fp = new FormEntryDetailSewa();
            fp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPembayaran fp = new FormPembayaran();
            fp.Show();
        }

 

        private void button6_Click(object sender, EventArgs e)
        {
            FormBeranda fp = new FormBeranda();
            fp.Show();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormLaporan fp = new FormLaporan();
            fp.Show();
        }
    }
}
