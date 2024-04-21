using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Threading.Tasks;
using DoAnC_.DAO;
using DoAnC_.DTO;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace BUS
{
    public class UserBUS
    {
        public static bool isExist(String username, String password)
        {
            try
            {
                if (UserDAO.getUser(username, password) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public static DTO.User getUser(String username, String password)
        {
            if (isExist(username, password))
            {
                return UserDAO.getUser(username, password);
            }
            else
            {
                return null;
            }
        }

        public bool CheckUsernameExists(string username)
        {
            return UserDAO.CheckUsernameExists(username);
        }

        public bool RegisterUser(string username, string password, bool isAdmin, DateTime dateCreate)
        {
            DTO.User user = new DTO.User
            {
                userName = username,
                passWord = password,
                isAdmin = isAdmin,
                dateCreate = dateCreate
            };

            return UserDAO.InsertUser(user);
        }
    }

}
