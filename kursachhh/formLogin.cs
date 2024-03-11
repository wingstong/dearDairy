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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            textBoxName.Text = "name";
            textBoxPsswrd.Text = "psswrd";
            textBoxName.GotFocus += TextBoxName_GotFocus;
            textBoxName.LostFocus += TextBoxName_LostFocus;
            textBoxPsswrd.GotFocus += TextBoxPassword_GotFocus;
            textBoxPsswrd.LostFocus += TextBoxPassword_LostFocus;
        }

        private void TextBoxName_GotFocus(object sender, EventArgs e)
        {
            if (textBoxName.Text == "name")
            {
                textBoxName.Text = ""; 
            }
        }

        private void TextBoxName_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                textBoxName.Text = "name"; 
            }
        }

        private void TextBoxPassword_GotFocus(object sender, EventArgs e)
        {
            if (textBoxPsswrd.Text == "psswrd")
            {
                textBoxPsswrd.Text = ""; 
                textBoxPsswrd.PasswordChar = '*'; 
            }
        }

        private void TextBoxPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPsswrd.Text))
            {
                textBoxPsswrd.Text = "psswrd";
            }
        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            string username = textBoxName.Text;
            string password = textBoxPsswrd.Text;

            // Проверка введенных данных и авторизация пользователя

            formDiary appForm = new formDiary();
            appForm.Show();
            this.Hide();
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            formSignUp registerForm = new formSignUp();
            registerForm.Show();
            this.Hide();
        }
    }
}