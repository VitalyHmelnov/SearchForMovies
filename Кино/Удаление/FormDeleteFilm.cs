using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Кино.Удаление
{
    public partial class FormDeleteFilm : Form
    {
        private MySqlDataReader reader;

        public FormDeleteFilm()
        {
            InitializeComponent();
            fff();
        }
        public void fff()
        {
            dataGridView1.Rows.Clear();
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `films`", db.getConnection());

            reader = command1.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
                data[data.Count - 1][4] = reader[5].ToString();
                data[data.Count - 1][5] = reader[6].ToString();
                data[data.Count - 1][6] = reader[7].ToString();
                data[data.Count - 1][7] = reader[0].ToString();

            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
            

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int znachenie = Convert.ToInt32(dataGridView1[7, e.RowIndex].Value);
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("DELETE FROM `films` WHERE `id` = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = znachenie;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные успешно удалены");
                fff();
                return;
            }
            else
                MessageBox.Show("Данные не удалены");
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `films` WHERE `name` = @n", db.getConnection());
            if (textBoxName.Text != "")
                command1.Parameters.Add("@n", MySqlDbType.VarChar).Value = textBoxName.Text;
            else
            {
                fff();
                return;
            }

            reader = command1.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
                data[data.Count - 1][4] = reader[5].ToString();
                data[data.Count - 1][5] = reader[6].ToString();
                data[data.Count - 1][6] = reader[7].ToString();
                data[data.Count - 1][7] = reader[0].ToString();

            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }
}
