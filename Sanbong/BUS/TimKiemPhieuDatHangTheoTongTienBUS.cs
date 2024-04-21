using DoAnC_.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.BUS
{
    public class TimKiemPhieuDatHangTheoTongTienBUS
    {
        private TimKiemPhieuDatHangTheoTongTienDAO dao = new TimKiemPhieuDatHangTheoTongTienDAO();

        public DataTable TimKiemPhieuDatHangTheoTongTien(decimal giaTu, decimal giaDen)
        {
            return dao.TimKiemPhieuDatHangTheoTongTien(giaTu, giaDen);
        }
    }
}
