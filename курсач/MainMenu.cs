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

        }

        private void MenuButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вышли из аккаунта");
            
            this.Hide();
            Авторизация Авторизация = new Авторизация();
            Авторизация.ShowDialog();
            
            Environment.Exit(0);


        }
    }

      
    
}
