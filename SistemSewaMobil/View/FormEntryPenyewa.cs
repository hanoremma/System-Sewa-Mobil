using SistemSewaMobil.Controller;
using SistemSewaMobil.Model.Entity;
using SistemSewaMobil.Model.Repository;
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
    public delegate void CreateUpdatePenyewaEventHandler(Penyewa penyewa);
    public partial class FormEntryPenyewa : Form
    {
        public FormEntryPenyewa()
        {
            InitializeComponent();
            controller = new PenyewaController();
            isNewData = true;

            txtIdEntryPenyewa.Text = "(Otomatis)";
            txtIdEntryPenyewa.Enabled = false;
        }
        public event CreateUpdatePenyewaEventHandler OnCreate;

        public event CreateUpdatePenyewaEventHandler OnUpdate;
        // deklarasi objek controller 
        private PenyewaController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update) 
        private bool isNewData = true;
        // deklarasi field untuk meyimpan objek mahasiswa 
        private Penyewa penyewa;
        // constructor default 
        public FormEntryPenyewa(string title, PenyewaController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
        }
        public FormEntryPenyewa(string title, Penyewa obj, PenyewaController controller)
            : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            penyewa = obj;

            txtIdEntryPenyewa.Text = obj.idPenyewa;
            txtIdEntryPenyewa.Enabled = false;
            txtNamaEntryPenyewa.Text = obj.namaPenyewa;
            txtAlamatEntryPenyewa.Text = obj.alamatPenyewa;
            txtNoKtpEntryPenyewa.Text = obj.noKtpPenyewa;
            txtNoHpEntryPenyewa.Text = obj.noHpPenyewa.ToString();

            txtIdEntryPenyewa.Enabled = false;
        }

        private void btnSimpanEntryPenyewa_Click(object sender, EventArgs e)
        {
            if (isNewData) penyewa = new Penyewa();

            penyewa.idPenyewa = txtIdEntryPenyewa.Text;
            penyewa.namaPenyewa = txtNamaEntryPenyewa.Text;
            penyewa.alamatPenyewa = txtAlamatEntryPenyewa.Text;
            penyewa.noKtpPenyewa = txtNoKtpEntryPenyewa.Text;
            penyewa.noHpPenyewa = txtNoHpEntryPenyewa.Text;

            int result = 0;

            try
            {
                if (isNewData)
                {

                    result = controller.Create(penyewa);

                    if (result > 0)
                    {
                        OnCreate?.Invoke(penyewa);
                        MessageBox.Show("Data berhasil disimpan");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    result = controller.Update(penyewa);

                    if (result > 0)
                    {
                        OnUpdate?.Invoke(penyewa);
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

        private void btnSelesaiEntryPenyewa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
