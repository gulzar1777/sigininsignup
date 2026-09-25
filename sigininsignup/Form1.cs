using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_in___Sign_up
{
    public partial class Form1 : Form
    {
        string savedUsername = "";
        string savedPassword = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (signUpUsername.Text == "" || signUpPassword.Text == "")
            {
                MessageBox.Show("Please enter username and password.");
            }
            else
            {
                savedUsername = signUpUsername.Text;
                savedPassword = signUpPassword.Text;

                MessageBox.Show("Sign up successful!");
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (savedUsername == "" || savedPassword == "")
            {
                MessageBox.Show("Please sign up first.");
            }
            else if (signInUsername.Text == savedUsername &&
                     signInPassword.Text == savedPassword)
            {
                MessageBox.Show("Sign in successful!");
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }
        }

        private void ShowSignInPassword_CheckedChanged(object sender, EventArgs e)
        {
            signInPassword.UseSystemPasswordChar = !showSignInPassword.Checked;
        }

        private void ShowSignUpPassword_CheckedChanged(object sender, EventArgs e)
        {
            signUpPassword.UseSystemPasswordChar = !showSignUpPassword.Checked;

        }
    }
}
