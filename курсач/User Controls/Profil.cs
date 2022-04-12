using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace курсач.User_Controls
{
    public partial class Profil : UserControl
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void Profil_Load_1(object sender, EventArgs e)
        {
            if (Classes.Auth.auth_is_admin)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
            }
            else
            {
                label3.Visible = false;
                label7.Visible = false;
            }

            label5.Text = Classes.Auth.auth_fio;
            label6.Text = Classes.Auth.auth_login;
            label7.Text = Classes.Auth.auth_doljnost;
        }
    }
}
