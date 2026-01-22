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
    public delegate void CreateUpdatePetugasEventHandler(Petugas petugas);
    public partial class FormEntryPetugas : Form
    {
        public FormEntryPetugas()
        {
            InitializeComponent();
            controller = new PetugasController();
            isNewData = true;

            txtIdEntryPetugas.Text = "(Otomatis)";
            txtIdEntryPetugas.Enabled = false;
        }
        public event CreateUpdatePetugasEventHandler OnCreate;

        public event CreateUpdatePetugasEventHandler OnUpdate;
        // deklarasi objek controller 
        private PetugasController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update) 
        private bool isNewData = true;
        // deklarasi field untuk meyimpan objek mahasiswa 
        private Petugas petugas;
        // constructor default 
        public FormEntryPetugas(string title, PetugasController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
        }
        public FormEntryPetugas(string title, Petugas obj, PetugasController controller)
            : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            petugas = obj;

            txtIdEntryPetugas.Text = obj.idPetugas;
            txtIdEntryPetugas.Enabled = false;
            txtNamaEntryPetugas.Text = obj.namaPetugas;
            txtAlamatEntryPetugas.Text = obj.alamatPetugas;
            txtNoHpEntryPetugas.Text = obj.noHpPetugas.ToString();

            txtIdEntryPetugas.Enabled = false;
        }

        private void btnSimpanEntryPetugas_Click(object sender, EventArgs e)
        {
            if (isNewData) petugas = new Petugas();

            petugas.idPetugas = txtIdEntryPetugas.Text;
            petugas.namaPetugas = txtNamaEntryPetugas.Text;
            petugas.alamatPetugas = txtAlamatEntryPetugas.Text;
            petugas.noHpPetugas = txtNoHpEntryPetugas.Text;

            int result = 0;

            try
            {
                if (isNewData)
                {

                    result = controller.Create(petugas);

                    if (result > 0)
                    {
                        OnCreate?.Invoke(petugas);
                        MessageBox.Show("Data berhasil disimpan");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    result = controller.Update(petugas);

                    if (result > 0)
                    {
                        OnUpdate?.Invoke(petugas);
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

        private void btnSelesaiEntryPetugas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
