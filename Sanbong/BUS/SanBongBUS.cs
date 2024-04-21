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
    public class SanBongBUS
    {
        public static bool addSan(String tenSan)
        {
            bool kt = true;

            try
            {
                SanBongDAO.addSan(tenSan);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static ArrayList getAllSan()
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = SanBongDAO.getAllSan();
                ArrayList phieuDatSanBongList;
                DateTime thoiGianBatDau, thoiGianKetThuc;
                int soSanhKetThuc, soSanhBatDau;
                DateTime now = DateTime.Now;
                bool dangThue;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    String tenSan = row["tenSan"].ToString();
                    int idSan = Convert.ToInt32(row["id"]);
                    dangThue = false;

                    phieuDatSanBongList = PhieuDatSanBUS.getAllPhieuDatSan(idSan);
                    foreach (PhieuDatSan phieuDatSan in phieuDatSanBongList)
                    {
                        thoiGianBatDau = phieuDatSan.thoiGianBatDau;

                        thoiGianKetThuc = thoiGianBatDau.AddHours((double)phieuDatSan.soGioDat);

                        soSanhKetThuc = DateTime.Compare(thoiGianKetThuc, now);
                        soSanhBatDau = DateTime.Compare(thoiGianBatDau, now);

                        if (soSanhBatDau < 0 && soSanhKetThuc > 0)
                        {
                            dangThue = true;
                            break;
                        }
                    }
                    SanBong sanBong = new SanBong(idSan, tenSan, dangThue);

                    dataList.Insert(0, sanBong);

                }
            }
            catch (MySqlException e)
            {

            }

            return dataList;
        }

        public static bool deleteSan(int id)
        {
            bool kt = true;
            try
            {
                SanBongDAO.deleteSan(id);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static bool updateTenSan(int id, String tenSan)
        {
            bool kt = true;
            try
            {
                SanBongDAO.updateTenSan(id, tenSan);
            }
            catch (MySqlException e)
            {
                kt = false;
            }
            return kt;
        }
    }
}
