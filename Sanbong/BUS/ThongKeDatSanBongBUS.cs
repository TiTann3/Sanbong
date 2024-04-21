using DoAnC_.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.BUS
{
    public class ThongKeDatSanBongBUS
    {
        private ThongKeDatSanBongDAO dao = new ThongKeDatSanBongDAO();

        public DataTable LayDanhSachDonDatSanBong()
        {
            return dao.LayDanhSachDonDatSanBong();
        }
    }
}
