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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(guna2GradientButton1, "Нажмите, чтоб авторизоваться");

            ToolTip t2 = new ToolTip();
            t2.SetToolTip(guna2GradientButton2, "Нажмите, чтоб зарегистрироваться");
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация Авторизация = new Авторизация();
            Авторизация.ShowDialog();

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Регистрация Регистрация = new Регистрация();
            Регистрация.ShowDialog();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
