using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Кино.Удаление;

namespace Кино
{
    public partial class Form1admin : Form
    {
        private Form active;
        public Form1admin()
        {
            InitializeComponent();
            
        }

        private void comboBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Фильм")
            {
                PanelForm(new FormAddingFilm());
                
            }
            if (comboBox1.Text == "Кинотеатр")
            {
                PanelForm(new FormAddingCinema());

            }
            if (comboBox1.Text == "Киносеанс")
            {
                PanelForm(new FormAddingSessions());

            }
        }

        private void PanelForm(Form fm)
        {
            if (active != null)
                active.Close();
            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.BringToFront();
            fm.Show();
        }

        private void Panel2Form(Form fm)
        {
            if (active != null)
                active.Close();
            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fm);
            this.panel2.Tag = fm;
            fm.BringToFront();
            fm.Show();
        }


        private void comboBox2_MouseCaptureChanged(object sender, EventArgs e)
        {
            string data = comboBox2.Text;

            if (comboBox2.Text == "Фильм")
            {
                Panel2Form(new FormDeleteFilm());

            }
            if (comboBox2.Text == "Кинотеатр")
            {
                Panel2Form(new FormDeleteCinema());

            }
            if (comboBox2.Text == "Киносеанс")
            {
                Panel2Form(new FormDeleteSessions());

            }
        }
    }
}
