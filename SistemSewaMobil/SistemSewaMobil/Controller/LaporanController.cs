using SistemSewaMobil.Model.Context;
using SistemSewaMobil.Model.Entity;
using SistemSewaMobil.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemSewaMobil.Controller
{
    public class LaporanController
    {
        public List<Laporan> GetLaporanLunas()
        {
            using (DbContext context = new DbContext())
            {
                LaporanRepository repo = new LaporanRepository(context);
                return repo.GetLaporanLunas();
            }
        }

        public int GetTotalPendapatanLunas()
        {
            using (DbContext context = new DbContext())
            {
                LaporanRepository repo = new LaporanRepository(context);
                return repo.GetTotalPendapatanLunas();
            }
        }
    }
}
