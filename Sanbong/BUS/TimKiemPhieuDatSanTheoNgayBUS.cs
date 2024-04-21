using DoAnC_.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.BUS
{
    public class TimKiemPhieuDatSanTheoNgayBUS
    {
        private TimKiemPhieuDatSanTheoNgayDAO dao = new TimKiemPhieuDatSanTheoNgayDAO();

        public DataTable TimKiemPhieuDatSanTheoThoiGian(DateTime tuNgay, DateTime denNgay)
        {
            return dao.TimKiemPhieuDatSanTheoThoiGian(tuNgay, denNgay);
        }
    }
}
