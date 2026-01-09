using SistemSewaMobil.Controller;
using SistemSewaMobil.Model.Entity;
using System;
using System.Windows.Forms;

namespace SistemSewaMobil.View
{
    public delegate void CreateUpdateEventHandler(Mobil mobil);
    public partial class FormEntryMobil : Form
    {
        public FormEntryMobil()
        {
            InitializeComponent();
            controller = new MobilController(); 
            isNewData = true;
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

            txtIdMobil.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) mobil = new Mobil();

            mobil.idMobil = txtIdMobil.Text;
            mobil.noPolisi = txtNoPolisi.Text;
            mobil.merkMobil = txtMerkMobil.Text;
            mobil.tahunMobil = txtTahunMobil.Text;
            mobil.statusKetersediaan = cmbStatusTersedia.Text;
            //mobil.hargaSewa = (int)decimal.Parse(txtHargaSewa.Text);
            mobil.hargaSewa = int.TryParse(txtHargaSewa.Text, out int harga) ? harga : 0;


            int result = 0;

            try
            {
                if (isNewData)
                {

                    result = controller.Create(mobil);

                    if (result > 0)
                    {
                        //OnCreate(mobil);
                        OnCreate?.Invoke(mobil);
                        MessageBox.Show("Data berhasil disimpan");
                        this.DialogResult = DialogResult.OK;
                        this.Close();


                        //txtIdMobil.Clear();
                        //txtNoPolisi.Clear();
                        //txtMerkMobil.Clear();
                        //txtTahunMobil.Clear();
                        //cmbStatusTersedia.SelectedIndex = -1;
                        //txtHargaSewa.Clear();

                        //txtIdMobil.Focus();
                    }
                }
                else
                {

                    result = controller.Update(mobil);

                    if (result > 0)
                    {
                        OnUpdate?.Invoke(mobil);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak berubah / gagal diupdate");
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
