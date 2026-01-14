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
            string sql = @"INSERT INTO detailSewa (idPenyewa, idPetugas, idMobil, tglPinjam, tglKembali, statusPenyewaan) 
                           VALUES (@idPenyewa, @idPetugas, @idMobil, @tglPinjma, @tglKembali, @statusPenyewaan)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                // Assuming the object passed to the function is named 'mobil'
                // Example: public int Create(Mobil mobil)

                cmd.Parameters.AddWithValue("@idPenyewa", detailsewa.idPenyewa);
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
                    idPenyewa = @idKategori,
                    idPetugas = @idPetugas,
                    idMobil = @idMobil,
                    tglPinjam = @tglPinjam,
                    tglKembali = @tglKembali,
                    statusPenyewaan = @statusPenyewaan
                     WHERE idDetailSewa = @idDetailSewa";   

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
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
        public int Delete(Penyewa penyewa)
        {
            int result = 0;
            string sql = @"DELETE FROM penyewa WHERE idMobil = @idMobil";

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
    }
}
