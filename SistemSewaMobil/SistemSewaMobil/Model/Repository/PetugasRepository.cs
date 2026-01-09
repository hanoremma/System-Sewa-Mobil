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
    public class PetugasRepository
    {
        private SqlConnection _conn;

        // Constructor: Menerima context database
        public PetugasRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(Petugas petugas)
        {
            int result = 0;
            // Perintah SQL Insert
            string sql = @"INSERT INTO petugas (idPetugas, namaPetugas, noHpPetugas, alamatPetugas) 
                           VALUES (@idPetugas, @namaPetugas, @noHpPetugas, @alamatPetugas)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idPetugas", petugas.idPetugas);
                cmd.Parameters.AddWithValue("@namaPetugas", petugas.namaPetugas);
                cmd.Parameters.AddWithValue("@noHpPetugas", petugas.noHpPetugas);
                cmd.Parameters.AddWithValue("@alamatPetugas", petugas.alamatPetugas);

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
        public int Update(Petugas petugas)
        {
            int result = 0;

            string sql = @"UPDATE petugas SET
                    namaPetugas = @namaPetugas,
                    noHpPetugas = @noHpPetugas,
                    alamatPetugas = @alamatPetugas,
                   WHERE idPetugas = @idPetugas";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idPetugas", petugas.idPetugas);
                cmd.Parameters.AddWithValue("@namaPetugas", petugas.namaPetugas);
                cmd.Parameters.AddWithValue("@noHpPetugas", petugas.noHpPetugas);
                cmd.Parameters.AddWithValue("@alamatPetugas", petugas.alamatPetugas);

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
        public int Delete(Petugas petugas)
        {
            int result = 0;
            string sql = @"DELETE FROM petugas WHERE idPetugas = @idPetugas";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idPetugas", petugas.idPetugas);

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
        public List<Petugas> ReadAll()
        {
            List<Petugas> list = new List<Petugas>();

            string sql = @"SELECT idPetugas, namaPetugas, noHpPetugas, alamatPetugas
                       FROM petugas
                       ORDER BY namaPetugas";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            using (SqlDataReader dtr = cmd.ExecuteReader())
            {
                while (dtr.Read())
                {
                    list.Add(new Petugas
                    {
                        idPetugas = dtr["idPetugas"].ToString(),
                        namaPetugas = dtr["namaPetugas"].ToString(),
                        noHpPetugas = dtr["noHpPetugas"].ToString(),
                        alamatPetugas = dtr["alamatPetugas"].ToString()
                    });
                }
            }

            return list;
        }
        public List<Petugas> ReadByNamaPetugas(string nama)
        {
            List<Petugas> list = new List<Petugas>();

            try
            {
                // SQL using LIKE for partial matching
                string sql = @"SELECT idPetugas, namaPetugas, noHpPetugas, alamatPetugas,
                               FROM petugas
                               WHERE namaPetugas LIKE @namaPetugas
                               ORDER BY namaPetugas";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    // Use wildcard % for search (e.g., "Avanza" becomes "%Avanza%")
                    cmd.Parameters.AddWithValue("@namaPetugas", string.Format("%{0}%", nama));

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Petugas p = new Petugas();
                            p.idPetugas = dtr["idPenyewa"].ToString();
                            p.namaPetugas = dtr["namaPenyewa"].ToString();
                            p.noHpPetugas = dtr["alamatPenyewa"].ToString();
                            p.alamatPetugas = dtr["noKtpPenyewa"].ToString();

                            list.Add(p);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNamaPetugas Error: {0}", ex.Message);
            }

            return list;
        }
    }
}
