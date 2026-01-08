using System;
using System.Data;
using System.Data.SqlClient; // Ini library utamanya

namespace SistemSewaMobil.Model.Context
{
    public class DbContext : IDisposable
    {
        // Variabel private untuk menyimpan koneksi
        private SqlConnection _conn;

        // Property untuk memanggil koneksi dari luar
        public SqlConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        // Method untuk membuka koneksi ke SQL Server
        private SqlConnection GetOpenConnection()
        {
            SqlConnection conn = null;

            try
            {
                // --- BAGIAN INI HARUS DISESUAIKAN DENGAN SSMS KAMU ---
                // Data Source = Nama Server di SSMS kamu
                // Initial Catalog = Nama Database yang kamu buat
                // Integrated Security = True (Artinya pakai login Windows, tidak perlu user/pass)

                //string connectionString = @"Data Source=NAMA_SERVER_KAMU;Initial Catalog=NAMA_DATABASE_KAMU;Integrated Security=True";

                // Contoh nyata:
                string connectionString = @"C:\Users\Brian\source\repos\System-Sewa-Mobil\DataBase\sistemSewaMobil.sql";

                conn = new SqlConnection(connectionString);
                conn.Open(); // Membuka koneksi
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return conn;
        }

        // Method untuk membersihkan memori (Menutup koneksi)
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }
    }
}