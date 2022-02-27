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

            MySqlCommand command = new MySqlCommand("SELECT * FROM 'users' WHERE 'login' = @ul AND 'pass' = @up", bd.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginuser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passuser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Вы успешно авторизовались!");
            else
                MessageBox.Show("Вы ввели некорректные данные!");


            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox2.Visible = true;
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
