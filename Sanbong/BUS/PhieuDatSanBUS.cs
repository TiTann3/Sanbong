using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DoAnC_.DAO;
using DoAnC_.DTO;
using System.Collections;

namespace DoAnC_.BUS
{
    public class PhieuDatSanBUS
    {
        public static ArrayList getAllPhieuDatSan(int idSanBong)
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = PhieuDatSanDAO.getAllPhieuDatSan(idSanBong);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    DateTime thoiGianBatDau = Convert.ToDateTime(row["thoiGianBatDau"]);
                    double soGioDat = Convert.ToSingle(row["soGioDat"]);
                    DateTime thoiGianKetThuc = Convert.ToDateTime(row["thoiGianKetThuc"]);
                    double donGia = Convert.ToSingle(row["donGia"]);
                    int idHoaDon = Convert.ToInt32(row["idHoaDon"]);

                    PhieuDatSan phieuDatSan = new PhieuDatSan(id, idSanBong, thoiGianBatDau, soGioDat, thoiGianKetThuc, donGia, idHoaDon);
                    dataList.Add(phieuDatSan);
                }
            }
            catch (MySqlException e)
            {

            }
            return dataList;
        }

        public static PhieuDatSan getLatestPhieuDatSan(int idSanBong)
        {
            PhieuDatSan phieuDatSan = null;
            try
            {
                DataSet dataSet = PhieuDatSanDAO.getAllPhieuDatSan(idSanBong);

                DataRow row = dataSet.Tables[0].Rows[dataSet.Tables[0].Rows.Count - 1];

                int id = Convert.ToInt32(row["id"]);
                DateTime thoiGianBatDau = Convert.ToDateTime(row["thoiGianBatDau"]);
                double soGioDat = Convert.ToSingle(row["soGioDat"]);
                DateTime thoiGianKetThuc = Convert.ToDateTime(row["thoiGianKetThuc"]);
                double donGia = Convert.ToSingle(row["donGia"]);
                int idHoaDon = Convert.ToInt32(row["idHoaDon"]);

                phieuDatSan = new PhieuDatSan(id, idSanBong, thoiGianBatDau, soGioDat,thoiGianKetThuc, donGia, idHoaDon);
            }
            catch (MySqlException e)
            {

            }
            return phieuDatSan;
        }

        public static ArrayList getAllPhieuDatSan()
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = PhieuDatSanDAO.getAllPhieuDatSan();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    int idSanBong = Convert.ToInt32(row["idSanBong"]);
                    DateTime thoiGianBatDau = Convert.ToDateTime(row["thoiGianBatDau"]);
                    double soGioDat = Convert.ToSingle(row["soGioDat"]);
                    DateTime thoiGianKetThuc = Convert.ToDateTime(row["thoiGianKetThuc"]);
                    double donGia = Convert.ToSingle(row["donGia"]);
                    int idHoaDon = Convert.ToInt32(row["idHoaDon"]);

                    PhieuDatSan phieuDatSan = new PhieuDatSan(id, idSanBong, thoiGianBatDau, soGioDat, thoiGianKetThuc, donGia, idHoaDon);
                    dataList.Add(phieuDatSan);
                }
            }
            catch (MySqlException e)
            {

            }
            return dataList;
        }


        public static bool addPhieuDatSan(PhieuDatSan phieuDatSan)
        {
            bool kt = true;
            try
            {
                PhieuDatSanDAO.addPhieuDatSan(phieuDatSan.idSanBong, phieuDatSan.thoiGianBatDau,
                    phieuDatSan.soGioDat, phieuDatSan.thoiGianKetThuc, phieuDatSan.donGia, phieuDatSan.idHoaDon);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static bool deletePhieuDatSan(int id)
        {
            bool kt = true;
            try
            {
                PhieuDatSanDAO.deletePhieuDatSan(id);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static bool updatePhieuDatSan(PhieuDatSan phieuDatSan)
        {
            bool kt = true;
            try
            {
                PhieuDatSanDAO.updatePhieuDatSan(phieuDatSan.id, phieuDatSan.idSanBong, phieuDatSan.thoiGianBatDau,
                    phieuDatSan.soGioDat, phieuDatSan.thoiGianKetThuc, phieuDatSan.donGia, phieuDatSan.idHoaDon);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }
    }
}
