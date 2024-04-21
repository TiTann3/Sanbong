using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    public class Connect
    {
        private static String mysqlConnectStr = "Server=localhost;" +
                "Database=qlsanbong;" +
                "Port=3306;" +
                "User ID=root;" +
                "Password=;" +
                "charset=utf8;" +
                "old guids=true;";

        public static String connectionString()
        {
            return mysqlConnectStr;
        }
    }
}
