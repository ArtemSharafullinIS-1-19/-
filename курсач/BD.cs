using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace курсач
{
    internal class BD
    {
        MySqlConnection connection = new MySqlConnection("server = Localhost; port = 3306; username = st_1_29_19@localhost; password = 85653548; database = st_1_29_19");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }


    }
}
