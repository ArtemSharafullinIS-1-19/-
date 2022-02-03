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

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "Вы успешно зарегистрировались!")
            {
                MessageBox.Show("Вы успешно зарегистрировались!");
            }
           else
            {
                MessageBox.Show("Вы ввели не все данные!");
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
