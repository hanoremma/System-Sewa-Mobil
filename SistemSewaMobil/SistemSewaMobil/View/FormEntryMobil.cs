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

            InitStatusCombo();
        }

        private void InitStatusCombo()
        {
            cmbStatusTersediaEntryMobil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusTersediaEntryMobil.Items.Clear();
            cmbStatusTersediaEntryMobil.Items.Add("Tersedia");
            cmbStatusTersediaEntryMobil.Items.Add("Tidak Tersedia");
            cmbStatusTersediaEntryMobil.SelectedIndex = 0;
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
            txtIdMobilEntryMobil.Text = obj.idMobil;
            txtNoPolisiEntryMobil.Text = obj.noPolisi;
            txtMerkMobilEntryMobil.Text = obj.merkMobil;
            txtTahunMobilEntryMobil.Text = obj.tahunMobil.ToString();
            cmbStatusTersediaEntryMobil.Text = obj.statusKetersediaan;
            txtHargaSewaEntryMobil.Text = obj.hargaSewa.ToString();

            txtIdMobilEntryMobil.Enabled = false;
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) mobil = new Mobil();

            mobil.idMobil = txtIdMobilEntryMobil.Text;
            mobil.noPolisi = txtNoPolisiEntryMobil.Text;
            mobil.merkMobil = txtMerkMobilEntryMobil.Text;
            mobil.tahunMobil = txtTahunMobilEntryMobil.Text;
            mobil.statusKetersediaan = cmbStatusTersediaEntryMobil.Text;
            //mobil.hargaSewa = (int)decimal.Parse(txtHargaSewa.Text);
            mobil.hargaSewa = int.TryParse(txtHargaSewaEntryMobil.Text, out int harga) ? harga : 0;


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

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
