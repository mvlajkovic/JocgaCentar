namespace JogaCentar
{
    partial class MainForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approveRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.attendanceButton = new System.Windows.Forms.Button();
            this.feesButton = new System.Windows.Forms.Button();
            this.clientsButton = new System.Windows.Forms.Button();
            this.treatmentsButton = new System.Windows.Forms.Button();
            this.trainingsButton = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Violet;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(50, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 33);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.linkRegister);
            this.panelLogin.Controls.Add(this.lblNoAccount);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Location = new System.Drawing.Point(347, 251);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(200, 100);
            this.panelLogin.TabIndex = 14;
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Location = new System.Drawing.Point(98, 67);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(75, 13);
            this.linkRegister.TabIndex = 15;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Register Here!";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Location = new System.Drawing.Point(22, 67);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(70, 13);
            this.lblNoAccount.TabIndex = 14;
            this.lblNoAccount.Text = "No Account?";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Violet;
            this.lblWelcome.Location = new System.Drawing.Point(300, 363);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(310, 33);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Welcome User Name";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(801, 506);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 33);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approveRequestsToolStripMenuItem,
            this.manageEmployeesToolStripMenuItem});
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(178, 48);
            // 
            // approveRequestsToolStripMenuItem
            // 
            this.approveRequestsToolStripMenuItem.Name = "approveRequestsToolStripMenuItem";
            this.approveRequestsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.approveRequestsToolStripMenuItem.Text = "Approve Requests";
            this.approveRequestsToolStripMenuItem.Click += new System.EventHandler(this.approveRequestsToolStripMenuItem_Click);
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.manageEmployeesToolStripMenuItem.Text = "Manage Employees";
            this.manageEmployeesToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeesToolStripMenuItem_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.attendanceButton);
            this.panelButtons.Controls.Add(this.feesButton);
            this.panelButtons.Controls.Add(this.clientsButton);
            this.panelButtons.Controls.Add(this.treatmentsButton);
            this.panelButtons.Controls.Add(this.trainingsButton);
            this.panelButtons.Location = new System.Drawing.Point(55, 12);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(715, 527);
            this.panelButtons.TabIndex = 17;
            // 
            // attendanceButton
            // 
            this.attendanceButton.BackColor = System.Drawing.Color.RosyBrown;
            this.attendanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attendanceButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceButton.ForeColor = System.Drawing.Color.White;
            this.attendanceButton.Image = global::JogaCentar.Properties.Resources.analytics;
            this.attendanceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attendanceButton.Location = new System.Drawing.Point(25, 18);
            this.attendanceButton.Name = "attendanceButton";
            this.attendanceButton.Size = new System.Drawing.Size(573, 82);
            this.attendanceButton.TabIndex = 16;
            this.attendanceButton.Text = "Attendance";
            this.attendanceButton.UseVisualStyleBackColor = false;
            // 
            // feesButton
            // 
            this.feesButton.BackColor = System.Drawing.Color.RosyBrown;
            this.feesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feesButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesButton.ForeColor = System.Drawing.Color.White;
            this.feesButton.Image = global::JogaCentar.Properties.Resources.debit_card;
            this.feesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feesButton.Location = new System.Drawing.Point(25, 420);
            this.feesButton.Name = "feesButton";
            this.feesButton.Size = new System.Drawing.Size(573, 82);
            this.feesButton.TabIndex = 15;
            this.feesButton.Text = "Users Subscriptions";
            this.feesButton.UseVisualStyleBackColor = false;
            this.feesButton.Click += new System.EventHandler(this.feesButton_Click);
            // 
            // clientsButton
            // 
            this.clientsButton.BackColor = System.Drawing.Color.RosyBrown;
            this.clientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clientsButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsButton.ForeColor = System.Drawing.Color.White;
            this.clientsButton.Image = global::JogaCentar.Properties.Resources.man;
            this.clientsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsButton.Location = new System.Drawing.Point(25, 320);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(573, 82);
            this.clientsButton.TabIndex = 14;
            this.clientsButton.Text = "Clients";
            this.clientsButton.UseVisualStyleBackColor = false;
            // 
            // treatmentsButton
            // 
            this.treatmentsButton.BackColor = System.Drawing.Color.RosyBrown;
            this.treatmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.treatmentsButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentsButton.ForeColor = System.Drawing.Color.White;
            this.treatmentsButton.Image = global::JogaCentar.Properties.Resources.spa;
            this.treatmentsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.treatmentsButton.Location = new System.Drawing.Point(25, 218);
            this.treatmentsButton.Name = "treatmentsButton";
            this.treatmentsButton.Size = new System.Drawing.Size(573, 84);
            this.treatmentsButton.TabIndex = 13;
            this.treatmentsButton.Text = "Treatments";
            this.treatmentsButton.UseVisualStyleBackColor = false;
            this.treatmentsButton.Click += new System.EventHandler(this.treatmentsButton_Click);
            // 
            // trainingsButton
            // 
            this.trainingsButton.BackColor = System.Drawing.Color.RosyBrown;
            this.trainingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trainingsButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingsButton.ForeColor = System.Drawing.Color.White;
            this.trainingsButton.Image = global::JogaCentar.Properties.Resources.running;
            this.trainingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trainingsButton.Location = new System.Drawing.Point(25, 117);
            this.trainingsButton.Name = "trainingsButton";
            this.trainingsButton.Size = new System.Drawing.Size(573, 84);
            this.trainingsButton.TabIndex = 12;
            this.trainingsButton.Text = "Training Schedule";
            this.trainingsButton.UseVisualStyleBackColor = false;
            this.trainingsButton.Click += new System.EventHandler(this.trainingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogaCentar.Properties.Resources.loginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 551);
            this.ContextMenuStrip = this.mainMenuStrip;
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ContextMenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem approveRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button attendanceButton;
        private System.Windows.Forms.Button feesButton;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button treatmentsButton;
        private System.Windows.Forms.Button trainingsButton;
    }
}

