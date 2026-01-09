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
    public class PetugasController
    {
        public int Create(Petugas petugas)
        {
            using (DbContext context = new DbContext())
            {
                PetugasRepository repo = new PetugasRepository(context);
                return repo.Create(petugas);
            }
        }
        public int Update(Petugas petugas)
        {
            int result = 0;

            // Validation
            if (string.IsNullOrEmpty(petugas.namaPetugas) || string.IsNullOrEmpty(petugas.noHpPetugas))
            {
                MessageBox.Show("Nama petugas dan No HP petugas harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                var repo = new PetugasRepository(context);
                result = repo.Update(petugas);
            }

            if (result > 0)
            {
                MessageBox.Show("Data petugas berhasil diperbaiki!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data petugas gagal diperbaiki!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int Delete(Petugas petugas)
        {
            int result = 0;

            // Confirmation Dialog
            var konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    var repo = new PetugasRepository(context);
                    result = repo.Delete(petugas);
                }

                if (result > 0)
                {
                    MessageBox.Show("Data petugas berhasil dihapus!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data petugas gagal dihapus!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return result;
        }
        public List<Petugas> GetAllPetugas()
        {
            using (DbContext context = new DbContext())
            {
                PetugasRepository repo = new PetugasRepository(context);
                return repo.ReadAll();
            }
        }
        public List<Petugas> ReadByNamaPetugas(string nama)
        {
            List<Petugas> list = new List<Petugas>();

            using (DbContext context = new DbContext())
            {
                var repo = new PetugasRepository(context);
                list = repo.ReadByNamaPetugas(nama);
            }

            return list;
        }
    }
}
