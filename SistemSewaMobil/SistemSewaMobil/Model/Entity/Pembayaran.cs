using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemSewaMobil.Model.Entity
{
    public class Pembayaran
    {
        public string idPembayaran { get; set; }
        public string idDetailSewa {  get; set; }
        public string metodePembayaran { get; set; }
        public DateTime tglPembayaran { get; set; }
        public int biayaServis { get; set; }
        public int diskon {  get; set; }
        public int totalPembayaran { get; set; }

    }
}
