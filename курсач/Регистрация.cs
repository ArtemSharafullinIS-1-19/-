using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            label1.Text = ("Введите Имя, Фамилию, Отчёство");
            label2.Text = ("Введите Emaill");
            label3.Text = ("Введите телефон");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Вы не ввели ФИО!");
            }
            if (textBox2.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Вы не ввели Email");
            }
            if (textBox3.Text != "")
            {

            }
            else
            {
                MessageBox.Show("ВЫ не ввели телефон");
            }


            Hide();
            Профиль Профиль = new Профиль();
            Профиль.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            menu menu = new menu();
            menu.ShowDialog();
        }
    }
}
