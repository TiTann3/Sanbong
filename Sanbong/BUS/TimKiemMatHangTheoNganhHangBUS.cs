using DoAnC_.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.BUS
{
    public class TimKiemMatHangTheoNganhHangBUS
    {
        private TimKiemMatHangTheoNganhHangDAO dao = new TimKiemMatHangTheoNganhHangDAO();

        public DataTable TimKiemMatHangTheoNganhHang(string tenNganhHang)
        {
            return dao.TimKiemMatHangTheoNganhHang(tenNganhHang);
        }
    }
}
