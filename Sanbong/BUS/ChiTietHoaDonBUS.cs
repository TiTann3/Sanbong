﻿using DoAnC_.DAO;
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
    public class ChiTietHoaDonBUS
    {
        public static bool addChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            bool kt = true;

            try
            {
                ChiTietHoaDonDAO.addChiTietHoaDon(chiTietHoaDon.idHoaDon, chiTietHoaDon.idMatHang,
                    chiTietHoaDon.soLuong, chiTietHoaDon.donGia);

            }
            catch (MySqlException e)
            {
                kt = false;

            }
            return kt;
        }

        public static ArrayList getAllChiTietHoaDon()
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = ChiTietHoaDonDAO.getAllChiTietHoaDon();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {

                    int id = Convert.ToInt32(row["id"]);
                    int idHoaDon = Convert.ToInt32(row["idHoaDon"]);
                    int idMatHang = Convert.ToInt32(row["idMatHang"]);
                    int soLuong = Convert.ToInt32(row["soLuong"]);
                    double donGia = Convert.ToSingle(row["donGia"]);
                    dataList.Add(new ChiTietHoaDon(id, idHoaDon, idMatHang, soLuong, donGia));

                }
            }
            catch (MySqlException e)
            {

            }
            return dataList;
        }

        public static ArrayList getAllChiTietHoaDon(int idHoaDon)
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = ChiTietHoaDonDAO.getAllChiTietHoaDon(idHoaDon);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {

                    int id = Convert.ToInt32(row["id"]);
                    int idMatHang = Convert.ToInt32(row["idMatHang"]);
                    int soLuong = Convert.ToInt32(row["soLuong"]);
                    double donGia = Convert.ToSingle(row["donGia"]);
                    dataList.Add(new ChiTietHoaDon(id, idHoaDon, idMatHang, soLuong, donGia));

                }
            }
            catch (MySqlException e)
            {

            }
            return dataList;
        }

        public static bool deleteChiTietHoaDon(int id)
        {
            bool kt = true;
            try
            {
                ChiTietHoaDonDAO.deleteChiTietHoaDon(id);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }
        public static bool deleteChiTietHoaDonHuySan(int idHoaDon)
        {
            bool kt = true;
            try
            {
                ChiTietHoaDonDAO.deleteChiTietHoaDonHuySan(idHoaDon);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static bool updateChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            bool kt = true;
            try
            {
                ChiTietHoaDonDAO.updateChiTietHoaDon(chiTietHoaDon.id, chiTietHoaDon.idHoaDon, chiTietHoaDon.idMatHang,
                    chiTietHoaDon.soLuong, chiTietHoaDon.donGia);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }
    }
}
