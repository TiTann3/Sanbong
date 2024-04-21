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

namespace DoAnC_.BUS
{
    public class HoaDonBUS
    {
        public static ArrayList getAllHoaDon()
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = HoaDonDAO.getAllHoaDon();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    DateTime ngayTao = Convert.ToDateTime(row["ngayTao"]);
                    string tenKhachHang = row["tenKhachHang"].ToString();
                    bool daThanhToan = Convert.ToBoolean(row["daThanhToan"]);
                    dataList.Add(new HoaDon(id, ngayTao, tenKhachHang, daThanhToan));
                }
            }
            catch (MySqlException e)
            {

            }
            return dataList;
        }

        public static bool addHoaDon(HoaDon hoaDon)
        {
            bool kt = true;

            try
            {
                HoaDonDAO.addHoaDon(hoaDon.ngayTao, hoaDon.tenKhachHang, hoaDon.daThanhToan);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static HoaDon getHoaDon(int id)
        {
            HoaDon hoaDon = null;

            try
            {
                DataSet tam = HoaDonDAO.getHoaDon(id);
                DataRow dataRow = tam.Tables[0].Rows[0];
                DateTime ngayTao = Convert.ToDateTime(dataRow["ngayTao"]);
                string tenKhachHang = dataRow["tenKhachHang"].ToString();
                bool daThanhToan = Convert.ToBoolean(dataRow["daThanhToan"]);
                hoaDon = new HoaDon(id, ngayTao, tenKhachHang, daThanhToan);

            }
            catch (MySqlException e)
            {

            }
            return hoaDon;
        }

        public static bool deleteHoaDon(int id)
        {
            bool kt = true;
            try
            {
                HoaDonDAO.deleteHoaDon(id);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static HoaDon getLastHoaDon()
        {
            HoaDon hoaDon = null;

            try
            {
                DataSet tam = HoaDonDAO.getLastHoaDon();
                DataRow dataRow = tam.Tables[0].Rows[0];
                int id = Convert.ToInt32(dataRow["id"]);
                DateTime ngayTao = Convert.ToDateTime(dataRow["ngayTao"]);
                string tenKhachHang = dataRow["tenKhachHang"].ToString();
                bool daThanhToan = Convert.ToBoolean(dataRow["daThanhToan"]);
                hoaDon = new HoaDon(id, ngayTao, tenKhachHang, daThanhToan);

            }
            catch (MySqlException e)
            {

            }
            return hoaDon;
        }

        public static bool updateHoaDon(HoaDon hoaDon)
        {
            bool kt = true;
            try
            {
                HoaDonDAO.updateHoaDon(hoaDon.id, hoaDon.tenKhachHang, hoaDon.daThanhToan);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }
    }
}
