using DoAnC_.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.BUS
{
    public class TimKiemHoaDonTheoTenKHBUS
    {
        private TimKiemHoaDonTheoTenKHDAO dao = new TimKiemHoaDonTheoTenKHDAO();

        public DataTable TimKiemHoaDonTheoTenKH(string tenKhachHang)
        {
            return dao.TimKiemHoaDonTheoTenKH(tenKhachHang);
        }
    }
}
