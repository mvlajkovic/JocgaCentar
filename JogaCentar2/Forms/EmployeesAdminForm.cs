using JogaCentar.Controllers;
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

namespace JogaCentar.Forms
{
    public partial class EmployeesAdminForm : Form
    {
        #region UserData

        Account _AdminAccount = null;

        public Account AdminAccount
        {
            get
            {
                return _AdminAccount;
            }
            set
            {
                _AdminAccount = value;
                if (_AdminAccount == null || this._AdminAccount.AccountId <= 0)
                {
                    //panelLogin.Visible = true;
                    //lblWelcome.Visible = false;
                    //this.Text = _ApplicationTitle;
                    //this.IsValidLogin = false;
                    //this.btnLogout.Visible = false;

                }
                else
                {
                    //panelLogin.Visible = false;
                    //lblWelcome.Visible = true;
                    //lblWelcome.Text = "Welcome " + UserAccount.ToString();
                    //this.Text = _ApplicationTitle + " (" + UserAccount.Username.ToString() + ")";
                    //this.IsValidLogin = AuthUser.IsValidLogin(this.UserAccount);
                    //this.btnLogout.Visible = true;

                    //if (_UserAccount.StatusId != (int)AccountStatus_Enum.Active)
                    //{
                    //    lblWelcome.Text += Environment.NewLine + "[Account NOT Active!]";
                    //}
                }
            }

        }

        public bool IsValidLogin { get => _IsValidLogin; private set => _IsValidLogin = value; }

        private bool _IsValidLogin = false;

        private bool _IsEmployee = false;
        private bool _IsAdmin = false;
        private bool _IsOwner = false;
        private bool _IsTrainer = false;

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

        #endregion UserData

        #region From DATA

        public List<Employee> EmployeeList { get => _EmployeeList; set => _EmployeeList = value; }

        List<Employee> _EmployeeList = new List<Employee>();

        Employee _SelectedEmployee = null;


        public string ResultMessage { get => _ResultMessage; set => _ResultMessage = value; }

        String _ResultMessage = "";

        #endregion From DATA
        public EmployeesAdminForm(Account adminAccount)
        {
            InitializeComponent();

            this.AdminAccount = adminAccount;

            LoadData();

            ValidateUser();
        }

        public void LoadUserRoles()
        {
            UserAccount_Roles = new List<string>();

            this._IsEmployee = false;

            this._IsAdmin = false;
            this._IsOwner = false;
            this._IsTrainer = false;

            if (this.AdminAccount != null && this.AdminAccount.TypeId == (int)AccountType_Enum.Employee)
            {
                Employee employee = AdminAccount.Employees.FirstOrDefault();
                UserAccount_Roles = EmployeeControler.GetEmployee_RoleValues(employee.EmployeeId);
                this._IsEmployee = true;

                if (this.UserAccount_Roles.Count > 0 && this.UserAccount_Roles.Contains("ADMIN"))
                {

                    this._IsAdmin = true;
                }

                if (this.UserAccount_Roles.Count > 0 && this.UserAccount_Roles.Contains("OWNER"))
                {

                    this._IsOwner = true;
                }

                if (this.UserAccount_Roles.Count > 0 && this.UserAccount_Roles.Contains("TRAINER"))
                {

                    this._IsTrainer = true;
                }
                

                if (this._IsOwner || this._IsAdmin)
                {

                    this.IsValidLogin = true;
                }
            }
            else
            {
                this._IsEmployee = false;

                this._IsAdmin = false;
                this._IsOwner = false;
                this._IsTrainer = false;
                this.IsValidLogin = false;
            }
        }


        public void ValidateUser()
        {
            LoadUserRoles();


            if (AdminAccount == null || !IsValidLogin)
            {
                this.groupBox1.Visible = false;
            }
            else
            {

                if (this._IsOwner || this._IsAdmin)
                {

                    this.groupBox1.Visible = true;

                    if (this._IsOwner)
                        this.BackgroundImage = global::JogaCentar.Properties.Resources.ownerBG;
                    else
                        this.BackgroundImage = global::JogaCentar.Properties.Resources.adminBG;
                    

                }
                else
                {
                    this.BackgroundImage = global::JogaCentar.Properties.Resources.userBG;
                }
                

                if (!this._IsOwner)
                {

                    this.txtSalary.Visible = false;
                    //this.BackgroundImage = global::JogaCentar.Properties.Resources.ownerBG;
                }

            }
            //this.Refresh();
        }
        public void LoadData()
        {
            EmployeeList = EmployeeControler.GetEmployees();
            this.bindingSourceEmployees.DataSource = EmployeeList;

            List<Role>  roles = EmployeeControler.GetRoles();
            this.bindingSourceRoles.DataSource = roles;


            if (EmployeeList != null && EmployeeList.Count > 0)
            {
                //button2.Enabled = true;
                lblNoData.Visible = false;
            }
            else
            {
                //button2.Enabled = false;
                lblNoData.Visible = true;
            }
        }

        public void UpdateData()
        {
            _SelectedEmployee = (Employee)bindingSourceEmployees.Current;
            bindingSourceSelectedEmpl.DataSource = _SelectedEmployee;
            List<Employees_Roles> employeeRoles = new List<Employees_Roles>();
            
            if (_SelectedEmployee.Employees_Roles != null) employeeRoles = _SelectedEmployee.Employees_Roles.ToList();

            bindingSourceEmplRoles.DataSource = employeeRoles;
         
        }

        private void bindingSourceEmployees_CurrentChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //List<Employees_Roles> employeeRoles = (List<Employees_Roles>) _SelectedEmployee.Employees_Roles;
            Role role = comboBox1.SelectedItem as Role;
            bool found = false;
            string comment = textBoxComment.Text;
            foreach (Employees_Roles r in _SelectedEmployee.Employees_Roles)
            {
                if(r.RoleId == role.RoleId)
                {
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                DialogResult dr = MessageBox.Show("Add new role " + role.RoleName + "?", "Employee roles", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr==DialogResult.Yes)
                {
                    Employees_Roles newItem = EmployeeControler.AddRole(_SelectedEmployee.EmployeeId, role.RoleId, comment);
                    LoadData();
                    textBoxComment.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Role is already added!");
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Save Employee data" + _SelectedEmployee.ToString() + "?", "Employee change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Employee newItem = EmployeeControler.UpdateEmployee(_SelectedEmployee);
                LoadData();
                textBoxComment.Text = "";
            }
        }
    }
}
