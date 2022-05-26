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
    public partial class Аренда : Form
    {
        public Аренда()
        {
            InitializeComponent();
        }

        int m = 0, s = 0;
        int flag = 0;
        int hours = 0, mins = 0, seconds = 0;

        private void Аренда_Load(object sender, EventArgs e)
        {
            m = 20;//изменить на 20:00
            s = 0;
            timer2.Start();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        { 
           
            Просмотр_мотоциклов m = new Просмотр_мотоциклов();
            m.Show();
            if (flag == 0) MessageBox.Show("Ваша поездка была отменена.", "Отмена поездки");
            if (flag == 1)
            {
                double sum = 2 * (60 * hours + mins);
                string sum1 = Convert.ToString(sum);
                MessageBox.Show("За платное ожидание Вами было оплачено " + sum1 + " рублей.", "Оплата поездки");
            }
            this.Hide();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (flag == 1) sum = 2 * (60 * hours + mins);
            Form1 g = new Form1();
            g.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == 0 && s == 0)
            {
                timer2.Stop();
                flag = 1;
                timer2.Start();
            }

            if (m < 10) label4.Text = "0" + Convert.ToString(m);
            else label4.Text = Convert.ToString(m);
            
        }
        private void timer3_Tick(object sender, EventArgs e)
        {


            seconds = seconds + 1;
            if (seconds == 60)
            {
                mins = mins + 1;
                seconds = 0;
            }
            if (mins == 60)
            {
                hours = hours + 1;
                mins = 0;
            }
            if (hours < 10) label1.Text = "0" + Convert.ToString(hours);
            else label1.Text = Convert.ToString(hours);
            if (mins < 10) label4.Text = "0" + Convert.ToString(mins);
            else label4.Text = Convert.ToString(mins);
           
        }
    }


}

