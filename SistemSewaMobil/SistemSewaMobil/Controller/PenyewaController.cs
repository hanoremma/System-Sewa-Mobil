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
    public class PenyewaController
    {
        public int Create(Penyewa penyewa)
        {
            using (DbContext context = new DbContext())
            {
                PenyewaRepository repo = new PenyewaRepository(context);
                return repo.Create(penyewa);
            }
        }
        // 2. UPDATE: Edit costumer data
        public int Update(Penyewa penyewa)
        {
            int result = 0;

            // Validation
            if (string.IsNullOrEmpty(penyewa.namaPenyewa) || string.IsNullOrEmpty(penyewa.noHpPenyewa))
            {
                MessageBox.Show("Nama Penyewa dan No HP penyewa harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                var repo = new PenyewaRepository(context);
                result = repo.Update(penyewa);
            }

            if (result > 0)
            {
                MessageBox.Show("Data penyewa berhasil diperbaiki!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data penyewa gagal diperbaiki!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int Delete(Penyewa penyewa)
        {
            int result = 0;

            // Confirmation Dialog
            var konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    var repo = new PenyewaRepository(context);
                    result = repo.Delete(penyewa);
                }

                if (result > 0)
                {
                    MessageBox.Show("Data penyewa berhasil dihapus!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data penyewa gagal dihapus!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return result;
        }
        public List<Penyewa> GetAllPenyewa()
        {
            using (DbContext context = new DbContext())
            {
                PenyewaRepository repo = new PenyewaRepository(context);
                return repo.ReadAll();
            }
        }
        public List<Penyewa> ReadByNamaPenyewa(string namapenyewa)
        {
            List<Penyewa> list = new List<Penyewa>();

            using (DbContext context = new DbContext())
            {
                var repo = new PenyewaRepository(context);
                list = repo.ReadByNamaPenyewa(namapenyewa);
            }

            return list;
        }
    }
}
