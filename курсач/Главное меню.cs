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
    public partial class Главноеменю : Form
    {
        public Главноеменю()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Профиль_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Профиль Профиль = new Профиль();
            Профиль.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Просмотр_мотоциклов Просмотр_мотоциклов = new Просмотр_мотоциклов();
            Просмотр_мотоциклов.ShowDialog();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
