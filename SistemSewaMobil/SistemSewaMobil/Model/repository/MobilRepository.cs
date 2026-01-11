using SistemSewaMobil.Model.Context;
using SistemSewaMobil.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; // Ganti SQLite jadi SqlClient

namespace SistemSewaMobil.Model.Repository
{
    public class MobilRepository
    {
        // Objek koneksi yang akan dipakai
        private SqlConnection _conn;

        // Constructor: Menerima context database
        public MobilRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Mobil mobil)
        {
            int result = 0;
            // Perintah SQL Insert
            string sql = @"INSERT INTO mobil (idKategori, noPolisi, merkMobil, tahunMobil, statusKetersediaan, hargaSewa) 
                           VALUES (@idKategori, @noPolisi, @merkMobil, @tahunMobil, @statusKetersediaan, @hargaSewa)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                // Assuming the object passed to the function is named 'mobil'
                // Example: public int Create(Mobil mobil)

                cmd.Parameters.AddWithValue("@idKategori", mobil.idKategori);
                cmd.Parameters.AddWithValue("@noPolisi", mobil.noPolisi);
                cmd.Parameters.AddWithValue("@merkMobil", mobil.merkMobil);
                cmd.Parameters.AddWithValue("@tahunMobil", mobil.tahunMobil);
                cmd.Parameters.AddWithValue("@statusKetersediaan", mobil.statusKetersediaan);
                cmd.Parameters.AddWithValue("@hargaSewa", mobil.hargaSewa);

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

        public int Update(Mobil mobil)
        {
            int result = 0;

            string sql = @"UPDATE mobil SET
                    idKategori = @idKategori,
                    noPolisi = @noPolisi,
                    merkMobil = @merkMobil,
                    tahunMobil = @tahunMobil,
                    statusKetersediaan = @statusKetersediaan,
                    hargaSewa = @hargaSewa
                   WHERE idMobil = @idMobil";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idKategori", mobil.idKategori);
                cmd.Parameters.AddWithValue("@noPolisi", mobil.noPolisi);
                cmd.Parameters.AddWithValue("@merkMobil", mobil.merkMobil);
                cmd.Parameters.AddWithValue("@tahunMobil", mobil.tahunMobil);
                cmd.Parameters.AddWithValue("@statusKetersediaan", mobil.statusKetersediaan);
                cmd.Parameters.AddWithValue("@hargaSewa", mobil.hargaSewa);
                cmd.Parameters.AddWithValue("@idMobil", mobil.idMobil);

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

        public int Delete (Mobil mobil)
        {
            int result = 0;
            string sql = @"DELETE FROM mobil WHERE idMobil = @idMobil";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idMobil", mobil.idMobil);

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

        public List<Mobil> ReadAll()
        {
            List<Mobil> list = new List<Mobil>();

            string sql = @"SELECT m.idMobil, m.idKategori, k.namaKategori, m.noPolisi, 
                          m.merkMobil, m.tahunMobil, m.statusKetersediaan, m.hargaSewa
                   FROM mobil m
                   JOIN kategori k ON m.idKategori = k.idKategori
                   ORDER BY m.merkMobil";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            using (SqlDataReader dtr = cmd.ExecuteReader())
            {
                while (dtr.Read())
                {
                    list.Add(new Mobil
                    {
                        idMobil = dtr["idMobil"].ToString(),
                        idKategori = dtr["idKategori"].ToString(),
                        namaKategori = dtr["namaKategori"].ToString(),
                        noPolisi = dtr["noPolisi"].ToString(),
                        merkMobil = dtr["merkMobil"].ToString(),
                        tahunMobil = dtr["tahunMobil"].ToString(),
                        statusKetersediaan = dtr["statusKetersediaan"].ToString(),
                        hargaSewa = Convert.ToInt32(dtr["hargaSewa"])
                    });
                }
            }

            return list;
        }



        // 5. READ BY MERK: Search Car by Name/Brand
        public List<Mobil> ReadByMerk(string merk)
        {
            List<Mobil> list = new List<Mobil>();

            try
            {
                // SQL using LIKE for partial matching
                string sql = @"SELECT m.idMobil, m.idKategori, k.namaKategori, m.noPolisi, 
                              m.merkMobil, m.tahunMobil, m.statusKetersediaan, m.hargaSewa 
                       FROM mobil m
                       JOIN kategori k ON m.idKategori = k.idKategori
                       WHERE m.merkMobil LIKE @merkMobil 
                       ORDER BY m.merkMobil";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    // Use wildcard % for search (e.g., "Avanza" becomes "%Avanza%")
                    cmd.Parameters.AddWithValue("@merkMobil", string.Format("%{0}%", merk));

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Mobil m = new Mobil();
                            m.idMobil = dtr["idMobil"].ToString();
                            m.idKategori = dtr["idKategori"].ToString();
                            m.namaKategori = dtr["namaKategori"].ToString();
                            m.noPolisi = dtr["noPolisi"].ToString();
                            m.merkMobil = dtr["merkMobil"].ToString();
                            m.tahunMobil = dtr["tahunMobil"].ToString();
                            m.statusKetersediaan = dtr["statusKetersediaan"].ToString();
                            m.hargaSewa = Convert.ToInt32(dtr["hargaSewa"]);

                            list.Add(m);
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