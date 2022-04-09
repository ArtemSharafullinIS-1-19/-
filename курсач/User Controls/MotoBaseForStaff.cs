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
    public partial class MotoBaseForStaff : UserControl
    {
        public MotoBaseForStaff()
        {
            InitializeComponent();
        }
        public static string request = "SELECT ИмяСтолбца AS 'НазваниеСтолбцаВБД', ИмяСтолбца AS 'НазваниеСтолбцаВБД', ИмяСтолбца AS 'НазваниеСтолбцаВБД', ИмяСтолбца AS 'НазваниеСтолбцаВБД', ИмяСтолбца AS 'НазваниеСтолбцаВБД', ИмяСтолбца AS 'НазваниеСтолбцаВБД' FROM ТаблицаВБД";
        //Переменная для ID записи в БД, выбранной в гриде. Пока она не содержит значения, лучше его инициализировать с 0
        //что бы в БД не отправлялся null
        public static string id_selected_rows = "0";
        private void MotoBaseForStaff_Load(object sender, EventArgs e)
        {

            DataGridView.DataSource = Classes.DBConn.GetListUsers(request);
            //Видимость полей в гриде
            for (int i = 0; i < DataGridView.Columns.Count; i++)
            {
                DataGridView.Columns[i].Visible = true;
            }
            //Ширина полей
            DataGridView.Columns[0].FillWeight = 5;
            DataGridView.Columns[1].FillWeight = 40;
            DataGridView.Columns[2].FillWeight = 10;
            DataGridView.Columns[3].FillWeight = 10;
            DataGridView.Columns[4].FillWeight = 20;
            DataGridView.Columns[5].FillWeight = 15;
            //Режим для полей "Только для чтения"
            for (int i = 0; i < DataGridView.Columns.Count; i++)
            {
                DataGridView.Columns[i].ReadOnly = true;
            }
            //Растягивание полей грида
            for (int i = 0; i < DataGridView.Columns.Count; i++)
            {
                DataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //Убираем заголовки строк
            DataGridView.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            DataGridView.ColumnHeadersVisible = true;
        }

        //Метод обновления DataGreed
        public void Reload()
        {
            //Чистим виртуальную таблицу внутри класса
            Classes.DBConn.ReloadList();
            //Вызываем метод получения записей, который вновь заполнит таблицу
            DataGridView.DataSource = Classes.DBConn.GetListUsers(request);
        }

        private void PencilBox_Click(object sender, EventArgs e)
        {

        }

        private void AddBox_Click(object sender, EventArgs e)
        {
            // тут херачить вызов формы с добавлением или еще чето придумать
        }

        private void DeleteBox_Click(object sender, EventArgs e)
        {
            Classes.DBConn.DeleteUser("DELETE FROM Products WHERE ID_Product='", id_selected_rows);
            Reload();
        }

        //Метод получения ID выделенной строки, для последующего вызова его в нужных методах
        public void GetSelectedIDString()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows;
            //Индекс выбранной строки
            index_selected_rows = DataGridView.SelectedCells[0].RowIndex.ToString();
            //ID конкретной записи в Базе данных, на основании индекса строки
            id_selected_rows = DataGridView.Rows[Convert.ToInt32(index_selected_rows)].Cells[0].Value.ToString();
        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Classes.DBConn.Search("ИмяСтолбцаВДатаГрид LIKE'", TextBox.Text);
        }

        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
                DataGridView.CurrentCell = DataGridView[e.ColumnIndex, e.RowIndex];
                //dataGridView1.CurrentRow.Selected = true;
                DataGridView.CurrentCell.Selected = true;
                //Метод получения ID выделенной строки в глобальную переменную
                GetSelectedIDString();
            }
        }

        private void DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && DataGridView.CurrentCell != null)
            {
                //Магические строки
                DataGridView.CurrentCell = DataGridView[e.ColumnIndex, e.RowIndex];
                DataGridView.CurrentRow.Selected = true;
                //Метод получения ID выделенной строки в глобальную переменную
                GetSelectedIDString();
            }
        }
    }
}
