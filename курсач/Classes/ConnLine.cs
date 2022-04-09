using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсач.Classes
{
    internal class ConnLine
    {
        #region строка подключения
        //Определяем параметры подключения
        private const string host = "chuc.caseum.ru";
        private const string port = "33333";
        private const string database = "is_1_19_st23_KURS";
        private const string username = "st_1_19_23";
        private const string password = "45547788";
        //Формируем строку подключения
        public static string connString = $"server={host};port={port};user={username};database={database};password={password};";
        #endregion
    }
}
