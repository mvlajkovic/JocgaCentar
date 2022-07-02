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
    public partial class NewSubscription : Form
    {
        Subscription _Subscription = new Subscription();
        public Subscription Subscription { get => _Subscription; set => _Subscription = value; }

        public NewSubscription()
        {
            InitializeComponent();

            Subscription = new Subscription();
            Subscription.Number_of_Trainings = 1;
            Subscription.SubscriptionStatusId = (int)SubscriptionStatus_Enum.Active;
            Subscription.Comment = "";

            bindingSourceSelectedSub.DataSource = Subscription;

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


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
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
