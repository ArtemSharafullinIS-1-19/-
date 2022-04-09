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
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
            
        }

        

        private void Регистрация_Load(object sender, EventArgs e)
        {
            

            //Переменные для textBox.Text
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";

            

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            

            BD bd = new BD();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (FIO, pass, phone, login) VALUES(@FIO, @pass, @phone, @login", bd.getConnection());

            command.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = guna2TextBox1.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = guna2TextBox3.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = guna2TextBox4.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = guna2TextBox2.Text;


            bd.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был успешно зарегистрирован!");

                this.Hide();
                Профиль Профиль = new Профиль();
                Профиль.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не был зарегистрирован!");
            }

            bd.closeConnection();
            


            
            
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
