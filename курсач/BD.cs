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
        MySqlConnection connection = new MySqlConnection("server=chuc.caseum.ru;port=33333;user=st_1_29_19;database=st_1_29_19;password=85653548;");
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
