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
    public partial class FormAddingCinema : Form
    {
        public FormAddingCinema()
        {
            InitializeComponent();
        }

        private void FormAddingCinema_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTel_nomber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != null) && (textBoxAdress.Text != null) && (comboBoxAmount_hall.Text != null) && (textBoxTel_nomber.Text != null)
                && (richTextBoxNote.Text != null))
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `cinemas`(`name`, `adress`, `amount_hall`, `tel_nomber`, `note`) " +
                    "VALUES (@name,@adress,@amount_hall,@tel_nomber,@note)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.Text).Value = textBoxName.Text;
                command.Parameters.Add("@adress", MySqlDbType.VarChar).Value = textBoxAdress.Text;
                command.Parameters.Add("@amount_hall", MySqlDbType.Int32).Value = comboBoxAmount_hall.Text;
                command.Parameters.Add("@tel_nomber", MySqlDbType.VarChar).Value = textBoxTel_nomber.Text;
                command.Parameters.Add("@note", MySqlDbType.Text).Value = richTextBoxNote.Text;              

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно внесены");
                    textBoxName.Text = "";
                    textBoxAdress.Text = "";
                    comboBoxAmount_hall.Text = "";
                    textBoxTel_nomber.Text = "";
                    richTextBoxNote.Text = "";
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
