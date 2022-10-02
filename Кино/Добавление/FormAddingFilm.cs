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
    public partial class FormAddingFilm : Form
    {
        public FormAddingFilm()
        {
            InitializeComponent();
        }

        private void textBoxLenght_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != "") && (comboBox1.Text != "") && (textBoxYear.Text != "") && (textBoxLenght.Text != "")
                && (textBoxCountry.Text != "") && (textBoxDirector.Text != "") && (richTextBoxActors.Text != ""))
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `films`(`name`, `genre`, `year`, `country`, `length`, `director`, `actors`) " +
                    "VALUES (@name,@genre,@year,@coutry,@lenght,@director,@actors)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.Text).Value = textBoxName.Text;
                command.Parameters.Add("@genre", MySqlDbType.Text).Value = comboBox1.Text;
                command.Parameters.Add("@year", MySqlDbType.Int32).Value = textBoxYear.Text;
                command.Parameters.Add("@coutry", MySqlDbType.Text).Value = textBoxCountry.Text;
                command.Parameters.Add("@lenght", MySqlDbType.Int32).Value = textBoxLenght.Text;
                command.Parameters.Add("@director", MySqlDbType.Text).Value = textBoxDirector.Text;
                command.Parameters.Add("@actors", MySqlDbType.VarChar).Value = richTextBoxActors.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно внесены");
                    textBoxName.Text = "";
                    comboBox1.Text = "";
                    textBoxYear.Text = "";
                    textBoxCountry.Text = "";
                    textBoxLenght.Text = "";
                    textBoxDirector.Text = "";
                    richTextBoxActors.Text = "";
                }
                    
                else
                    MessageBox.Show("Данные не внесены");
                db.closeConnection();

            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }
    }
}
