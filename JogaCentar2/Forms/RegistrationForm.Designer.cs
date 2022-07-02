namespace JogaCentar.Forms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.bindingSourceNewAccount = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNewAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Red;
            this.welcomeLabel.Location = new System.Drawing.Point(34, 9);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(583, 55);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Yoga Center";
            this.welcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNewAccount, "Email", true));
            this.userNameTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.userNameTextBox.Location = new System.Drawing.Point(226, 295);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.userNameTextBox.TabIndex = 4;
            this.userNameTextBox.Text = "Username / Email";
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameTextBox.Enter += new System.EventHandler(this.userNameTextBox_Focus_Change);
            this.userNameTextBox.Leave += new System.EventHandler(this.userNameTextBox_Focus_Change);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.SlateBlue;
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(44, 367);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 41);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Submit";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNewAccount, "Password", true));
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.passwordTextBox.Location = new System.Drawing.Point(226, 319);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(185, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Focus_Change);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Focus_Change);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.SlateBlue;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(487, 367);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 41);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNewAccount, "FirstName", true));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.firstNameTextBox.Location = new System.Drawing.Point(226, 189);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Text = "First Name";
            this.firstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstNameTextBox.Enter += new System.EventHandler(this.firstNameTextBox_Enter);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNewAccount, "LastName", true));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.lastNameTextBox.Location = new System.Drawing.Point(226, 222);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Text = "Last Name";
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastNameTextBox.Enter += new System.EventHandler(this.lastNameTextBox_Enter);
            this.lastNameTextBox.Leave += new System.EventHandler(this.lastNameTextBox_Enter);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNewAccount, "PhoneNumber", true));
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(226, 259);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(185, 20);
            this.phoneNumberTextBox.TabIndex = 3;
            this.phoneNumberTextBox.Text = "Phone Number";
            this.phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneNumberTextBox.Enter += new System.EventHandler(this.phoneNumberTextBox_Enter);
            this.phoneNumberTextBox.Leave += new System.EventHandler(this.phoneNumberTextBox_Enter);
            // 
            // bindingSourceNewAccount
            // 
            this.bindingSourceNewAccount.DataSource = typeof(YogaDBLibrary.Models.Account);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogaCentar.Properties.Resources.registerBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(649, 432);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.welcomeLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNewAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.BindingSource bindingSourceNewAccount;
    }
}