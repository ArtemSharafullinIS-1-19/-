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
    public partial class Конец : Form
    {
        public Конец(double gensum)
        {
            InitializeComponent();
            this.gensum = gensum;
        }
        double gensum;
        private void Конец_Load(object sender, EventArgs e)
        {
            string gensum1 = Convert.ToString(gensum);
            label2.Text = Convert.ToString(gensum1) + " р";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Профиль m = new Профиль();
            m.ShowDialog();
        }
    }
}
