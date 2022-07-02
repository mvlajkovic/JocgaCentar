using JogaCentar.Controllers;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YogaDBLibrary;
using YogaDBLibrary.Models;


namespace JogaCentar.Forms
{
    public partial class SubscriptionsForm : Form
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

        public List<Subscription> SubscriptionList { get => _SubscriptionList; set => _SubscriptionList = value; }

        List<Subscription> _SubscriptionList = new List<Subscription>();

        Subscription _SelectedSubscription = null;
        public Subscription SelectedSubscription
        {
            get
            {
                return _SelectedSubscription;
            }
            set
            {
                _SelectedSubscription = value;
                if (_SelectedSubscription == null)
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


        public SubscriptionsForm(Account userAccount)
        {
            InitializeComponent();

            this.AdminAccount = userAccount;
            ValidateUser();

            ///subscriptionsDataGridView.AutoGenerateColumns = true;

            ReloadData();
        }

        public void ValidateUser()
        {
            LoadUserRoles();
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

        private void SubscriptionsForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void subscriptionsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            //int treatmentId = Convert.ToInt32(subscriptionsDataGridView.CurrentRow.Cells["TreatmentId"].Value);
            //Treatment selectedTreatment = TreatmentController.GetTreatmentById(treatmentId);

            //treatmentComboBox.Text = selectedTreatment.ToString();

            //treatmentNoComboBox.SelectedIndex = Convert.ToInt32(subscriptionsDataGridView.CurrentRow.Cells["SubscriptionTreatmentNo"].Value) - 1;

            //paidTrueRadioButton.Checked = (bool)subscriptionsDataGridView.CurrentRow.Cells["SubscriptionStatus"].Value;
            //paidFalseRadioButton.Checked = !paidTrueRadioButton.Checked;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Subscription subscription = SelectedSubscription;
            if (subscription != null)
                SubscriptionsController.UpdateSubscription(subscription);

            ReloadData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //int treatmentId = ((Treatment)treatmentComboBox.SelectedItem).TreatmentId;
            //int treatmentNo = treatmentNoComboBox.SelectedIndex + 1;

            //SubscriptionsController.AddSubscription(treatmentId, treatmentNo, paidTrueRadioButton.Checked);

            using (NewSubscription lf = new NewSubscription())
            {
                DialogResult dr = lf.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Subscription subscription = lf.Subscription;
                    if (subscription != null)
                    {
                        try
                        {
                            SubscriptionsController.AddSubscription(subscription);
                        }
                        catch (DbEntityValidationException ex2)
                        {
                            var newException = new FormattedDbEntityValidationException(ex2);


                            MessageBox.Show(newException.Message, "Net Subsccription Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Exception, User can't enter the same Treatment more tha once!", "Net Subsccription Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Please enter all subscription Data", "Net Subsccription", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
            }


            ReloadData();
        }

        private void ReloadData()
        {
            //treatmentComboBox.DataSource = TreatmentController.GetTreatments();

            SelectedSubscription = null;
            treatmentComboBox.SelectedIndex = -1;
            //treatmentNoComboBox.SelectedIndex = -1;

            List<Treatment> treatments = new List<Treatment>();
            treatments = TreatmentController.GetTreatments();
            bindingSourceTreatments.DataSource = treatments;

            List<Subscription_Statuses> subStatuses = new List<Subscription_Statuses>();
            subStatuses = SubscriptionsController.Get_Subscription_Statuses();
            bindingSourceSubStatus.DataSource = subStatuses;

            List<User> users = new List<User>();
            users = SubscriptionsController.GetUsers();
            bindingSourceUsers.DataSource = users;

            SubscriptionList = SubscriptionsController.GetSubscriptions();
            bindingSourceSubscriptions.DataSource = SubscriptionList;

            //subscriptionsDataGridView.DataSource = SubscriptionsController.GetSubscriptions();

            //subscriptionsDataGridView.Columns["Treatment"].Visible = false;
            //subscriptionsDataGridView.Columns["User"].Visible = false;
        }

        private void treatmentNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (treatmentComboBox.SelectedIndex == -1 || treatmentNoComboBox.SelectedIndex == -1)
            //{
            //    return;
            //}

            //int treatmentId = ((Treatment)treatmentComboBox.SelectedItem).TreatmentId;
            //int numOfTreatments = treatmentNoComboBox.SelectedIndex + 1;

            //decimal treatmentPrice = TreatmentController.GetTreatmentById(treatmentId).Price;

            //priceLabel.Text = (treatmentPrice * numOfTreatments).ToString();
        }

        private void trainerLabel_Click(object sender, EventArgs e)
        {

        }

        private void treatmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSourceSubscriptions_CurrentChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        public void UpdateData()
        {
            SelectedSubscription = (Subscription)bindingSourceSubscriptions.Current;
            bindingSourceSelectedSub.DataSource = SelectedSubscription;


        }
    }
}
