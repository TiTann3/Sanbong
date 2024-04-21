using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DoAnC_.DAO;
using System.Threading.Tasks;
using DoAnC_.DAO;

namespace DoAnC_.BUS
{
    public class TimKiemHoaDonTheoNgayBUS
    {
        private TimKiemHoaDonTheoNgayDAO dao = new TimKiemHoaDonTheoNgayDAO();

        public DataTable TimKiemHoaDonTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return dao.TimKiemHoaDonTheoNgay(tuNgay, denNgay);
        }
    }
}
