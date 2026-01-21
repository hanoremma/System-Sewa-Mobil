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
    public class DetailSewaRepository
    {
        private SqlConnection _conn;

        // Constructor: Menerima context database
        public DetailSewaRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(DetailSewa detailsewa)
        {
            int result = 0;
            // Perintah SQL Insert
            string sql = @"
                INSERT INTO detailSewa (idPenyewa, idPetugas, idMobil, tglPinjam, tglKembali, statusPenyewaan)
                VALUES (
                    (SELECT idPenyewa FROM penyewa WHERE namaPenyewa = @namaPenyewa),
                    @idPetugas,
                    @idMobil,
                    @tglPinjam,
                    @tglKembali,
                    @statusPenyewaan)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                // Assuming the object passed to the function is named 'mobil'
                // Example: public int Create(Mobil mobil)

                cmd.Parameters.AddWithValue("@namaPenyewa", detailsewa.namaPenyewa);
                cmd.Parameters.AddWithValue("@idPetugas", detailsewa.idPetugas);
                cmd.Parameters.AddWithValue("@idMobil", detailsewa.idMobil);
                cmd.Parameters.AddWithValue("@tglPinjam", detailsewa.tglPinjam);
                cmd.Parameters.AddWithValue("@tglKembali", detailsewa.tglKembali);
                cmd.Parameters.AddWithValue("@statusPenyewaan", detailsewa.statusPenyewaan);

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
        public int Update(DetailSewa detailsewa)
        {
            int result = 0;

            string sql = @"UPDATE detailSewa SET
                        idPenyewa = @idPenyewa,
                        idPetugas = @idPetugas,
                        idMobil = @idMobil,
                        tglPinjam = @tglPinjam,
                        tglKembali = @tglKembali,
                        statusPenyewaan = @statusPenyewaan
                   WHERE idDetailSewa = @idDetailSewa";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idDetailSewa", detailsewa.idDetailSewa);
                cmd.Parameters.AddWithValue("@idPenyewa", detailsewa.idPenyewa);
                cmd.Parameters.AddWithValue("@idPetugas", detailsewa.idPetugas);
                cmd.Parameters.AddWithValue("@idMobil", detailsewa.idMobil);
                cmd.Parameters.AddWithValue("@tglPinjam", detailsewa.tglPinjam);
                cmd.Parameters.AddWithValue("@tglKembali", detailsewa.tglKembali);
                cmd.Parameters.AddWithValue("@statusPenyewaan", detailsewa.statusPenyewaan);

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
        public int Delete(DetailSewa detailsewa)
        {
            int result = 0;
            string sql = @"DELETE FROM detailSewa WHERE idDetailSewa = @idDetailSewa";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                // cmd.Parameters.AddWithValue("@idMobil", mobil.idMobil);
                cmd.Parameters.AddWithValue("@idDetailSewa", detailsewa.idDetailSewa);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete Error: {0}", ex.Message);
                }
            }
            return result;
        }
        public List<DetailSewa> ReadAll()
        {
            List<DetailSewa> list = new List<DetailSewa>();

            string sql = @"SELECT 
                                ds.idDetailSewa,
                                p.idPenyewa,
                                p.namaPenyewa,
                                p.alamatPenyewa,
                                p.noKtpPenyewa,
                                p.noHpPenyewa,
                                pt.idPetugas,
                                pt.namaPetugas,
                                m.idMobil,
                                m.noPolisi,
                                m.merkMobil,
                                ds.tglPinjam,
                                ds.tglKembali,
                                ds.statusPenyewaan,
                                ds.totalBiaya

                            FROM detailSewa ds
                            JOIN penyewa p   ON ds.idPenyewa = p.idPenyewa
                            JOIN petugas pt  ON ds.idPetugas = pt.idPetugas
                            JOIN mobil m     ON ds.idMobil = m.idMobil
                            ORDER BY ds.tglPinjam DESC";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            using (SqlDataReader dtr = cmd.ExecuteReader())
            {
                while (dtr.Read())
                {
                    list.Add(new DetailSewa
                    {
                        idDetailSewa = dtr["idDetailSewa"].ToString(),
                        idPenyewa = dtr["idPenyewa"].ToString(),
                        namaPenyewa = dtr["namaPenyewa"].ToString(),
                        alamatPenyewa = dtr["alamatPenyewa"].ToString(),
                        noKtpPenyewa = dtr["noKtpPenyewa"].ToString(),
                        noHpPenyewa = dtr["noHpPenyewa"].ToString(),

                        idPetugas = dtr["idPetugas"].ToString(),
                        namaPetugas = dtr["namaPetugas"].ToString(),

                        idMobil = dtr["idMobil"].ToString(),
                        merkMobil = dtr["merkMobil"].ToString(),
                        noPolisi = dtr["noPolisi"].ToString(),

                        tglPinjam = Convert.ToDateTime(dtr["tglPinjam"]),
                        tglKembali = Convert.ToDateTime(dtr["tglKembali"]),
                        statusPenyewaan = dtr["statusPenyewaan"].ToString(),
                        totalBiaya = (int)Convert.ToDecimal(dtr["totalBiaya"])
                    });
                }
            }

            return list;
        }
        public List<DetailSewa> ReadByNamaPenyewaDetailSewa(string namapenyewads)
        {
            List<DetailSewa> list = new List<DetailSewa>();

            try
            {
                string sql = @"
            SELECT 
                                ds.idDetailSewa,
                                p.idPenyewa,
                                p.namaPenyewa,
                                p.alamatPenyewa,
                                p.noKtpPenyewa,
                                p.noHpPenyewa,
                                pt.idPetugas,
                                pt.namaPetugas,
                                m.idMobil,
                                m.noPolisi,
                                m.merkMobil,
                                ds.tglPinjam,
                                ds.tglKembali,
                                ds.statusPenyewaan,
                                ds.totalBiaya

                            FROM detailSewa ds
                            JOIN penyewa p   ON ds.idPenyewa = p.idPenyewa
                            JOIN petugas pt  ON ds.idPetugas = pt.idPetugas
                            JOIN mobil m     ON ds.idMobil = m.idMobil
                            WHERE p.namaPenyewa LIKE @namaPenyewa
                            ORDER BY ds.tglPinjam DESC";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@namaPenyewa", $"%{namapenyewads}%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            DetailSewa ds = new DetailSewa();
                            ds.idDetailSewa = dtr["idDetailSewa"].ToString();
                            ds.idPenyewa = dtr["idPenyewa"].ToString();
                            ds.namaPenyewa = dtr["namaPenyewa"].ToString();
                            ds.alamatPenyewa = dtr["alamatPenyewa"].ToString();
                            ds.noKtpPenyewa = dtr["noKtpPenyewa"].ToString();
                            ds.noHpPenyewa = dtr["noHpPenyewa"].ToString();

                            ds.idPetugas = dtr["idPetugas"].ToString();
                            ds.namaPetugas = dtr["namaPetugas"].ToString();

                            ds.idMobil = dtr["idMobil"].ToString();
                            ds.merkMobil = dtr["merkMobil"].ToString();
                            ds.noPolisi = dtr["noPolisi"].ToString();

                            ds.tglPinjam = Convert.ToDateTime(dtr["tglPinjam"]);
                            ds.tglKembali = Convert.ToDateTime(dtr["tglKembali"]);
                            ds.statusPenyewaan = dtr["statusPenyewaan"].ToString();
                            ds.totalBiaya = (int)Convert.ToDecimal(dtr["totalBiaya"]);

                            list.Add(ds);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNamaPenyewaDetailSewa Error: {0}", ex.Message);
            }

            return list;
        }
        public bool IsMobilTersedia(string idMobil, DateTime tglPinjam, DateTime tglKembali, string idDetailSewa = null)
        {
            string sql = @"
        SELECT COUNT(*)
        FROM DetailSewa
        WHERE idMobil = @idMobil
          AND statusPenyewaan <> 'Dibatalkan'
          AND (
                @tglPinjam <= tglKembali
                AND @tglKembali >= tglPinjam
              )
          AND (@idDetailSewa IS NULL OR idDetailSewa <> @idDetailSewa)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idMobil", idMobil);
                cmd.Parameters.AddWithValue("@tglPinjam", tglPinjam);
                cmd.Parameters.AddWithValue("@tglKembali", tglKembali);
                cmd.Parameters.AddWithValue("@idDetailSewa", (object)idDetailSewa ?? DBNull.Value);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 0; // true = tersedia
            }
        }
    }
}
