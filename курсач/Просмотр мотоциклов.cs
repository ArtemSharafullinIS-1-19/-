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

            this.dataGridView1.Columns.Add(col0);
            

            DataGridViewCell cel0 = new DataGridViewTextBoxCell();
           
            DataGridViewRow row = new DataGridViewRow();
            cel0.Value = "Honda";
           
            row.Cells.AddRange(cel0);
            this.dataGridView1.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
           
            row = new DataGridViewRow();
            cel0.Value = "SUZUKI";
            
            row.Cells.AddRange(cel0);
            this.dataGridView1.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
           
            row = new DataGridViewRow();
            cel0.Value = "BMW";
           
            row.Cells.AddRange(cel0);
            this.dataGridView1.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            
            row = new DataGridViewRow();
            cel0.Value = "YAMAHA";
            
            row.Cells.AddRange(cel0);
            this.dataGridView1.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            
            row = new DataGridViewRow();
            cel0.Value = "KAWASAKI";
            
            row.Cells.AddRange(cel0);
            this.dataGridView1.Rows.Add(row);
            //msgbox с получением инфы
            if (MessageBox.Show("Вы сотрудник?", "Вопрос", MessageBoxButtons.YesNo) == DialogResult.Yes) Info.Employee = true;
            else Info.Employee = false;
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void kAWASAKIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

      
    
}
