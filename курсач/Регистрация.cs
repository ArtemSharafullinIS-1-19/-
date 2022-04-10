using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace курсач
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
            
        }

        

        private void Регистрация_Load(object sender, EventArgs e)
        {
            //Переменные для textBox.Text
            nameBox.Text = "";
            loginBox.Text = "";
            passwordBox.Text = "";
        }
        bool IsValid(string line, string request)
        {
            return new Regex(@request).IsMatch(line);
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // Запрос в БД на предмет того, если ли строка с подходящим логином и паролем
            var sql = "SELECT * FROM Users WHERE login = @un";
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
            //Присваиваем параметрам значение
            command.Parameters["@un"].Value = loginBox.Text;
            //Заносим команду в адаптер
            adapter.SelectCommand = command;
            //Заполняем таблицу
            adapter.Fill(table);
            //Закрываем соединение
            Classes.DBConn.conn.Close();
            //Если вернулась больше 0 строк, значит такой пользователь существует

            if (table.Rows.Count == 0)
            {

                if ((IsValid(emailText.Text, @"^[\w\.\-]+@[\w\-]+\.[a-z]+$") && IsValid(phoneBox.Text, @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$")))
                {
                    string sql_new = ($"INSERT INTO Users (login, password, isstaff) " +
                                 $"VALUES (@un,@up, 'f')");
                    //Формируем строку запроса на удаление строк
                    string sql_new1 = ($"INSERT INTO clients (name, number, email, login) " +
                                                     $"VALUES ('{nameBox.Text}','{phoneBox.Text}','{emailText.Text}',@un)");
                    //Посылаем запрос на обновление данных
                    MySqlCommand newrec = new MySqlCommand(sql_new, Classes.DBConn.conn);
                    Classes.DBConn.conn.Open();
                    newrec.Parameters.Add("@un", MySqlDbType.VarChar, 25);
                    newrec.Parameters.Add("@up", MySqlDbType.VarChar, 25);
                    //Присваиваем параметрам значение
                    newrec.Parameters["@un"].Value = loginBox.Text;
                    newrec.Parameters["@up"].Value = Classes.Encryption.Sha256(passwordBox.Text);
                    newrec.ExecuteNonQuery();
                    newrec = new MySqlCommand(sql_new1, Classes.DBConn.conn);
                    newrec.Parameters.Add("@un", MySqlDbType.VarChar, 25);
                    newrec.Parameters.Add("@up", MySqlDbType.VarChar, 25);
                    //Присваиваем параметрам значение
                    newrec.Parameters["@un"].Value = loginBox.Text;
                    newrec.Parameters["@up"].Value = Classes.Encryption.Sha256(passwordBox.Text);
                    newrec.ExecuteNonQuery();
                    Classes.DBConn.conn.Close();

                    MessageBox.Show("Вы успешно зарегистрировались!");

                    this.Hide();
                    Авторизация Авторизация = new Авторизация();
                    Авторизация.ShowDialog();
                }// вставь класс IsValid с Некита
                else
                {
                    MessageBox.Show("Введите корректные данные телефона или почты");
                }

            }
         



        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация Авторизация = new Авторизация();
            Авторизация.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
