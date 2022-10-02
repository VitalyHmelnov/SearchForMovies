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
    public partial class LoginForm : Form
    {
        private Form active;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if((textBoxLogin.Text=="")||(textBoxPass.Text==""))
            {
                MessageBox.Show("Заполните Логин и Пароль");
                textBoxLogin.Text = "";
                textBoxPass.Text = "";
            }
            else
            {
                DB db = new DB();
                
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND `pass` = @up", db.getConnection());
                command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = textBoxLogin.Text;
                command.Parameters.Add("@up", MySqlDbType.VarChar).Value = textBoxPass.Text;
              

                adapter.SelectCommand = command;
                adapter.Fill(table);

                
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    Form1admin f = new Form1admin();
                    f.ShowDialog();
                    this.Close();
                    vizovForm(new Form1admin());
                }
                else
                {
                    MessageBox.Show("Неправильный пароль или имя пользователя");
                    textBoxLogin.Text = "";
                    textBoxPass.Text = "";
                }
            }
            
        }
        private void vizovForm(Form fm)
        {
            if (active != null)
                active.Close();
            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            fm.BringToFront();
            fm.Show();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClient f = new FormClient();
            f.ShowDialog();
            this.Close();
            vizovForm(new FormClient());
        }
    }
}
