using DoAnC_.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.BUS
{
    public class TimKiemPhieuDatSanTheoDonGiaBUS
    {
        private TimKiemPhieuDatSanTheoDonGiaDAO dao = new TimKiemPhieuDatSanTheoDonGiaDAO();

        public DataTable TimKiemPhieuDatSanTheoDonGia(decimal giaTu, decimal giaDen)
        {
            return dao.TimKiemPhieuDatSanTheoDonGia(giaTu, giaDen);
        }
    }
}
