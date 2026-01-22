using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemSewaMobil.Model.Entity
{
    public class Mobil
    {
        public string idMobil { get; set; }
        public string idKategori { get; set; } // Tambahkan ini
        public string namaKategori { get; set; }
        public string noPolisi { get; set; }
        public string merkMobil { get; set; }
        public string tahunMobil { get; set; }
        public string statusKetersediaan { get; set; }
        public int hargaSewa { get; set; }
    }
}
