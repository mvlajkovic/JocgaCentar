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
    public partial class NewTraining : Form
    {
        Training _Training = new Training();

        public Training Training { get => _Training; set => _Training = value; }

        public NewTraining()
        {
            InitializeComponent();
            Training = new Training();
            Training.TrainingStatusId = (int)TrainingStatus_Enum.Scheduled;
            Training.TrainingDate = DateTime.Now.Date;
            Training.TrainingTime = 10;
            Training.Comment = "";

            bindingSourceSelectedTraining.DataSource = Training;

            List<Employee> trainers = new List<Employee>();
            trainers = TrainerController.GetTrainers();
            bindingSourceTrainers.DataSource = trainers;

            List<Treatment> treatments = new List<Treatment>();
            treatments = TreatmentController.GetTreatments();
            bindingSourceTreatments.DataSource = treatments;

            List<ScheduleTime> hours = TrainingController.GetScheduleHours();
            bindingSourceHours.DataSource = hours;

            List<Training_Statuses> trainingStatuses = new List<Training_Statuses>();
            trainingStatuses = TrainingController.Get_Training_Statuses();
            bindingSourceTrainingStatuses.DataSource = trainingStatuses;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Training tr = (Training)bindingSourceSelectedTraining.DataSource;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
