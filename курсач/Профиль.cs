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
    public partial class Профиль : Form
    {
        public Профиль()
        {
            InitializeComponent();
        }

        private void Профиль_Load(object sender, EventArgs e)
        {
            label5.Text = Classes.Auth.auth_fio;
            label6.Text = Classes.Auth.auth_login;
            label6.Text = Classes.Auth.auth_phone;


        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уверены, что хотите отменить прокат?", "Отмена проката", MessageBoxButtons.YesNo);

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Выйти из аккаунта?", MessageBoxButtons.YesNo);
            Hide();
        }
    }
}
