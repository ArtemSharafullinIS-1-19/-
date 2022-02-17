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
            guna2GradientButton1.Enabled = false; //Выключение кнопки guna2Button1
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы успешно авторизовались"); //Появление окна с информацией

            this.Hide();
            Главноеменю Профиль = new Главноеменю(); //Открытие формы Профиля при авторизации
            Профиль.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
             this.Hide();
            menu menu = new menu(); //Открытие окна меню при нажатии на кнопку "Назад"
            menu.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            guna2GradientButton1.Enabled = !string.IsNullOrWhiteSpace(guna2TextBox1.Text);
        }
    }
}
