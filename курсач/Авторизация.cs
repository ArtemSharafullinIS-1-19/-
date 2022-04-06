using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace курсач
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
            
        }

        // строка подключения к БД
        string connStr = "server=caseum.ru;port=33333;user=st_1_29_19;database=st_1_29_19;password=85653548;";
        //Переменная соединения
        MySqlConnection conn;
        //Логин и пароль к данной форме Вы сможете посмотреть в БД db_test таблице t_user

        //Вычисление хэша строки и возрат его из метода
         string sha256(string randomString)
        {
            //Тут происходит криптографическая магия. Смысл данного метода заключается в том, что строка залетает в метод
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //Запрос в БД на предмет того, если ли строка с подходящим логином и паролем
            Просмотр_мотоциклов Просмотр_мотоциклов = new Просмотр_мотоциклов();
            Просмотр_мотоциклов.ShowDialog();
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
             this.Hide();
            menu menu = new menu(); //Открытие окна меню при нажатии на кнопку "Назад"
            menu.ShowDialog();
           
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {
            //Инициализируем соединение с подходящей строкой
            conn = new MySqlConnection(connStr);

            ToolTip t = new ToolTip();
            t.SetToolTip(guna2GradientButton1, "Нажмите, чтоб войти");

            ToolTip t2 = new ToolTip();
            t2.SetToolTip(guna2GradientButton2, "Нажмите, чтоб выйти в меню");

        }
    }
}
