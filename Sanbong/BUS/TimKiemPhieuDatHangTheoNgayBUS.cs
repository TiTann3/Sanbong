using DoAnC_.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.BUS
{
    public class TimKiemPhieuDatHangTheoNgayBUS
    {
        private TimKiemPhieuDatHangTheoNgayDAO dao = new TimKiemPhieuDatHangTheoNgayDAO();

        public DataTable TimKiemPhieuDatHangTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return dao.TimKiemPhieuDatHangTheoNgay(tuNgay, denNgay);
        }
    }
}
