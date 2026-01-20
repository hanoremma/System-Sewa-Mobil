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
    public class PembayaranController
    {
        public int Create(Pembayaran pembayaran)
        {
            using (DbContext context = new DbContext())
            {
                PembayaranRepository repo = new PembayaranRepository(context);
                return repo.Create(pembayaran);
            }
        }
        public int Update(Pembayaran pembayaran)
        {
            int result = 0;

            // Validation
            if (string.IsNullOrEmpty(pembayaran.metodePembayaran) || string.IsNullOrEmpty(pembayaran.statusPembayaran))
            {
                MessageBox.Show("Metode dan status pembayaran harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                var repo = new PembayaranRepository(context);
                return repo.Update(pembayaran);
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
        public int Delete(Pembayaran pembayaran)
        {
            int result = 0;

            // Confirmation Dialog
            var konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    var repo = new PembayaranRepository(context);
                    result = repo.Delete(pembayaran);
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
        public List<Pembayaran> GetAllPembayaran()
        {
            using (DbContext context = new DbContext())
            {
                PembayaranRepository repo = new PembayaranRepository(context);
                return repo.ReadAll();
            }
        }
        public List<Pembayaran> ReadByNamaPenyewaPembayaran(string nama)
        {
            List<Pembayaran> list = new List<Pembayaran>();

            using (DbContext context = new DbContext())
            {
                var repo = new PembayaranRepository(context);
                list = repo.ReadByNamaPenyewaPembayaran(nama);
            }

            return list;
        }
        public void UpdateStatusDetailSewa(string idDetailSewa, string status)
        {
            string sql = "UPDATE DetailSewa SET statusPenyewaan=@status WHERE idDetailSewa=@id";

            using (var context = new DbContext())
            using (SqlCommand cmd = new SqlCommand(sql, context.Conn))
            {
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", idDetailSewa);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
