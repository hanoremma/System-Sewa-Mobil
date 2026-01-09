using SistemSewaMobil.Model.Context;
using SistemSewaMobil.Model.Entity;
using SistemSewaMobil.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemSewaMobil.Controller
{
    public class KategoriController
    {
        public int Create(Kategori kategori)
        {
            using (DbContext context = new DbContext())
            {
                KategoriRepository repo = new KategoriRepository(context);
                return repo.Create(kategori);
            }
        }

        // 2. UPDATE: Edit Car Data
        public int Update(Kategori kategori)
        {
            int result = 0;

            // Validation
            if (string.IsNullOrEmpty(kategori.namaKategori))
            {
                MessageBox.Show("Nama kategori harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                var repo = new KategoriRepository(context);
                result = repo.Update(kategori);
            }

            if (result > 0)
            {
                MessageBox.Show("Data kategori berhasil diperbaiki!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data kategori gagal diperbaiki!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        // 3. DELETE: Remove Car
        public int Delete(Kategori kategori)
        {
            int result = 0;

            // Confirmation Dialog
            var konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    var repo = new KategoriRepository(context);
                    result = repo.Delete(kategori);
                }

                if (result > 0)
                {
                    MessageBox.Show("Data kategori berhasil dihapus!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data kategori gagal dihapus!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return result;
        }

        public List<Kategori> GetAllKategori()
        {
            using (DbContext context = new DbContext())
            {
                KategoriRepository repo = new KategoriRepository(context);
                return repo.ReadAll();
            }
        }


        // 5. READ BY MERK: Search Cars
        public List<Kategori> ReadByNamaKategori(string nama)
        {
            List<Kategori> list = new List<Kategori>();

            using (DbContext context = new DbContext())
            {
                var repo = new KategoriRepository(context);
                list = repo.ReadByNamaKategori(nama);
            }
            return list;
        }
    }
}
