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
using YogaDBLibrary;
using YogaDBLibrary.Models;

namespace JogaCentar
{
    public partial class MainForm : Form
    {
        private string _ApplicationTitle = "Joga Center";

        #region UserData

        private void DummyLogin()
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                Account acc = db.Accounts.Where(i => i.AccountId == 1).FirstOrDefault();
                this.UserAccount = acc;
            }
        }

        List<string> _Employees_Roles = new List<string>();
        public List<string> UserAccount_Roles 
        { 
            get
            {
                return _Employees_Roles;
            }
            set
            {
                _Employees_Roles = value;
            }
        }

        Account _UserAccount = null;

        public Account UserAccount 
        { 
            get
            {
                return _UserAccount;
            }
            set
            {
                _UserAccount = value;
                if (_UserAccount == null || this.UserAccount.AccountId<=0)
                {
                    panelLogin.Visible = true;
                    lblWelcome.Visible = false;
                    this.Text = _ApplicationTitle;
                    this.IsValidLogin = false;
                    this.btnLogout.Visible = false;

                    panelButtons.Visible = false;

                }
                else
                {
                    panelLogin.Visible=false;
                    lblWelcome.Visible = true;
                    lblWelcome.Text = "Welcome "+UserAccount.ToString();
                    this.Text = _ApplicationTitle + " ("+UserAccount.Username.ToString()+")";
                    this.IsValidLogin = AuthUser.IsValidLogin(this.UserAccount);
                    this.btnLogout.Visible = true;

                    if(_UserAccount.StatusId != (int) AccountStatus_Enum.Active)
                    {
                        lblWelcome.Text +=Environment.NewLine +"[Account NOT Active!]";
                    }

                    if(_UserAccount.TypeId == (int) AccountType_Enum.Employee)
                    {
                        panelButtons.Visible = true;
                    }
                    else
                    {
                        panelButtons.Visible = false;
                    }
                }
            }

        }

        public bool IsValidLogin { get => _IsValidLogin; private set => _IsValidLogin = value; }
        

        private bool _IsValidLogin = false;


        private bool _IsEmployee = false;
        private bool _IsAdmin = false;
        private bool _IsOwner = false;
        private bool _IsTrainer = false;
        #endregion UserData


        public MainForm()
        {
            InitializeComponent();
            this.UserAccount = null;
            
        }

        #region Form Methods
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ExecuteLogin();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExecuteRegister();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            ExecuteLogout();
        }

        private void approveRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteApproveRequests();
        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployees();
        }

        #endregion Form Methods


        #region Admin Methods

        public void ManageEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            string msg = "";

            if (this.UserAccount != null && this.UserAccount.TypeId == (int)AccountType_Enum.Employee)
            {
                EmployeesAdminForm lf = new EmployeesAdminForm(this.UserAccount);

                DialogResult dr = lf.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    employeeList = lf.EmployeeList;
                    msg = lf.ResultMessage;
                    //Process pending accounts
                    //List<Account> approved = lf.ApprovedAccountsList;

                }
            }

            ValidateUser();

        }

        public void ExecuteApproveRequests()
        {
            List<Pending_Accounts> pendingAccountsList = new List<Pending_Accounts>();
            string msg = "";

            if (this.UserAccount != null && this.UserAccount.TypeId == (int) AccountType_Enum.Employee)
            {
                UserRequestsForm lf = new UserRequestsForm(this.UserAccount);

                DialogResult dr = lf.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    pendingAccountsList = lf.PendingAccountsList; 
                    //Process pending accounts
                    List<Account> approved = lf.ApprovedAccountsList;

                }
            }

            ValidateUser();

        }

        void ExecuteManageTreatments()
        {
            //List<Pending_Accounts> pendingAccountsList = new List<Pending_Accounts>();
            string msg = "";

            if (this.UserAccount != null && this.UserAccount.TypeId == (int)AccountType_Enum.Employee)
            {
                TreatmentsForm lf = new TreatmentsForm(this.UserAccount);

                DialogResult dr = lf.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    msg = lf.ResultMessage;
                    //Process pending accounts
                    //List<Account> approved = lf.ApprovedAccountsList;

                }
            }

            ValidateUser();
        }

        void ExecuteManageTrainings()
        {
            //List<Pending_Accounts> pendingAccountsList = new List<Pending_Accounts>();
            string msg = "";

            if (this.UserAccount != null && this.UserAccount.TypeId == (int)AccountType_Enum.Employee)
            {
                TrainingsForm lf = new TrainingsForm(this.UserAccount);

                DialogResult dr = lf.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    msg = lf.ResultMessage;
                    //Process pending accounts
                    //List<Account> approved = lf.ApprovedAccountsList;

                }
            }

            ValidateUser();
        }

        void ExecuteMabageSubscriptions()
        {
            string msg = "";

            if (this.UserAccount != null && this.UserAccount.TypeId == (int)AccountType_Enum.Employee)
            {
                SubscriptionsForm lf = new SubscriptionsForm(this.UserAccount);

                DialogResult dr = lf.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    msg = lf.ResultMessage;
                    //Process pending accounts
                    //List<Account> approved = lf.ApprovedAccountsList;

                }
            }

            ValidateUser();
        }

        #endregion Admin Methods

        #region Login Methods
        public void ExecuteLogin()
        {
            if (this.UserAccount == null)
            {
                LoginForm lf = new LoginForm("Hello user!");

                DialogResult dr = lf.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    this.UserAccount = lf.UserAccount;
                }
            }

            ValidateUser();

        }

        public void ExecuteLogout()
        {

            this.UserAccount = null;
            this.IsValidLogin = false;
            ValidateUser();
        }

        public void ExecuteRegister()
        {
            if (this.UserAccount == null)
            {
                RegistrationForm rf = new RegistrationForm();

                DialogResult dr = rf.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    this.UserAccount = rf.UserAccount;
                }
            }

            ValidateUser();
        }

        public void LoadUserRoles()
        {
            UserAccount_Roles = new List<string>();

            this._IsEmployee = false;

            this._IsAdmin = false;
            this._IsOwner = false;
            this._IsTrainer = false;

            if (this.UserAccount!= null &&  this.UserAccount.TypeId == (int)AccountType_Enum.Employee)
            {
                Employee employee = UserAccount.Employees.FirstOrDefault();
                UserAccount_Roles = EmployeeControler.GetEmployee_RoleValues(employee.EmployeeId);
                this._IsEmployee = true;

                if (this.UserAccount_Roles.Count > 0 && this.UserAccount_Roles.Contains("ADMIN"))
                {

                    this._IsAdmin= true;
                }

                if (this.UserAccount_Roles.Count > 0 && this.UserAccount_Roles.Contains("OWNER"))
                {

                    this._IsOwner = true;
                }

                if (this.UserAccount_Roles.Count > 0 && this.UserAccount_Roles.Contains("TRAINER"))
                {

                    this._IsTrainer = true;
                }

                this.IsValidLogin = true;
            }
            else
            {
                this._IsEmployee = false;

                this._IsAdmin = false;
                this._IsOwner = false;
                this._IsTrainer = false;

                if(this.UserAccount != null) this.IsValidLogin = true;
            }
        }

        public void ValidateUser()
        {
            LoadUserRoles();
            
            this.treatmentsButton.Enabled = false;
            this.attendanceButton.Enabled = false;
            this.trainingsButton.Enabled = false;
            this.clientsButton.Enabled = false;
            this.feesButton.Enabled = false;

            this.mainMenuStrip.Enabled = false;

            if (UserAccount == null || !IsValidLogin)
            {

                this.BackgroundImage = global::JogaCentar.Properties.Resources.loginBG;
            }
            else
            {

                if (this._IsOwner)
                {

                    this.treatmentsButton.Enabled = true;
                }

                if (this._IsAdmin)
                {
                    
                    this.mainMenuStrip.Enabled = true;


                    this.clientsButton.Enabled = true;
                    this.feesButton.Enabled = true;


                }

                if(this._IsTrainer)
                {
                    this.attendanceButton.Enabled = true;
                    this.trainingsButton.Enabled = true;
                }

                if (this._IsOwner || this._IsAdmin)
                {


                    if (this._IsOwner)
                        this.BackgroundImage = global::JogaCentar.Properties.Resources.ownerBG;
                    else
                        this.BackgroundImage = global::JogaCentar.Properties.Resources.adminBG;


                }
                else
                {                    
                    this.BackgroundImage = global::JogaCentar.Properties.Resources.userBG;
                }


            }
        }








        #endregion Login Methods

        #region Button Menu

        private void treatmentsButton_Click(object sender, EventArgs e)
        {
            ExecuteManageTreatments();
        }

        private void trainingsButton_Click(object sender, EventArgs e)
        {
            ExecuteManageTrainings();
        }

        private void feesButton_Click(object sender, EventArgs e)
        {
            ExecuteMabageSubscriptions();
        }

        #endregion BUttonMenu


    }
}
