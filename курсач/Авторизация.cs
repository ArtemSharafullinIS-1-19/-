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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox2.Visible = true;
            }

            if (guna2TextBox1.Text != "" & guna2TextBox2.Text != "")
            {
                MessageBox.Show("Вы успешно авторизовались");

                this.Hide();
                Профиль Профиль = new Профиль();
                Профиль.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы ввели некоректные данные");
            }
           
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
    }
}
