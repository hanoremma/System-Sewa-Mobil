using System;
using System.Data;
using System.Data.SqlClient; 
using System.Configuration;

namespace SistemSewaMobil.Model.Context
{
    public class DbContext : IDisposable
    {
        public SqlConnection Conn { get; private set; }

        public DbContext()
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["DB"].ConnectionString;


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