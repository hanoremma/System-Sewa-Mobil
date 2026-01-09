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
                @"Data Source=EMA_PC\SQLEXPRESS;
                Initial Catalog=sistemSewaMobil;
                Integrated Security=True;
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