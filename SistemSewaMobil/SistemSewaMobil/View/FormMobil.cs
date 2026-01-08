using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemSewaMobil.Model.Entity;
using SistemSewaMobil.Controller;
using SistemSewaMobil.View;

namespace SistemSewaMobil
{
    public partial class FormMobil : Form
    {
        private List<Mobil> listMobil = new List<Mobil>();
            private MobilController controller; 
        public FormMobil()
        {
            InitializeComponent();
            controller = new MobilController();
            InisialisasiListMobilView();
            LoadMobilData();
        }
        private void InisialisasiListMobilView()
        {
            infoMobil.View = System.Windows.Forms.View.Details; // FIX: Use fully qualified enum
            infoMobil.FullRowSelect = true;
            infoMobil.GridLines = true;

            infoMobil.Columns.Add("No.", 30, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Kategori", 100, HorizontalAlignment.Left);
            infoMobil.Columns.Add("No Polisi", 100, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Merk Mobil", 120, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Tahun", 50, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Status sedia", 70, HorizontalAlignment.Center);
            infoMobil.Columns.Add("Harga Sewa/hari", 145, HorizontalAlignment.Center);
        }

        private void LoadMobilData()
        {
            infoMobil.Items.Clear();
            listMobil = controller.GetAllMobil();

            // This method should load data into the infoMobil ListView
            // Implementation depends on how data is stored/retrieved

            foreach (var mobil in listMobil)
            {
                var noUrut = infoMobil.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mobil.idMobil);
                item.SubItems.Add(mobil.noPolisi);
                item.SubItems.Add(mobil.merkMobil);
                item.SubItems.Add(mobil.tahunMobil.ToString());
                item.SubItems.Add(mobil.statusKetersediaan);
                item.SubItems.Add(mobil.hargaSewa.ToString("Rp.")); // Format as currency
                infoMobil.Items.Add(item);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMain menuInfo = new FormMain();
            menuInfo.Show();
        }

        private void infoMobilTersedia_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FormEntryMobil formEntryMobil = new FormEntryMobil())
            {
                if (formEntryMobil.ShowDialog() == DialogResult.OK)
                {
                    LoadMobilData(); // ⬅️ REFRESH LIST
                }
            }
        }
    }
}
