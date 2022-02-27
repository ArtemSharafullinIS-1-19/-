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
            

            //Переменные для textBox.Text
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";

            

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

            if (guna2TextBox1.Text != "")
            {
                label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
                label1.ForeColor = Color.White;
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
                label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
                label2.ForeColor = Color.White;
                //Если значение верное, то label будет обычного цвета
            }
            else
            {
                label2.Text = "Введите Ваш логин!";
                label2.ForeColor = Color.Red;
                label2.Font = new Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
                //Если значение не верно, то label будет красного цвета
            }
            if (guna2TextBox3.Text != "")
            {
                label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
                label3.ForeColor = Color.White;
                //Если значение верное, то label будет обычного цвета
            }
            else
            {
                label3.Text = "Введите Ваш Email!";
                label3.ForeColor = Color.Red;
                label3.Font = new Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
                //Если значение не верно, то label будет красного цвета
            }
            if (guna2TextBox4.Text != "")
            {
                label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
                label4.ForeColor = Color.White;
                //Если значение верное, то label будет обычного цвета
            }
            else
            {
                label4.Text = "Введите Ваш телефон!";
                label4.ForeColor = Color.Red;
                label4.Font = new Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
                //Если значение не верно, то label будет красного цвета
            }

            if (guna2TextBox1.Text != "" & guna2TextBox2.Text != "" & guna2TextBox3.Text != "")
            {
                MessageBox.Show("Вы успешно зарегистрировались!");

                this.Hide();
                Профиль Профиль = new Профиль();
                Профиль.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные!");
            }
           

            

            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hide();
            menu menu = new menu();
            menu.ShowDialog();
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

      
    }
}
