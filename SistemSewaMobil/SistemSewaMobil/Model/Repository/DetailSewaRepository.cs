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
            string sql = @"INSERT INTO detailSewa (idPenyewa, idPetugas, idMobil, tglPinjam, tglKembali, statusPenyewaan, totalBiaya) 
                           VALUES (@idPenyewa, @idPetugas, @idMobil, @tglPinjma, @tglKembali, @statusPenyewaan, @totalBiaya)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                // Assuming the object passed to the function is named 'mobil'
                // Example: public int Create(Mobil mobil)

                cmd.Parameters.AddWithValue("@idPenyewa", detailsewa.idPenyewa);
                cmd.Parameters.AddWithValue("@idPetugas", detailsewa.idPetugas);
                cmd.Parameters.AddWithValue("@idMobil", detailsewa.idMobil);
                cmd.Parameters.AddWithValue("@tglPinjam", detailsewa.tglPinjam);
                cmd.Parameters.AddWithValue("@tglPinjam", detailsewa.tglPinjam);
                cmd.Parameters.AddWithValue("@tglPinjam", detailsewa.tglPinjam);
                cmd.Parameters.AddWithValue("@tglPinjam", detailsewa.tglPinjam);

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
    }
}
