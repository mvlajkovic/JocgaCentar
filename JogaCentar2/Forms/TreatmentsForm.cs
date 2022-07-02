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
    public partial class TreatmentsForm : Form
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


                }
                else
                {

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

        public List<Treatment> TreatmentList { get => _TreatmentList; set => _TreatmentList = value; }

        List<Treatment> _TreatmentList = new List<Treatment>();

        Treatment _SelectedTreatment = null;
        public Treatment SelectedTreatment 
        {
            get
            {
                return _SelectedTreatment;
            }
            set
            {
                _SelectedTreatment = value;
                if(_SelectedTreatment == null)
                {
                    updateButton.Enabled = false;
                }
                else
                {
                    updateButton.Enabled = true;
                }
            }
        }


        public string ResultMessage { get => _ResultMessage; set => _ResultMessage = value; }
 
        String _ResultMessage = "";

        #endregion From DATA

        public TreatmentsForm(Account userAccount)
        {
            InitializeComponent();

            this.AdminAccount = userAccount;

            ValidateUser();

            //treatmentsDataGridView.AutoGenerateColumns = true;

            ReloadData();
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
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            /*
            Form dashForm = new DashboardForm();

            Hide();

            dashForm.Show();
            */
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Treatment treatment = SelectedTreatment;

            if(treatment!=null)
                TreatmentController.UpdateTreatment(treatment);

            ReloadData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            using(NewTreatment lf = new NewTreatment())
            {
                DialogResult dr = lf.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    Treatment treatment = lf.Treatment;
                    if(treatment.Name!=null && treatment.Name.Trim()!="")
                    {
                        TreatmentController.AddTreatment(treatment);
                    }
                    else
                    {
                        MessageBox.Show("Please enter threatment Name", "Net Threatment", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    
                }
            }



            ReloadData();
        }

        private void TreatmentsForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        public void UpdateData()
        {
            SelectedTreatment = (Treatment)bindingSourceTreatments.Current;
            bindingSourceSelectedThreatment.DataSource = SelectedTreatment;


        }

        private void ReloadData()
        {
            TreatmentList = TreatmentController.GetTreatments();
            bindingSourceTreatments.DataSource = TreatmentList;


            //treatmentComboBox.DataSource = TreatmentController.GetTreatments();

            //treatmentsDataGridView.DataSource = TreatmentController.GetTreatments();

            //treatmentsDataGridView.Columns["Subscriptions"].Visible = false;
            //treatmentsDataGridView.Columns["Trainings"].Visible = false;

            // we do this so it's empty by default
            treatmentComboBox.SelectedIndex = -1;
        }

        private void priceTextBox_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(priceTextBox.Text, @"^\d+\.?\d*$"))
            {
                MessageBox.Show("Invalid price input.");
                priceTextBox.Text = "0";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (treatmentComboBox.SelectedIndex != -1)
            {
                if (treatmentComboBox.SelectedItem is Treatment)
                {
                    int id = ((Treatment)treatmentComboBox.SelectedItem).TreatmentId;

                    TreatmentController.DeleteTreatment(id);

                    ReloadData();
                }
            }
        }

        private void treatmentsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            /*
            nameTextBox.Text = treatmentsDataGridView.CurrentRow.Cells["Name"].Value.ToString();
            priceTextBox.Text = treatmentsDataGridView.CurrentRow.Cells["Price"].Value.ToString();
            descriptionTextBox.Text = treatmentsDataGridView.CurrentRow.Cells["Description"].Value.ToString();
            */
        }

        private void bindingSourceTreatments_CurrentChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
