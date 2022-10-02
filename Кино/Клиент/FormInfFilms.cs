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

namespace Кино.Клиент
{
    public partial class FormInfFilms : Form
    {
        private MySqlDataReader reader;

        public FormInfFilms()
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
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
                data[data.Count - 1][4] = reader[5].ToString();
                data[data.Count - 1][5] = reader[6].ToString();
                data[data.Count - 1][6] = reader[7].ToString();
                
            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlCommand command1=null;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if ((textBox1.Text != "") && (comboBox1.Text != "") && (textBox2.Text != ""))
            {
                command1 = new MySqlCommand("SELECT * FROM `films` WHERE `name` = @n AND `genre` = @g AND `year` = @y", db.getConnection());
                command1.Parameters.Add("@n", MySqlDbType.VarChar).Value = textBox1.Text;
                command1.Parameters.Add("@g", MySqlDbType.VarChar).Value = comboBox1.Text;
                command1.Parameters.Add("@y", MySqlDbType.VarChar).Value = textBox2.Text;
            }
            if ((textBox1.Text != "") && (comboBox1.Text != "") && (textBox2.Text == ""))
            {

                command1 = new MySqlCommand("SELECT * FROM `films` WHERE `name` = @n AND `genre` = @g", db.getConnection());
                command1.Parameters.Add("@n", MySqlDbType.VarChar).Value = textBox1.Text;
                command1.Parameters.Add("@g", MySqlDbType.VarChar).Value = comboBox1.Text;
            }
            if ((textBox1.Text != "") && (comboBox1.Text == "") && (textBox2.Text != ""))
            {
                command1 = new MySqlCommand("SELECT * FROM `films` WHERE `name` = @n AND `year` = @y", db.getConnection());
                command1.Parameters.Add("@n", MySqlDbType.VarChar).Value = textBox1.Text;
                command1.Parameters.Add("@y", MySqlDbType.VarChar).Value = textBox2.Text;
            }
            if ((textBox1.Text == "") && (comboBox1.Text != "") && (textBox2.Text != ""))
            {
                command1 = new MySqlCommand("SELECT * FROM `films` WHERE `genre` = @g AND `year` = @y", db.getConnection());
                command1.Parameters.Add("@g", MySqlDbType.VarChar).Value = comboBox1.Text;
                command1.Parameters.Add("@y", MySqlDbType.VarChar).Value = textBox2.Text;
            }
            if ((textBox1.Text != "") && (comboBox1.Text == "") && (textBox2.Text == ""))
            {
                command1 = new MySqlCommand("SELECT * FROM `films` WHERE `name` = @n", db.getConnection());
                command1.Parameters.Add("@n", MySqlDbType.VarChar).Value = textBox1.Text;
            }
            if ((textBox1.Text == "") && (comboBox1.Text != "") && (textBox2.Text == ""))
            {
                command1 = new MySqlCommand("SELECT * FROM `films` WHERE `genre` = @g", db.getConnection());
                command1.Parameters.Add("@g", MySqlDbType.VarChar).Value = comboBox1.Text;
            }
            if ((textBox1.Text == "") && (comboBox1.Text == "") && (textBox2.Text != ""))
            {
                command1 = new MySqlCommand("SELECT * FROM `films` WHERE `year` = @y", db.getConnection());
                command1.Parameters.Add("@y", MySqlDbType.VarChar).Value = textBox2.Text;
            }
            if ((textBox1.Text == "") && (comboBox1.Text == "") && (textBox2.Text == ""))
            {
                command1 = new MySqlCommand("SELECT * FROM `films`", db.getConnection());
            }


            reader = command1.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
                data[data.Count - 1][4] = reader[5].ToString();
                data[data.Count - 1][5] = reader[6].ToString();
                data[data.Count - 1][6] = reader[7].ToString();

            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);


        }

        
    }
}
