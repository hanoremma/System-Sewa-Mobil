using System;
using System.Collections.Generic;
using System.Windows.Forms; // Needed for MessageBox
using SistemSewaMobil.Model.Entity;
using SistemSewaMobil.Model.Repository;
using SistemSewaMobil.Model.Context;

namespace SistemSewaMobil.Controller
{
    public class MobilController
    {
        // 1. CREATE: Add New Car
        //public int Create(Mobil mobil)
        //{
        //    int result = 0;

        //    // Validation: Ensure mandatory fields are not empty
        //    if (string.IsNullOrEmpty(mobil.merkMobil) || string.IsNullOrEmpty(mobil.noPolisi))
        //    {
        //        MessageBox.Show("Merk Mobil dan No Polisi harus diisi!", "Peringatan",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return 0;
        //    }

        //    // Create Context and Repository, then execute
        //    using (DbContext context = new DbContext())
        //    {
        //        var repo = new MobilRepository(context);
        //        result = repo.Create(mobil);
        //    }

        //    if (result > 0)
        //    {
        //        MessageBox.Show("Data mobil berhasil disimpan!", "Informasi",
        //            MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Data mobil gagal disimpan!", "Peringatan",
        //            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }

        //    return result;
        //}
        public int Create(Mobil mobil)
        {
            using (DbContext context = new DbContext())
            {
                MobilRepository repo = new MobilRepository(context);
                return repo.Create(mobil);
            }
        }

        // 2. UPDATE: Edit Car Data
        public int Update(Mobil mobil)
        {
            int result = 0;

            // Validation
            if (string.IsNullOrEmpty(mobil.merkMobil) || string.IsNullOrEmpty(mobil.noPolisi))
            {
                MessageBox.Show("Merk Mobil dan No Polisi harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                var repo = new MobilRepository(context);
                result = repo.Update(mobil);
            }

            if (result > 0)
            {
                MessageBox.Show("Data mobil berhasil diperbaiki!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data mobil gagal diperbaiki!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        // 3. DELETE: Remove Car
        public int Delete(Mobil mobil)
        {
            int result = 0;

            // Confirmation Dialog
            var konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    var repo = new MobilRepository(context);
                    result = repo.Delete(mobil);
                }

                if (result > 0)
                {
                    MessageBox.Show("Data mobil berhasil dihapus!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data mobil gagal dihapus!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return result;
        }

        public List<Mobil> GetAllMobil()
        {
            using (DbContext context = new DbContext())
            {
                MobilRepository repo = new MobilRepository(context);
                return repo.ReadAll();
            }
        }


        // 5. READ BY MERK: Search Cars
        public List<Mobil> ReadByMerk(string nama)
        {
            List<Mobil> list = new List<Mobil>();

            using (DbContext context = new DbContext())
            {
                var repo = new MobilRepository(context);
                list = repo.ReadByMerk(nama);
            }

            return list;
        }
    }
}