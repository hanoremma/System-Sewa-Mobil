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
        public string namaPenyewa { get; set; }
        public string alamatPenyewa { get; set; }
        public string noKtpPenyewa { get; set; }
        public string noHpPenyewa { get; set; }
        public string idPetugas { get; set; }
        public string namaPetugas { get; set; }
        public string idMobil { get; set; }
        public string merkMobil { get; set; }
        public string noPolisi { get; set; }
        public DateTime tglPinjam { get; set; }
        public DateTime tglKembali { get; set; }
        public string statusPenyewaan { get; set; }
        public int totalBiaya { get; set; }

    }
}
