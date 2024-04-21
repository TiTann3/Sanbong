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
    public class NganhHangBUS
    {
        public static bool addNganhHang(string ten)
        {
            bool kt = true;

            try
            {
                NganhHangDAO.addNganhHang(ten);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static ArrayList getAllNganhHang()
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = NganhHangDAO.getAllNganhHang();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    String tenNganhHang = row["tenNganhHang"].ToString();
                    int id = Convert.ToInt32(row["id"]);
                    NganhHang nganhHang = new NganhHang(id, tenNganhHang);
                    dataList.Insert(0, nganhHang);
                }
            }
            catch (MySqlException e)
            {

            }

            return dataList;
        }

        public static bool updateTenNganhHang(int id, String tenNganhHang)
        {
            bool kt = true;
            try
            {
                NganhHangDAO.updateTenNganhHang(id, tenNganhHang);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static bool deleteNganhHang(int id)
        {
            bool kt = true;
            try
            {
                NganhHangDAO.deleteNganhHang(id);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }
    }
}
