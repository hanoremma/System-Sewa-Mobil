using SistemSewaMobil.Model.Context;
using SistemSewaMobil.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemSewaMobil.Model.Repository
{
    public class PenyewaRepository
    {
        private SqlConnection _conn;

        // Constructor: Menerima context database
        public PenyewaRepository(DbContext context)
        {
            _conn = context.Conn;
        }
    
    public int Create(Penyewa penyewa)
        {
            int result = 0;
            // Perintah SQL Insert
            string sql = @"INSERT INTO penyewa (namaPenyewa, alamatPenyewa, noKtpPenyewa, noHpPenyewa) 
                           VALUES (@namaPenyewa, @alamatPenyewa, @noKtpPenyewa, @noHpPenyewa)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@namaPenyewa", penyewa.namaPenyewa);
                cmd.Parameters.AddWithValue("@alamatPenyewa", penyewa.alamatPenyewa);
                cmd.Parameters.AddWithValue("@noKtpPenyewa", penyewa.noKtpPenyewa);
                cmd.Parameters.AddWithValue("@noHpPenyewa", penyewa.noHpPenyewa);

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
    public int Update(Penyewa penyewa)
        {
            int result = 0;

            string sql = @"UPDATE penyewa SET
                    namaPenyewa = @namaPenyewa,
                    alamatPenyewa = @alamatPenyewa,
                    noKtpPenyewa = @noKtpPenyewa,
                    noHpPenyewa = @noHpPenyewa
                   WHERE idPenyewa = @idPenyewa";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idPenyewa", penyewa.idPenyewa);
                cmd.Parameters.AddWithValue("@namaPenyewa", penyewa.namaPenyewa);
                cmd.Parameters.AddWithValue("@alamatPenyewa", penyewa.alamatPenyewa);
                cmd.Parameters.AddWithValue("@noKtpPenyewa", penyewa.noKtpPenyewa);
                cmd.Parameters.AddWithValue("@noHpPenyewa", penyewa.noHpPenyewa);

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
        public int Delete(Penyewa penyewa)
        {
            int result = 0;
            string sql = @"DELETE FROM penyewa WHERE idPenyewa = @idPenyewa";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idPenyewa", penyewa.idPenyewa);

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
        public List<Penyewa> ReadAll()
        {
            List<Penyewa> list = new List<Penyewa>();

            string sql = @"SELECT idPenyewa, namaPenyewa, alamatPenyewa, noKtpPenyewa, noHpPenyewa
                       FROM penyewa
                       ORDER BY namaPenyewa";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            using (SqlDataReader dtr = cmd.ExecuteReader())
            {
                while (dtr.Read())
                {
                    list.Add(new Penyewa
                    {
                        idPenyewa = dtr["idPenyewa"].ToString(),
                        namaPenyewa = dtr["namaPenyewa"].ToString(),
                        alamatPenyewa = dtr["alamatPenyewa"].ToString(),
                        noKtpPenyewa = dtr["noKtpPenyewa"].ToString(),
                        noHpPenyewa = dtr["noHpPenyewa"].ToString()
                    });
                }
            }

            return list;
        }
        public List<Penyewa> ReadByNamaPenyewa(string namapenyewa)
        {
            List<Penyewa> list = new List<Penyewa>();

            try
            {
                // SQL using LIKE for partial matching
                string sql = @"SELECT idPenyewa, namaPenyewa, alamatPenyewa, noKtpPenyewa, noHpPenyewa
                               FROM penyewa
                               WHERE namaPenyewa LIKE @namaPenyewa
                               ORDER BY namaPenyewa";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    // Use wildcard % for search (e.g., "Avanza" becomes "%Avanza%")
                    cmd.Parameters.AddWithValue("@namaPenyewa", string.Format("%{0}%", namapenyewa));

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Penyewa p = new Penyewa();
                            p.idPenyewa = dtr["idPenyewa"].ToString();
                            p.namaPenyewa = dtr["namaPenyewa"].ToString();
                            p.alamatPenyewa = dtr["alamatPenyewa"].ToString();
                            p.noKtpPenyewa = dtr["noKtpPenyewa"].ToString();
                            p.noHpPenyewa = dtr["noHpPenyewa"].ToString();

                            list.Add(p);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNamaPenyewa Error: {0}", ex.Message);
            }

            return list;
        }
    }
}
