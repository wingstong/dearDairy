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
    public partial class formSignUp : Form
    {
        public formSignUp()
        {
            textBoxName.Text = "name";
            textBoxPsswrd.Text = "psswrd";
            textBoxName.Text = "email";
            textBoxName.GotFocus += TextBoxName_GotFocus;
            textBoxName.LostFocus += TextBoxName_LostFocus;
            textBoxPsswrd.GotFocus += TextBoxPassword_GotFocus;
            textBoxPsswrd.LostFocus += TextBoxPassword_LostFocus;
        }

        private void TextBoxEmail_GotFocus(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "email")
            {
                textBoxEmail.Text = "";
            }
        }

        private void TextBoxEmail_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                textBoxName.Text = "email";
            }
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
            }
        }

        private void TextBoxPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPsswrd.Text))
            {
                textBoxPsswrd.Text = "psswrd";
            }
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Аккаунт успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            formDiary appForm = new formDiary();
            appForm.Show();
            this.Hide();
        }

        private void backSignInButton_Click(object sender, EventArgs e)
        {
            formLogin signInForm = new formLogin();
            signInForm.Show();
            this.Hide();
        }
    }

}
