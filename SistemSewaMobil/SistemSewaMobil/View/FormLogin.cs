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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtPasswordLogin.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;

            // 2. Cek apakah username dan password benar (Contoh sederhana hardcode)
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Pindah ke Menu Utama (Asumsi FormMain adalah menu utama)
                FormEntryMobil menuUtama = new FormEntryMobil();
                menuUtama.Show(); // Tampilkan menu utama

                this.Hide(); // Sembunyikan form login ini
            }
            else
            {
                // 4. Jika salah
                MessageBox.Show("Username atau Password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Left -= 5;

            // Kalau sudah keluar panel, balik ke kanan (loop)
            if (label3.Right < 0)
            {
                label3.Left = this.Width;
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
