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
            string loginuser = guna2TextBox1.Text;
            string passuser = guna2TextBox2.Text;

            BD bd = new BD();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

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

        private void Авторизация_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(guna2GradientButton1, "Нажмите, чтоб войти");

            ToolTip t2 = new ToolTip();
            t2.SetToolTip(guna2GradientButton2, "Нажмите, чтоб выйти в меню");
        }
    }
}
