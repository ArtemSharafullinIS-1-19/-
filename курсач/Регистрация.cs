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
            this.guna2GradientButton1.Enabled = false; //Выключение кнопки guna2Button1
        }

        

        private void Регистрация_Load(object sender, EventArgs e)
        {
            //Вывод информации в label
            label1.Text = ("Введите Имя, Фамилию, Отчёство"); 
            label2.Text = ("Введите Email");
            label3.Text = ("Введите телефон");

            //Переменные для textBox.Text
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
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
            if (guna2TextBox2.Text != "")
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
            if (guna2TextBox3.Text != "")
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
            Главноеменю Профиль = new Главноеменю();
            Профиль.ShowDialog();

            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hide();
            menu menu = new menu();
            menu.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

            if (guna2TextBox1.Text == "")
            {

            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "")
            {

            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text == "")
            {

            }

            this.guna2GradientButton1.Enabled = !string.IsNullOrWhiteSpace(guna2TextBox3.Text); //Включение кнопки guna2Button1 при заполнении textBox3.Text
        }

      
    }
}
