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
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
        }

        public static string request = "SELECT id AS 'id', id_user AS 'Код пользователя', Datazakaza AS 'Дата заказа', Dataokonchaniya AS 'Дата окончания заказа', Sum AS 'Сумма' FROM History";
        //Переменная для ID записи в БД, выбранной в гриде. Пока она не содержит значения, лучше его инициализировать с 0
        //что бы в БД не отправлялся null
        public static string id_selected_rows = "0";
        private void History_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = Classes.DBConn.GetListUsers(request);
            //Видимость полей в гриде
            for (int i = 0; i < DataGridView.Columns.Count; i++)
            {
                DataGridView.Columns[i].Visible = true;
            }
            //Ширина полей
            DataGridView.Columns[0].FillWeight = 3;
            DataGridView.Columns[1].FillWeight = 10;
            DataGridView.Columns[2].FillWeight = 10;
            DataGridView.Columns[3].FillWeight = 10;
            DataGridView.Columns[4].FillWeight = 10;


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

        public void GetSelectedIDString()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows;
            //Индекс выбранной строки
            index_selected_rows = DataGridView.SelectedCells[0].RowIndex.ToString();
            //ID конкретной записи в Базе данных, на основании индекса строки
            id_selected_rows = DataGridView.Rows[Convert.ToInt32(index_selected_rows)].Cells[0].Value.ToString();
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
