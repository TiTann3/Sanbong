using DoAnC_.DAO;
using DoAnC_.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnC_.BUS
{
    public  class InHoaDonBUS
    {
        private InHoaDonDAO dao = new InHoaDonDAO();
        public DataTable getDauHoaDon(int idHoaDon)
        {
            return dao.getDauHoaDon(idHoaDon);
        }

        public DataTable getCuoiHoaDon(int idHoaDon)
        {
            return dao.getCuoiHoaDon(idHoaDon);
        }
        public DataTable getTongDonGia(int idHoaDon)
        {
            return dao.getTongDonGia(idHoaDon);
        }
    }
}
