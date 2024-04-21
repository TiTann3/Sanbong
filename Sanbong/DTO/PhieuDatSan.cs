using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DTO
{
    public class PhieuDatSan
    {
        public PhieuDatSan(int id, int idSanBong, DateTime thoiGianBatDau, double soGioDat, DateTime thoiGianKetThuc, double donGia, int idHoaDon)
        {
            this.id = id;
            this.idSanBong = idSanBong;
            this.thoiGianBatDau = thoiGianBatDau;
            this.soGioDat = soGioDat;
            this.thoiGianKetThuc = thoiGianKetThuc;
            this.donGia = donGia;
            this.idHoaDon = idHoaDon;

        }

        public int id { get; }
        public int idSanBong { get; set; }
        public DateTime thoiGianBatDau { get; set; }
        public double soGioDat { get; set; }
        public DateTime thoiGianKetThuc { get; set; }
        public double donGia { get; set; }
        public int idHoaDon { get; set; }

    }
}
