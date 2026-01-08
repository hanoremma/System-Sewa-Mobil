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
using SistemSewaMobil.Controller;

namespace SistemSewaMobil.View
{
    public delegate void CreateUpdateEventHandler(Mobil mobil);
    public partial class FormEntryMobil : Form
    {
        public FormEntryMobil()
        {
            InitializeComponent();
        }
        public event CreateUpdateEventHandler OnCreate;

        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi objek controller 
        private MobilController controller;
    
    // deklarasi field untuk menyimpan status entry data (input baru atau update) 
        private bool isNewData = true;
    // deklarasi field untuk meyimpan objek mahasiswa 
        private Mobil mobil;
    // constructor default 
        public FormEntryMobil(string title, MobilController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
        }
        public FormEntryMobil(string title, Mobil obj, MobilController controller) 
            : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            mobil = obj;
            txtIdMobil.Text = obj.idMobil;
            txtNoPolisi.Text = obj.noPolisi;
            txtMerkMobil.Text = obj.merkMobil;
            txtTahunMobil.Text = obj.tahunMobil.ToString();
            cmbStatusTersedia.Text = obj.statusKetersediaan;
            txtHargaSewa.Text = obj.hargaSewa.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) mobil = new Mobil();

            mobil.idMobil = txtIdMobil.Text;
            mobil.noPolisi = txtNoPolisi.Text;
            mobil.merkMobil = txtMerkMobil.Text;
            mobil.tahunMobil = txtTahunMobil.Text;
            mobil.statusKetersediaan = cmbStatusTersedia.Text;
            mobil.hargaSewa = (int)decimal.Parse(txtHargaSewa.Text);

            int result = 0;

            try
            {
                if (isNewData)
                {
                    result = controller.Create(mobil);

                    if (result > 0)
                    {
                        OnCreate(mobil);

                        txtIdMobil.Clear();
                        txtNoPolisi.Clear();
                        txtMerkMobil.Clear();
                        txtTahunMobil.Clear();
                        cmbStatusTersedia.SelectedIndex = -1;
                        txtHargaSewa.Clear();

                        txtIdMobil.Focus();
                    }
                }
                else
                {
                    result = controller.Update(mobil);
                    if (result > 0)
                    {
                        OnUpdate(mobil);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
