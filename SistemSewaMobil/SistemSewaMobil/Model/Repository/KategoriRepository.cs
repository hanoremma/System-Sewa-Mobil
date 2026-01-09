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
    public class KategoriRepository
    {
        private SqlConnection _conn;

        // Constructor: Menerima context database
        public KategoriRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Kategori kategori)
        {
            int result = 0;
            // Perintah SQL Insert
            string sql = @"INSERT INTO kategori (idKategori, namaKategori) 
                           VALUES (@idKategori, @namaKategori)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                // Assuming the object passed to the function is named 'mobil'
                // Example: public int Create(Mobil mobil)

                cmd.Parameters.AddWithValue("@idKategori", kategori.idKategori);
                cmd.Parameters.AddWithValue("@namaKategori", kategori.namaKategori);

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

        public int Update(Kategori kategori)
        {
            int result = 0;

            string sql = @"UPDATE kategori SET
                    namaKategori = @namaKategori,
                   WHERE idKategori = @idKategori";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idKategori", kategori.idKategori);
                cmd.Parameters.AddWithValue("@namaKategori", kategori.namaKategori);

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

        public int Delete(Kategori kategori)
        {
            int result = 0;
            string sql = @"DELETE FROM kategori WHERE idKategori = @idKategori";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idKategori", kategori.idKategori);

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

        public List<Kategori> ReadAll()
        {
            List<Kategori> list = new List<Kategori>();

            string sql = @"SELECT idKategori, namaKategori
                       FROM kategori
                       ORDER BY namaKategori";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            using (SqlDataReader dtr = cmd.ExecuteReader())
            {
                while (dtr.Read())
                {
                    list.Add(new Kategori
                    {
                        idKategori = dtr["idKategori"].ToString(),
                        namaKategori = dtr["namaKategori"].ToString()
                    });
                }
            }

            return list;
        }



        // 5. READ BY MERK: Search Car by Name/Brand
        public List<Kategori> ReadByNamaKategori(string nama)
        {
            List<Kategori> list = new List<Kategori>();

            try
            {
                // SQL using LIKE for partial matching
                string sql = @"SELECT idKategori, namaKategori
                               FROM kategori 
                               WHERE namaKategori LIKE @namaKategori
                               ORDER BY namaKategori";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    // Use wildcard % for search (e.g., "Avanza" becomes "%Avanza%")
                    cmd.Parameters.AddWithValue("@namaKategori", string.Format("%{0}%", nama));

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Kategori k = new Kategori();
                            k.idKategori = dtr["idKategori"].ToString();
                            k.namaKategori = dtr["namaKategori"].ToString();

                            list.Add(k);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNamaKategori Error: {0}", ex.Message);
            }

            return list;
        }
    }
}
