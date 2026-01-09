using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemSewaMobil.Model.Entity
{
    public class DetailSewa
    {
        public string idDetailSewa { get; set; }
        public string idPenyewa { get; set; }
        public string idPetugas { get; set; }
        public string idMobil { get; set; }
        public string tglPinjam { get; set; }
        public string tglKembali { get; set; }
        public string statusPenyewaan { get; set; }
        public string totalBiaya { get; set; }

    }
}
