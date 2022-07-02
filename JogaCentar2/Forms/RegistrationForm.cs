using JogaCentar.Controllers;
using JogaCentar.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YogaDBLibrary.Models;

namespace JogaCentar.Forms
{
    public partial class RegistrationForm : Form
    {
        private Boolean initialUsernameInput = true;
        private Boolean initialPassInput = true;
        private Boolean initialPhoneNumberInput = true;
        private Boolean initialEmailInput = true;
        private Boolean initialFirstNameInput = true;
        private Boolean initialLastNameInput = true;

        private Account _UserAccount = null;
        public  Account UserAccount { get => _UserAccount; private set => _UserAccount = value; }

        public RegistrationForm(string welcomeMsg = null)
        {
            InitializeComponent();

            this.UserAccount = new Account();
            this.bindingSourceNewAccount.DataSource = this.UserAccount;

            if(welcomeMsg != null) this.welcomeLabel.Text = welcomeMsg;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            //CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string resultMsg = "";
            Account tmpAccount  = (Account) this.bindingSourceNewAccount.DataSource;

            this.UserAccount  =  AuthUser.RegisterNew(tmpAccount, out resultMsg);

            if(tmpAccount != null)
            {
                MessageBox.Show("New account registered!"+Environment.NewLine+"Please LogIn using your email and password!", "Thank You", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else 
            {
                MessageBox.Show(resultMsg, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        // Workaround for placeholders
        private void userNameTextBox_Focus_Change(object sender, EventArgs e)
        {
            if (initialUsernameInput)
            {
                userNameTextBox.Text = string.Empty;

                initialUsernameInput = false;
            }
            else if (userNameTextBox.Text == string.Empty)
            {
                userNameTextBox.Text = "Username / Email";
                initialUsernameInput = true;
            }
        }

        // Workaround for placeholders
        private void passwordTextBox_Focus_Change(object sender, EventArgs e)
        {
            if (initialPassInput)
            {
                passwordTextBox.Text = string.Empty;

                initialPassInput = false;
            }
            else if (passwordTextBox.Text == string.Empty)
            {
                passwordTextBox.Text = "Password";
                initialPassInput = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.UserAccount = null;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void phoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (initialPhoneNumberInput)
            {
                phoneNumberTextBox.Text = string.Empty;

                initialPhoneNumberInput = false;
            }
            else if (phoneNumberTextBox.Text == string.Empty)
            {
                phoneNumberTextBox.Text = "Phone Number";
                initialPhoneNumberInput = true;
            }
        }

        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (initialLastNameInput)
            {
                lastNameTextBox.Text = string.Empty;

                initialLastNameInput = false;
            }
            else if (lastNameTextBox.Text == string.Empty)
            {
                lastNameTextBox.Text = "Last Name";
                initialLastNameInput = true;
            }
        }

        private void firstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (initialFirstNameInput)
            {
                firstNameTextBox.Text = string.Empty;

                initialFirstNameInput = false;
            }
            else if (firstNameTextBox.Text == string.Empty)
            {
                firstNameTextBox.Text = "Last Name";
                initialFirstNameInput = true;
            }
        }


    }
}
