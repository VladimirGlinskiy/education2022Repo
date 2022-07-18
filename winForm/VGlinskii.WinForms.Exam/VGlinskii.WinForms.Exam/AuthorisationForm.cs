using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VGlinskii.WinForms.Exam
{
    public partial class AuthorisationForm : Form
    {
        public AuthorisationForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (LoginBox.Text == "" && PasswordBox.Text == "")
            {
                errorLabel.Text = "Please, type your login and password";
            }

            else if(LoginBox.Text == "") {
                errorLabel.Text = "Please, type your login";
            }

            else if (PasswordBox.Text == "") {
                errorLabel.Text = "Please, type your password";
            }

            else {
                if (ConnectionHelpers.checkLoginPassword(LoginBox.Text, PasswordBox.Text))

                {
                    KartinkerForm kartinkerForm = new KartinkerForm();
                    kartinkerForm.Show();
                    
                }
                else {
                    errorLabel.Text = "Incorrect login or password \nPlease, check your credetials and try again";
                }
            } 
        }

        private void LoginBox_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void AuthorisationForm_Load(object sender, EventArgs e)
        {

        }

        private void AuthorisationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
