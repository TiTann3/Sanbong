using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;
using DoAnC_.DAO;
using DoAnC_.DTO;

namespace DAO
{
    public class UserDAO
    {
        public static DTO.User getUser(String userName, String passWord)
        {
            DTO.User user = null;
            // Kết nối đến cơ sở dữ liệu MySQL
            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
            {
                conn.Open();
                String query = "select * from user where userName = @username and passWord = @password";
                MySqlCommand command = new MySqlCommand(query, conn);

                // Tạo các tham số
                command.Parameters.AddWithValue("@username", userName);
                command.Parameters.AddWithValue("@password", passWord);

                try
                {
                    MySqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        String username = (String)dataReader["userName"];
                        String password = (String)dataReader["passWord"];
                        bool isAdmin = (bool)dataReader["isAdmin"];
                        DateTime dateCreate = (DateTime)dataReader["dateCreate"];
                        user = new DTO.User(username, password, isAdmin);
                    }
                }
                catch (MySqlException se)
                {
                    throw se;
                }
                conn.Close();
            }
            return user;
        }

        public static bool CheckUsernameExists(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT COUNT(*) FROM user WHERE userName = @Username";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool InsertUser(DTO.User user)
        {
            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "INSERT INTO user (userName, passWord, isAdmin, dateCreate) VALUES (@Username, @Password, @IsAdmin, @DateCreate)";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Username", user.userName);
                command.Parameters.AddWithValue("@Password", user.passWord);
                command.Parameters.AddWithValue("@IsAdmin", user.isAdmin);
                command.Parameters.AddWithValue("@DateCreate", user.dateCreate);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }

}
