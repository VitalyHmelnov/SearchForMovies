using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Кино.Клиент;

namespace Кино
{
    public partial class FormClient : Form
    {
        private Form active;
        public FormClient()
        {
            InitializeComponent();
        }

        private void comboBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Фильмах")
            {
                PanelForm(new FormInfFilms());
            }
            if (comboBox1.Text == "Киносеансах")
            {
                PanelForm(new FormInfSessions());
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
    }
}
