using SistemSewaMobil.Model.Context;
using SistemSewaMobil.Model.Entity;
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

        public LaporanRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public List<Laporan> GetLaporanLunas()
        {
            List<Laporan> list = new List<Laporan>();

            string sql = @"
                SELECT
                    ds.idDetailSewa,
                    ds.tglPinjam,
                    ds.tglKembali,
                    ds.statusPenyewaan,
                    ds.totalBiaya AS totalBiayaSewa,

                    p.idPenyewa,
                    p.namaPenyewa,
                    p.alamatPenyewa,
                    p.noKtpPenyewa,
                    p.noHpPenyewa,

                    pt.idPetugas,
                    pt.namaPetugas,

                    m.idMobil,
                    m.noPolisi,
                    m.merkMobil,

                    pb.idPembayaran,
                    pb.tglPembayaran,
                    pb.metodePembayaran,
                    pb.biayaServis,
                    pb.diskon,
                    pb.totalPembayaran,
                    pb.statusPembayaran

                FROM detailSewa ds
                JOIN penyewa p   ON ds.idPenyewa = p.idPenyewa
                JOIN petugas pt  ON ds.idPetugas = pt.idPetugas
                JOIN mobil m     ON ds.idMobil = m.idMobil
                JOIN pembayaran pb ON pb.idDetailSewa = ds.idDetailSewa

                WHERE pb.statusPembayaran = 'Lunas'
                ORDER BY pb.tglPembayaran DESC";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            using (SqlDataReader dtr = cmd.ExecuteReader())
            {
                while (dtr.Read())
                {
                    list.Add(new Laporan
                    {
                        idDetailSewa = dtr["idDetailSewa"].ToString(),
                        tglPinjam = Convert.ToDateTime(dtr["tglPinjam"]),
                        tglKembali = Convert.ToDateTime(dtr["tglKembali"]),
                        statusPenyewaan = dtr["statusPenyewaan"].ToString(),
                        totalBiayaSewa = Convert.ToInt32(dtr["totalBiayaSewa"]),

                        idPenyewa = dtr["idPenyewa"].ToString(),
                        namaPenyewa = dtr["namaPenyewa"].ToString(),
                        alamatPenyewa = dtr["alamatPenyewa"].ToString(),
                        noKtpPenyewa = dtr["noKtpPenyewa"].ToString(),
                        noHpPenyewa = dtr["noHpPenyewa"].ToString(),

                        idPetugas = dtr["idPetugas"].ToString(),
                        namaPetugas = dtr["namaPetugas"].ToString(),

                        idMobil = dtr["idMobil"].ToString(),
                        noPolisi = dtr["noPolisi"].ToString(),
                        merkMobil = dtr["merkMobil"].ToString(),

                        idPembayaran = dtr["idPembayaran"].ToString(),
                        tglPembayaran = Convert.ToDateTime(dtr["tglPembayaran"]),
                        metodePembayaran = dtr["metodePembayaran"].ToString(),
                        biayaServis = Convert.ToInt32(dtr["biayaServis"]),
                        diskon = Convert.ToInt32(dtr["diskon"]),
                        totalPembayaran = Convert.ToInt32(dtr["totalPembayaran"]),
                        statusPembayaran = dtr["statusPembayaran"].ToString()
                    });
                }
            }

            return list;
        }

        public int GetTotalPendapatanLunas()
        {
            string sql = @"
                SELECT ISNULL(SUM(totalPembayaran), 0)
                FROM pembayaran
                WHERE statusPembayaran = 'Lunas'";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
