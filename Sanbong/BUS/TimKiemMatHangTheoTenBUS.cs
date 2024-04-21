using DoAnC_.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.BUS
{
    public class TimKiemMatHangTheoTenBUS
    {
        private TimKiemMatHangTheoTenDAO dao = new TimKiemMatHangTheoTenDAO();

        public DataTable TimKiemMatHangTheoTen(string tenMatHang)
        {
            return dao.TimKiemMatHangTheoTen(tenMatHang);
        }
    }
}
