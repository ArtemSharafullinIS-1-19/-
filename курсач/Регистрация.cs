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
            this.guna2Button1.Enabled = false;
        }

        

        private void Регистрация_Load(object sender, EventArgs e)
        {
            label1.Text = ("Введите Имя, Фамилию, Отчёство");
            label2.Text = ("Введите Email");
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
            guna2Button1.Enabled = !string.IsNullOrWhiteSpace(textBox3.Text);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label1.Font = new Font("Times New Roman", 9, FontStyle.Regular);
                label1.ForeColor = Color.Black;
            }
            else
            {
                label1.Text = "Введите Имя, Фамилию, Отчёство!";
                label1.ForeColor = Color.Red;
                label1.Font = new Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            }
            if (textBox2.Text != "")
            {
                label2.Font = new Font("Times New Roman", 9, FontStyle.Regular);
                label2.ForeColor = Color.Black;
            }
            else
            {
                label2.Text = "Введите Email!";
                label2.ForeColor = Color.Red;
                label2.Font = new Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            }
            if (textBox3.Text != "")
            {
                label3.Font = new Font("Times New Roman", 9, FontStyle.Regular);
                label3.ForeColor = Color.Black;
            }
            else
            {
                label3.Text = "Введите телефон!";
                label3.ForeColor = Color.Red;
                label3.Font = new Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
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
