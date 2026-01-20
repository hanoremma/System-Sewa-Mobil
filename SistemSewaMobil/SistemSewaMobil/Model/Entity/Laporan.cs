using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemSewaMobil.Model.Entity
{
    public class Laporan
    {
        public string idDetailSewa { get; set; }
        public DateTime tglPinjam { get; set; }
        public DateTime tglKembali { get; set; }
        public string statusPenyewaan { get; set; }
        public int totalBiayaSewa { get; set; }

        public string idPenyewa { get; set; }
        public string namaPenyewa { get; set; }
        public string alamatPenyewa { get; set; }
        public string noKtpPenyewa { get; set; }
        public string noHpPenyewa { get; set; }

        public string idPetugas { get; set; }
        public string namaPetugas { get; set; }

        public string idMobil { get; set; }
        public string noPolisi { get; set; }
        public string merkMobil { get; set; }

        public string idPembayaran { get; set; }
        public DateTime? tglPembayaran { get; set; }
        public string metodePembayaran { get; set; }
        public int biayaServis { get; set; }
        public int diskon { get; set; }
        public int totalPembayaran { get; set; }
        public string statusPembayaran { get; set; }

        public string statusBayar
        {
            get
            {
                return string.IsNullOrEmpty(idPembayaran)
                    ? "Belum Lunas"
                    : "Lunas";
            }
        }
    }
}
