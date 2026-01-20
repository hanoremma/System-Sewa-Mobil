using SistemSewaMobil.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemSewaMobil.Model.Repository
{
    public class LaporanRepository
    {
        private SqlConnection _conn;

        // Constructor: Menerima context database
        public LaporanRepository(DbContext context)
        {
            _conn = context.Conn;
        }
    }
}
