using System;
using System.Data;
using System.Data.SqlClient; 

namespace SistemSewaMobil.Model.Context
{
    public class DbContext : IDisposable
    {
        public SqlConnection Conn { get; private set; }

        public DbContext()
        {
            string connectionString =
                @"Data Source=192.168.1.56,1433;
                  Initial Catalog=sistemSewaMobil;
                  User ID=sa;
                  Password=Pass0912;
                  TrustServerCertificate=True;";

            Conn = new SqlConnection(connectionString);
            Conn.Open();
        }

        public void Dispose()
        {
            if (Conn != null && Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }
    }
        
}