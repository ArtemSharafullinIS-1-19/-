using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач.User_Controls
{
    public partial class MotoBaseForClients : UserControl
    {
        public MotoBaseForClients()
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

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MotoBaseForClients_Load(object sender, EventArgs e)
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
            
           
        }
    }
}
