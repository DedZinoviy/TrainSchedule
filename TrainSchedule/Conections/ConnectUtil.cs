using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace TrainSchedule.Conections
{
    /// <summary>
    /// A class containing connections to various databases.
    /// </summary>
    public class ConnectUtil
    {
        /// <summary>
        /// Connection method (connection creation) to MySql database.
        /// </summary>
        /// <returns>MySql connection</returns>
        public static MySqlConnection GetConnection()
        {
            string connectionString = "Server=localhost;DataBase=trains;UId=root;Pwd=hell2002";
            return new MySqlConnection(connectionString);
        }
    }
}
