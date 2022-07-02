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
    public partial class LoginForm : Form
    {
        private Boolean initialUsernameInput = true;
        private Boolean initialPassInput = true;

        private Account _UserAccount = null;
        public  Account UserAccount { get => _UserAccount; private set => _UserAccount = value; }

        public LoginForm(string welcomeMsg = null)
        {
            InitializeComponent();

            if(welcomeMsg != null) this.welcomeLabel.Text = welcomeMsg;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.UserAccount = AuthUser.GetAccount(userNameTextBox.Text.Trim(), passwordTextBox.Text.Trim());

            if(this.UserAccount != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else 
            {
                MessageBox.Show("Wrong username or password!", "Alert", MessageBoxButtons.OK);
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
                userNameTextBox.Text = "Username";
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
    }
}
