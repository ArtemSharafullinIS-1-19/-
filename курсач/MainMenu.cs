using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace курсач
{
    public partial class Просмотр_мотоциклов : Form
    {
        public Просмотр_мотоциклов()
        {
            InitializeComponent();
        }

        private void Просмотр_мотоциклов_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void motoBase1_Load(object sender, EventArgs e)
        {
            if (Classes.Auth.auth_is_admin)
            {

                motoBase1.Visible = false;
            }
            else
            {
                personal1.Visible = false;
                motoBaseForStaff1.Visible = false;
                clients1.Visible = false;
                MenuButton2.Visible = false;
                MenuButton3.Visible = false;
            }
        }

        private void MenuButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вышли из аккаунта");
            
            this.Hide();
            Авторизация Авторизация = new Авторизация();
            Авторизация.ShowDialog();
            
            Environment.Exit(0);


        }

        private void MenuButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void MenuButton4_Click(object sender, EventArgs e)
        {

        }

        private void MenuButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Classes.Auth.auth_is_admin)
            {
                motoBaseForStaff1.Visible = MenuButton1.Checked;
                clients1.Visible = MenuButton2.Checked;
            }
            else
            {
                motoBase1.Visible = MenuButton1.Checked;
            }
            if (Classes.Auth.auth_is_admin)
            {
                personal1.Visible = MenuButton3.Checked;
            }
            else
            {

            }
        }

        private void personal1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Профиль Профиль = new Профиль();
            Профиль.ShowDialog();

        }

       
    }

      
    
}
