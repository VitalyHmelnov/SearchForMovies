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

namespace Кино
{
    public partial class FormAddingSessions : Form
    {
        public FormAddingSessions()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != null) && (textBoxAdress.Text != null) && (textBox1.Text != null)&&(comboBox1.Text!=null)
                &&(comboBox2.Text!=null))
            {
                DB db1 = new DB();
                DataTable table1 = new DataTable();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();

                MySqlCommand command1 = new MySqlCommand("SELECT * FROM `films` WHERE `name` = @name", db1.getConnection());
                command1.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
                adapter1.SelectCommand = command1;
                adapter1.Fill(table1);
                if (table1.Rows.Count < 1)
                {
                    MessageBox.Show("Сначала добавьте фильм");
                    textBoxName.Text = "";
                }
                else
                {
                    DB db2 = new DB();
                    DataTable table2 = new DataTable();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter();

                    MySqlCommand command2 = new MySqlCommand("SELECT * FROM `cinemas` WHERE `name` = @name", db2.getConnection());
                    command2.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxAdress.Text;
                    adapter2.SelectCommand = command2;
                    adapter2.Fill(table2);
                    if (table2.Rows.Count < 1)
                    {
                        MessageBox.Show("Сначала добавьте кинотеатр");
                        textBoxAdress.Text = "";
                    }
                    else
                    {
                        DB db3 = new DB();
                        MySqlCommand command3 = new MySqlCommand("INSERT INTO `sessions`(`film`, `cinema`, `price`, `bookind`)" +
                            "VALUES (@film,@cinema,@price,@bookind)", db3.getConnection());

                        command3.Parameters.Add("@film", MySqlDbType.Text).Value = textBoxName.Text;
                        command3.Parameters.Add("@cinema", MySqlDbType.Text).Value = textBoxAdress.Text;
                        //command3.Parameters.Add("@data", MySqlDbType.Date).Value = dateTimePicker1.Value;
                        //command3.Parameters.Add("@begin_session", MySqlDbType.Time).Value = TimeSpan.Parse(Convert.ToString(comboBox1.Text+":"+comboBox2.Text+":00"));
                        command3.Parameters.Add("@price", MySqlDbType.Int32).Value = textBox1.Text;
                        if (checkBox1.Checked == true)
                            command3.Parameters.Add("@bookind", MySqlDbType.Text).Value = "Yes";
                        else
                            command3.Parameters.Add("@bookind", MySqlDbType.Text).Value = "No";

                        

                        db3.openConnection();

                        if (command3.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Данные успешно внесены");
                            textBoxName.Text = "";
                            textBoxAdress.Text = "";
                            textBox1.Text = "";
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                            checkBox1.Checked = false;
                        }
                        else
                            MessageBox.Show("Данные не внесены");

                        db3.closeConnection();
                    }
                }
            }

            else
            {
                MessageBox.Show("Заполните все поля");
            }            
        }
    }
}
