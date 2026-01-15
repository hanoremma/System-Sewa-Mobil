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
    }
}
