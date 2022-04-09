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
            logonBox.Text = "";
            passwordText.Text = "";

            

        }
        bool IsValid(string line, string request)
        {
            return new Regex(@request).IsMatch(line);
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if ((IsValid(emailText.Text, @"^[\w\.\-]+@[\w\-]+\.[a-z]+$") && IsValid(phoneBox.Text, @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$")))
            {
                //Формируем строку запроса на удаление строк
                string sql_new = ($"INSERT INTO clients (name, number, email, login, password) " +
                                                 $"VALUES ('{nameBox.Text}','{phoneBox.Text}','{emailText.Text}',@un,@up)");
                //Посылаем запрос на обновление данных
                MySqlCommand newrec = new MySqlCommand(sql_new, Classes.DBConn.conn);
                Classes.DBConn.conn.Open();
                newrec.Parameters.Add("@un", MySqlDbType.VarChar, 25);
                newrec.Parameters.Add("@up", MySqlDbType.VarChar, 25);
                //Присваиваем параметрам значение
                newrec.Parameters["@un"].Value = logonBox.Text;
                newrec.Parameters["@up"].Value = Classes.Encryption.Sha256(passwordText.Text);
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
