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

        private void jam_tick_Tick(object sender, EventArgs e)
        {
            DateTime sekarang = DateTime.Now;

            
            lbljam.Text = sekarang.ToString("HH:mm:ss");

            int jam = sekarang.Hour;

            
            if (jam >= 5 && jam < 11)
            {
                lblGreeting.Text = "Selamat Pagi🌄";
            }
            else if (jam >= 11 && jam < 15)
            {
                lblGreeting.Text = "Selamat Siang☀";
            }
            else if (jam >= 15 && jam < 18)
            {
                lblGreeting.Text = "Selamat Sore🌇";
            }
            else
            {
                lblGreeting.Text = "Selamat Malam🌙";
            }
        }

        private void lbljam_Click(object sender, EventArgs e)
        {

        }

        private void lblGreeting_Click(object sender, EventArgs e)
        {

        }

        private void btnPenyewa_Click(object sender, EventArgs e)
        {
            FormDetailSewa fp = new FormDetailSewa();
            fp.Show();
            this.Hide();
        }

        private void btnStatistik_Click(object sender, EventArgs e)
        {
            FormStatistik fp = new FormStatistik();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
