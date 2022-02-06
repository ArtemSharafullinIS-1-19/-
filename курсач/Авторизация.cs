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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
            guna2Button1.Enabled = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            menu menu = new menu();
            menu.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            guna2Button1.Enabled = !string.IsNullOrWhiteSpace(textBox2.Text);
        }

        
    }
}
