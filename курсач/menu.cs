﻿using System;
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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Авторизация Авторизация = new Авторизация();
            Авторизация.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация Регистрация = new Регистрация();
            Регистрация.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
