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
    public partial class TrainingsForm : Form
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

        public List<Training> TrainingList { get => _TrainingList; set => _TrainingList = value; }

        List<Training> _TrainingList = new List<Training>();

        Training _SelectedTraining = null;
        public Training SelectedTraining
        {
            get
            {
                return _SelectedTraining;
            }
            set
            {
                _SelectedTraining = value;
                if (_SelectedTraining == null)
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



        public TrainingsForm(Account userAccount)
        {
            InitializeComponent();

            this.AdminAccount = userAccount;
            ValidateUser();

            //trainingDataGridView.AutoGenerateColumns = true;

            timePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";

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

        private void TrainingsForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            using (NewTraining lf = new NewTraining())
            {
                DialogResult dr = lf.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Training training = lf.Training;
                    if (training != null)
                    {
                        TrainingController.AddTraining(training);
                    }
                    else
                    {
                        MessageBox.Show("Please enter threatment Name", "Net Threatment", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
            }


            

            ReloadData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Training training = SelectedTraining;
            if (training != null)
                TrainingController.UpdateTraining(training);



            ReloadData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (trainingComboBox.SelectedIndex != -1)
            {
                if (trainingComboBox.SelectedItem is Training)
                {
                    int id = ((Training)trainingComboBox.SelectedItem).TrainingId;

                    TrainingController.DeleteTraining(id);

                    ReloadData();
                }
            }
        }

        private void trainingDataGridView_DoubleClick(object sender, EventArgs e)
        {
            //int trainerId = Convert.ToInt32(trainingDataGridView.CurrentRow.Cells["TrainerId"].Value);
            //Trainer selectedTrainer = TrainerController.GetTrainerById(trainerId);

            //trainerComboBox.Text = selectedTrainer.ToString();

            //int treatmentId = Convert.ToInt32(trainingDataGridView.CurrentRow.Cells["TreatmentId"].Value);
            //Treatment selectedTreatment = TreatmentController.GetTreatmentById(treatmentId);

            //treatmentComboBox.Text = selectedTreatment.ToString();

            //DateTime time = Convert.ToDateTime(trainingDataGridView.CurrentRow.Cells["TrainingDateTime"].Value.ToString());

            //timePicker.Value = time;
        }

        private void ReloadData()
        {
            SelectedTraining = null;
            trainerComboBox.SelectedIndex = -1;
            treatmentComboBox.SelectedIndex = -1;
            trainingComboBox.SelectedIndex = -1;

            List<Employee> trainers = new List<Employee>();
            trainers = TrainerController.GetTrainers();
            bindingSourceTrainers.DataSource = trainers;

            List<Treatment> treatments = new List<Treatment>();
            treatments = TreatmentController.GetTreatments();
            bindingSourceTreatments.DataSource = treatments;

            List<Training_Statuses> trainingStatuses = new List<Training_Statuses>();
            trainingStatuses = TrainingController.Get_Training_Statuses();
            bindingSourceTrainingStatuses.DataSource = trainingStatuses;

            List<ScheduleTime> hours = TrainingController.GetScheduleHours();
            bindingSourceHours.DataSource = hours;

            TrainingList = new List<Training>();
            TrainingList = TrainingController.GetTrainings();
            bindingSourceTrainings.DataSource = TrainingList;

            //bindingSourceSelectedTraining.DataSource = SelectedTraining;

            //trainerComboBox.DataSource = TrainerController.GetTrainers();
            //treatmentComboBox.DataSource = TreatmentController.GetTreatments();
            //trainingComboBox.DataSource = TrainingController.GetTrainings();

            //trainingDataGridView.DataSource = TrainingController.GetTrainings();

            //trainingDataGridView.Columns["Trainer"].Visible = false;
            //trainingDataGridView.Columns["Treatment"].Visible = false;

            // we do this so it's empty by default
  
        }

        private void bindingSourceTrainings_CurrentChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        public void UpdateData()
        {
            SelectedTraining = (Training)bindingSourceTrainings.Current;
            bindingSourceSelectedTraining.DataSource = SelectedTraining;


        }
    }
}
