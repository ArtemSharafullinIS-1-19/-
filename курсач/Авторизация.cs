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

        public void GetUserInfo(string login)
        {
            if (Classes.Auth.auth_is_admin)
            {
                // устанавливаем соединение с БД
                Classes.DBConn.conn.Open();
                // запрос
                var sql = $"SELECT * FROM Personal WHERE login='{login}'";
                // объект для выполнения SQL-запроса
                var command = new MySqlCommand(sql, Classes.DBConn.conn);
                // объект для чтения ответа сервера
                var reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    Classes.Auth.auth_id = reader[0].ToString();
                    Classes.Auth.auth_fio = reader[1].ToString();
                    Classes.Auth.auth_doljnost = reader[2].ToString();
                }
                reader.Close(); // закрываем reader
                                // закрываем соединение с БД
                Classes.DBConn.conn.Close();
            }
            else
            {
                // устанавливаем соединение с БД
                Classes.DBConn.conn.Open();
                // запрос
                var sql = $"SELECT * FROM clients WHERE login='{login}'";
                // объект для выполнения SQL-запроса
                var command = new MySqlCommand(sql, Classes.DBConn.conn);
                // объект для чтения ответа сервера
                var reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    Classes.Auth.auth_id = reader[0].ToString();
                    Classes.Auth.auth_fio = reader[1].ToString();
                    Classes.Auth.auth_email = reader[3].ToString();
                }
                reader.Close(); // закрываем reader
                // закрываем соединение с БД
                Classes.DBConn.conn.Close();
            }
        }


        // строка подключения к БД
        string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_19_23;database=is_1_19_st23_KURS;password=45547788;";
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
            var sql = "SELECT * FROM Users WHERE login = @un and  password= @up";
            //Открытие соединения
            Classes.DBConn.conn.Open();
            //Объявляем таблицу
            var table = new DataTable();
            //Объявляем адаптер
            var adapter = new MySqlDataAdapter();
            //Объявляем команду
            var command = new MySqlCommand(sql, Classes.DBConn.conn);
            //Определяем параметры
            command.Parameters.Add("@un", MySqlDbType.VarChar, 25);
            command.Parameters.Add("@up", MySqlDbType.VarChar, 25);
            //Присваиваем параметрам значение
            command.Parameters["@un"].Value = loginBox.Text;
            command.Parameters["@up"].Value = Classes.Encryption.Sha256(passwordBox.Text);
            //Заносим команду в адаптер
            adapter.SelectCommand = command;
            //Заполняем таблицу
            adapter.Fill(table);

            var reader = command.ExecuteReader();
            if (reader.Read()) //Если удалось прочитать первую строку из результата (читай: если есть 1ая строка)
            {
                MessageBox.Show(string.Format("Вы вошли как {0}", reader["login"]));
                Classes.Auth.auth_is_admin = reader["isstaff"].ToString() == "t" ? true : false; ;
            }

            //Закрываем соединение
            Classes.DBConn.conn.Close();
            //Если вернулась больше 0 строк, значит такой пользователь существует
            if (table.Rows.Count > 0)
            {
                //Присваеваем глобальный признак авторизации
                Classes.Auth.auth = true;
                //Достаем данные пользователя в случае успеха
                GetUserInfo(loginBox.Text);
                //Вызов формы в режиме диалога

                Hide();
                Просмотр_мотоциклов Просмотр_мотоциклов = new Просмотр_мотоциклов();
                Просмотр_мотоциклов.ShowDialog();

            }
            else
            {
                //Отобразить сообщение о том, что авторизаия неуспешна
                MessageBox.Show("Неверные данные авторизации");

            }

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
           
           
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
            t2.SetToolTip(linkLabel1, "Нажмите, чтоб зарегистрироваться");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Регистрация Регистрация = new Регистрация();
            Регистрация.ShowDialog();
        }
    }
}
