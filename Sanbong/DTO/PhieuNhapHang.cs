using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DTO
{
    public class PhieuNhapHang
    {
        public PhieuNhapHang(int id, int idMatHang, DateTime ngayNhap, int soLuong, double tongTien)
        {
            this.id = id;
            this.idMatHang = idMatHang;
            this.ngayNhap = ngayNhap;
            this.soLuong = soLuong;
            this.tongTien = tongTien;
        }
        public PhieuNhapHang(int idMatHang, DateTime ngayNhap, int soLuong, double tongTien)
        {
            this.idMatHang = idMatHang;
            this.ngayNhap = ngayNhap;
            this.soLuong = soLuong;
            this.tongTien = tongTien;
        }

        public int id { get; }
        public int idMatHang { get; set; }
        public DateTime ngayNhap { get; set; }
        public int soLuong { get; set; }
        public double tongTien { get; set; }
    }
}
