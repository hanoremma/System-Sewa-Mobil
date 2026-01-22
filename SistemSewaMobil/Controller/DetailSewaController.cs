using SistemSewaMobil.Model.Context;
using SistemSewaMobil.Model.Entity;
using SistemSewaMobil.Model.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemSewaMobil.Controller
{
    public class DetailSewaController
    {
        public int Create(DetailSewa detailsewa)
        {
            using (DbContext context = new DbContext())
            {
                DetailSewaRepository repo = new DetailSewaRepository(context);
                return repo.Create(detailsewa);
            }
        }

        public int Update(DetailSewa detailsewa)
        {
            int result = 0;

            // Validation
            if (string.IsNullOrEmpty(detailsewa.namaPenyewa) ||
                string.IsNullOrEmpty(detailsewa.noKtpPenyewa))
            {
                MessageBox.Show("Nama penyewa dan No KTP harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            try
            {
                using (DbContext context = new DbContext())
                {
                    var repo = new DetailSewaRepository(context);
                    result = repo.Update(detailsewa);
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
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    $"Terjadi kesalahan:\n{e.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return result;
        }


        public int Delete(DetailSewa detailsewa)
        {
            int result = 0;

            // Confirmation Dialog
            var konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    var repo = new DetailSewaRepository(context);
                    result = repo.Delete(detailsewa);
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
        public List<DetailSewa> GetAllDetailSewa()
        {
            using (DbContext context = new DbContext())
            {
                DetailSewaRepository repo = new DetailSewaRepository(context);
                return repo.ReadAll();
            }
        }
        public List<DetailSewa> ReadByNamaPenyewaDetailSewa(string namapenyewads)
        {
            List<DetailSewa> list = new List<DetailSewa>();

            using (DbContext context = new DbContext())
            {
                var repo = new DetailSewaRepository(context);
                list = repo.ReadByNamaPenyewaDetailSewa(namapenyewads);
            }

            return list;
        }
        public List<DetailSewa> GetDetailSewaBelumDibayar()
        {
            List<DetailSewa> list = new List<DetailSewa>();

            string sql = @"SELECT 
                    ds.idDetailSewa,
                    p.namaPenyewa,
                    ds.totalBiaya
                  FROM DetailSewa ds
                  JOIN Penyewa p ON ds.idPenyewa = p.idPenyewa
                  WHERE ds.idDetailSewa NOT IN
                        (SELECT idDetailSewa FROM Pembayaran)";

            using (var context = new DbContext())
            using (SqlCommand cmd = new SqlCommand(sql, context.Conn))
            using (SqlDataReader dtr = cmd.ExecuteReader())
            {
                while (dtr.Read())
                {
                    list.Add(new DetailSewa
                    {
                        idDetailSewa = dtr["idDetailSewa"].ToString(),
                        namaPenyewa = dtr["namaPenyewa"].ToString(),
                        totalBiaya = Convert.ToInt32(dtr["totalBiaya"])
                    });
                }
            }
            return list;
        }
        public bool CekKetersediaanMobil(string idMobil, DateTime tglPinjam, DateTime tglKembali, string idDetailSewa = null)
        {
            using (DbContext context = new DbContext())
            {
                DetailSewaRepository repo = new DetailSewaRepository(context);
                return repo.IsMobilTersedia(idMobil, tglPinjam, tglKembali, idDetailSewa);
            }
        }
    }

}
