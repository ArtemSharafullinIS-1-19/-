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
        class Info //хранение информации методов
        {
            //без статиков не работает :(
            public static string id_selected_rows = "0";
            public static bool Employee;
            public static bool check = false;
            public static string isRenc = "";
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }

        private void Просмотр_мотоциклов_Load(object sender, EventArgs e)
        {
            //заполнение datagrid
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.HeaderText = "Марка";
            col0.Name = "ID1";
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Модель";
            col1.Name = "ID2";
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Max Speed";
            col2.Name = "ID3";
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Цвет";
            col3.Name = "ID4";
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Стоимость в день";
            col4.Name = "ID5";
            this.dataGridView1.Columns.Add(col0);
            this.dataGridView1.Columns.Add(col1);
            this.dataGridView1.Columns.Add(col2);
            this.dataGridView1.Columns.Add(col3);
            this.dataGridView1.Columns.Add(col4);

            DataGridViewCell cel0 = new DataGridViewTextBoxCell();
            DataGridViewCell cel1 = new DataGridViewTextBoxCell();
            DataGridViewCell cel2 = new DataGridViewTextBoxCell();
            DataGridViewCell cel3 = new DataGridViewTextBoxCell();
            DataGridViewCell cel4 = new DataGridViewTextBoxCell();
            DataGridViewRow row = new DataGridViewRow();
            cel0.Value = "Honda";
            cel1.Value = "FireStorm";
            cel2.Value = "176";
            cel3.Value = "Синий";
            cel4.Value = "7.000";
            row.Cells.AddRange(cel0, cel1, cel2, cel3, cel4);
            this.dataGridView1.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            cel2 = new DataGridViewTextBoxCell();
            cel3 = new DataGridViewTextBoxCell();
            cel4 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "SUZUKI";
            cel1.Value = "GSX-R1000";
            cel2.Value = "190";
            cel3.Value = "Чёрный";
            cel4.Value = "10.000";
            row.Cells.AddRange(cel0, cel1, cel2, cel3, cel4);
            this.dataGridView1.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            cel2 = new DataGridViewTextBoxCell();
            cel3 = new DataGridViewTextBoxCell();
            cel4 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "BMW";
            cel1.Value = "S1000RR";
            cel2.Value = "200+";
            cel3.Value = "Чёрно-зелёный";
            cel4.Value = "13.000";
            row.Cells.AddRange(cel0, cel1, cel2, cel3, cel4);
            this.dataGridView1.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            cel2 = new DataGridViewTextBoxCell();
            cel3 = new DataGridViewTextBoxCell();
            cel4 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "YAMAHA";
            cel1.Value = "YZF-R6";
            cel2.Value = "187";
            cel3.Value = "Чёрный";
            cel4.Value = "13.000";
            row.Cells.AddRange(cel0, cel1, cel2, cel3, cel4);
            this.dataGridView1.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            cel2 = new DataGridViewTextBoxCell();
            cel3 = new DataGridViewTextBoxCell();
            cel4 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "KAWASAKI";
            cel1.Value = "NINJA 400 KRT";
            cel2.Value = "400";
            cel3.Value = "Красный";
            cel4.Value = "15.000";
            row.Cells.AddRange(cel0, cel1, cel2, cel3, cel4);
            this.dataGridView1.Rows.Add(row);
            //msgbox с получением инфы
            if (MessageBox.Show("Вы сотрудник?", "Вопрос", MessageBoxButtons.YesNo) == DialogResult.Yes) Info.Employee = true;
            else Info.Employee = false;
        }

    }

      
    
}
