﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсач.Classes
{
    internal static class Auth
    {
        //Статичное поле, которое хранит значение статуса авторизации
        public static bool auth = false;
        //Статичное поле, которое хранит значения ID пользователя
        public static string auth_id = null;
        //Статичное поле, которое хранит значения ФИО пользователя
        public static string auth_fio = null;
        public static string auth_email = null;
        public static string auth_login = null;
        public static string auth_phone = null;
        //Статичное поле, которое хранит количество привелегий пользователя
        public static string auth_doljnost = null;
        public static bool auth_is_admin = false;
    }
}
