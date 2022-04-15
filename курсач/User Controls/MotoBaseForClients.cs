using MySql.Data.MySqlClient;
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
        public static string request = "SELECT id AS 'id', Stamp AS 'Марка', Power AS 'Мощьность', Number AS 'Номер мотоцикла', Color AS 'Цвет', Price AS 'Цена' FROM MotoBase";
        //Переменная для ID записи в БД, выбранной в гриде. Пока она не содержит значения, лучше его инициализировать с 0
        //что бы в БД не отправлялся null
        public static string id_selected_rows = "0";

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
            dataGridView1.DataSource = Classes.DBConn.GetListUsers(request);
            //Видимость полей в гриде
           

            dataGridView1.Columns[0].FillWeight = 25;
            dataGridView1.Columns[1].FillWeight = 70;
            dataGridView1.Columns[2].FillWeight = 70;
            dataGridView1.Columns[3].FillWeight = 70;
            dataGridView1.Columns[4].FillWeight = 70;
            dataGridView1.Columns[5].FillWeight = 70;

            //Растягивание полей грида
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //Убираем заголовки строк
            dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;

        }

        public void Request()
        {
            // устанавливаем соединение с БД
            Classes.DBConn.conn.Open();
            // запрос
            string sql = $"SELECT isRenc FROM Stamp WHERE Марка={id_selected_rows} AND id={id}";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, Classes.DBConn.conn);
            // выполняем запрос и получаем ответ
            string name = command.ExecuteScalar().ToString();
            // выводим ответ в TextBox
            isRenc = name;
            // закрываем соединение с БД
            Classes.DBConn.conn.Close();
        }
        public static string isRenc = "";
        private object id;

        public void Renc()
        {
            Info.isRenc += Info.id_selected_rows + " ";
            MessageBox.Show($"Аренда мотоцикла {Info.id_selected_rows} прошла успешно!", "Уведомление");
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (!Info.isRenc.Contains("true"))
            {
                Renc();
                // устанавливаем соединение с БД
                Classes.DBConn.conn.Open();
                // запрос
                //string sql =
            }
            else
            {
                MessageBox.Show($"Вы уже арендовали мотоцикл {Info.id_selected_rows}", "Уведомление");
            }
        }
    }
}
