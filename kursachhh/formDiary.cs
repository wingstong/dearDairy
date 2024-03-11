using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursachhh
{
    public partial class formDiary : Form
    {
        public formDiary()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH.mm \ndd.MM.yyyy");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Выйти из дневника?", ":(", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                formLogin signInForm = new formLogin();
                signInForm.Show();
                this.Hide();
            }
        }
    }
}

