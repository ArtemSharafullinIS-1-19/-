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
            this.guna2Button1.Enabled = false; //Выключение кнопки guna2Button1
        }

        

        private void Регистрация_Load(object sender, EventArgs e)
        {
            //Вывод информации в label
            label1.Text = ("Введите Имя, Фамилию, Отчёство"); 
            label2.Text = ("Введите Email");
            label3.Text = ("Введите телефон");

            //Переменные для textBox.Text
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {

            }
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox3.Text == "")
            {

            }

            guna2Button1.Enabled = !string.IsNullOrWhiteSpace(textBox3.Text); //Включение кнопки guna2Button1 при заполнении textBox3.Text
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label1.Font = new Font("Times New Roman", 9, FontStyle.Regular);
                label1.ForeColor = Color.Black;
                //Если значение верное, то label будет обычного цвета
            }
            else
            {
                label1.Text = "Введите Имя, Фамилию, Отчёство!";
                label1.ForeColor = Color.Red;
                label1.Font = new Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
                //Если значение не верно, то label будет красного цвета
            }
            if (textBox2.Text != "")
            {
                label2.Font = new Font("Times New Roman", 9, FontStyle.Regular);
                label2.ForeColor = Color.Black;
                //Если значение верное, то label будет обычного цвета
            }
            else
            {
                label2.Text = "Введите Email!";
                label2.ForeColor = Color.Red;
                label2.Font = new Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
                //Если значение не верно, то label будет красного цвета
            }
            if (textBox3.Text != "")
            {
                label3.Font = new Font("Times New Roman", 9, FontStyle.Regular);
                label3.ForeColor = Color.Black;
                //Если значение верное, то label будет обычного цвета
            }
            else
            {
                label3.Text = "Введите телефон!";
                label3.ForeColor = Color.Red;
                label3.Font = new Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
                //Если значение не верно, то label будет красного цвета
            }

            MessageBox.Show("Вы успешно зарегистрировались");

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
