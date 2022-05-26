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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Roadhours = 0, Roadmins = 0, Roadseconds = 0;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            movesum = 8 * (60 * Roadhours + Roadmins);
            gensum = movesum;
            Конец a = new Конец(gensum);
            a.Show();
            this.Hide();
        }

        double movesum = 0, gensum = 0;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Roadseconds = Roadseconds + 1;
            if (Roadseconds == 60)
            {
                Roadmins = Roadmins + 1;
                Roadseconds = 0;
            }
            if (Roadmins == 60)
            {
                Roadhours = Roadhours + 1;
                Roadmins = 0;
            }
            if (Roadhours < 10) label1.Text = "0" + Convert.ToString(Roadhours);
            else label1.Text = Convert.ToString(Roadhours);
            if (Roadmins < 10) label2.Text = "0" + Convert.ToString(Roadmins);
            else label2.Text = Convert.ToString(Roadmins);
            if (Roadseconds < 10) label3.Text = "0" + Convert.ToString(Roadseconds);
            else label3.Text = Convert.ToString(Roadseconds);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

       
    }
}
