using SistemSewaMobil.Model.Context;
using SistemSewaMobil.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemSewaMobil.Model.Repository
{
    public class PembayaranRepository
    {
        private SqlConnection _conn;

        // Constructor: Menerima context database
        public PembayaranRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(Pembayaran pembayaran)
        {
            int result = 0;
            // Perintah SQL Insert
            string sql = @"INSERT INTO pembayaran (idDetailSewa, tglPembayaran, metodePembayaran, biayaServis, diskon, totalPembayaran, statusPembayaran) 
                           VALUES (@idDetailSewa, @tglPembayaran, @metodePembayaran, @biayaServis, @diskon, @totalPembayaran, @statusPembayaran)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                // Assuming the object passed to the function is named 'mobil'
                // Example: public int Create(Mobil mobil)

                cmd.Parameters.AddWithValue("@idDetailSewa", pembayaran.idDetailSewa);
                cmd.Parameters.AddWithValue("@tglPembayaran", pembayaran.tglPembayaran);
                cmd.Parameters.AddWithValue("@metodePembayaran", pembayaran.metodePembayaran);
                cmd.Parameters.AddWithValue("@biayaServis", pembayaran.biayaServis);
                cmd.Parameters.AddWithValue("@diskon", pembayaran.diskon);
                cmd.Parameters.AddWithValue("@totalPembayaran", pembayaran.totalPembayaran);
                cmd.Parameters.AddWithValue("@statusPembayaran", pembayaran.statusPembayaran);

                try
                {
                    result = cmd.ExecuteNonQuery(); // Eksekusi perintah
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create Error: {0}", ex.Message);
                }
            }
            return result;
        }
        public int Update(Pembayaran pembayaran)
        {
            int result = 0;

            string sql = @"UPDATE pembayaran SET
                    idDetailSewa = @idDetailSewa,
                    tglPembayaran = @tglPembayaran,
                    metodePembayaran = @metodePembayaran,
                    biayaServis = @biayaServis,
                    diskon = @diskon,
                    totalPembayaran = @totalPembayaran,
                    statusPembayaran = @statusPembayaran
                     WHERE idPembayaran = @idPembayaran";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idPembayaran", pembayaran.idPembayaran);
                cmd.Parameters.AddWithValue("@idDetailSewa", pembayaran.idDetailSewa);
                cmd.Parameters.AddWithValue("@tglPembayaran", pembayaran.tglPembayaran);
                cmd.Parameters.AddWithValue("@metodePembayaran", pembayaran.metodePembayaran);
                cmd.Parameters.AddWithValue("@biayaServis", pembayaran.biayaServis);
                cmd.Parameters.AddWithValue("@diskon", pembayaran.diskon);
                cmd.Parameters.AddWithValue("@totalPembayaran", pembayaran.totalPembayaran);
                cmd.Parameters.AddWithValue("@statusPembayaran", pembayaran.statusPembayaran);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update Error: {0}", ex.Message);
                }
            }

            return result;
        }
        public int Delete(Pembayaran pembayaran)
        {
            string sql = @"DELETE FROM pembayaran WHERE idPembayaran = @idPembayaran";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idPembayaran", pembayaran.idPembayaran);
                return cmd.ExecuteNonQuery();
            }
        }
        public List<Pembayaran> ReadAll()
        {
            List<Pembayaran> list = new List<Pembayaran>();

            string sql = @"SELECT 
                                    pb.idPembayaran,
                                    ds.idDetailSewa,
                                    p.namaPenyewa,
                                    pb.tglPembayaran,
                                    pb.metodePembayaran,
                                    pb.biayaServis,
                                    pb.diskon,
                                    pb.totalPembayaran,
                                    pb.statusPembayaran
                                FROM pembayaran pb
                                JOIN detailSewa ds ON pb.idDetailSewa = ds.idDetailSewa
                                JOIN penyewa p    ON ds.idPenyewa = p.idPenyewa
                                ORDER BY pb.idPembayaran DESC";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            using (SqlDataReader dtr = cmd.ExecuteReader())
            {
                while (dtr.Read())
                {
                    list.Add(new Pembayaran
                    {
                        idPembayaran = dtr["idPembayaran"].ToString(),
                        idDetailSewa = dtr["idDetailSewa"].ToString(),
                        namaPenyewa = dtr["namaPenyewa"].ToString(),
                        tglPembayaran = Convert.ToDateTime(dtr["tglPembayaran"]),
                        metodePembayaran = dtr["metodePembayaran"].ToString(),
                        biayaServis = Convert.ToInt32(dtr["biayaServis"]),
                        diskon = Convert.ToInt32(dtr["diskon"]),
                        totalPembayaran = Convert.ToInt32(dtr["totalPembayaran"]),
                        statusPembayaran = dtr["statusPembayaran"].ToString()
                    });
                }
            }

            return list;
        }
        public List<Pembayaran> ReadByNamaPenyewaPembayaran(string nama)
        {
            List<Pembayaran> list = new List<Pembayaran>();

            try
            {
                // SQL using LIKE for partial matching
                string sql = @"SELECT 
                                    pb.idPembayaran,
                                    ds.idDetailSewa,
                                    p.namaPenyewa,
                                    pb.tglPembayaran,
                                    pb.metodePembayaran,
                                    pb.biayaServis,
                                    pb.diskon,
                                    pb.totalPembayaran,
                                    pb.statusPembayaran
                                FROM pembayaran pb
                                JOIN detailSewa ds ON pb.idDetailSewa = ds.idDetailSewa
                                JOIN penyewa p    ON ds.idPenyewa = p.idPenyewa
                                WHERE p.namaPenyewa LIKE @namaPenyewa
                                ORDER BY pb.idPembayaran DESC";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    // Use wildcard % for search (e.g., "Avanza" becomes "%Avanza%")
                    cmd.Parameters.AddWithValue("@namaPenyewa", string.Format("%{0}%", nama));

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pembayaran pb = new Pembayaran();
                            pb.idPembayaran = dtr["idPembayaran"].ToString();
                            pb.idDetailSewa = dtr["idDetailSewa"].ToString();
                            pb.namaPenyewa = dtr["namaPenyewa"].ToString();
                            pb.tglPembayaran = Convert.ToDateTime(dtr["tglPembayaran"]);
                            pb.metodePembayaran = dtr["metodePembayaran"].ToString();
                            pb.biayaServis = Convert.ToInt32(dtr["biayaServis"]);
                            pb.diskon = Convert.ToInt32(dtr["diskon"]);
                            pb.totalPembayaran = Convert.ToInt32(dtr["totalPembayaran"]);
                            pb.statusPembayaran = dtr["statusPembayaran"].ToString();

                            list.Add(pb);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByMerk Error: {0}", ex.Message);
            }

            return list;
        }



    }
}
