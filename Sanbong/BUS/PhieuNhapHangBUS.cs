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
    public class PhieuNhapHangBUS
    {
        public static bool addPhieuNhapHang(PhieuNhapHang phieuNhapHang)
        {
            bool kt = true;

            try
            {
                PhieuNhapHangDAO.addPhieuNhapHang(phieuNhapHang.idMatHang, phieuNhapHang.ngayNhap,
                    phieuNhapHang.soLuong, phieuNhapHang.tongTien);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static ArrayList getAllPhieuNhapHang()
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = PhieuNhapHangDAO.getAllPhieuNhapHang();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    int idMatHang = Convert.ToInt32(row["idMatHang"]);
                    DateTime ngayNhap = Convert.ToDateTime(row["ngayNhap"]);
                    int soLuong = Convert.ToInt32(row["soLuong"]);
                    double tongTien = Convert.ToSingle(row["TongTien"]);
                    PhieuNhapHang phieuNhapHang = new PhieuNhapHang(id, idMatHang, ngayNhap, soLuong, tongTien);
                    dataList.Insert(0, phieuNhapHang);
                }
            }
            catch (MySqlException e)
            {

            }

            return dataList;
        }

        public static bool deletePhieuNhapHang(int id)
        {
            bool kt = true;
            try
            {
                PhieuNhapHangDAO.deletePhieuNhapHang(id);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }
    }
}
