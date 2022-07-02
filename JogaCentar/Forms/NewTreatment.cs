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
    public partial class NewTreatment : Form
    {
        Treatment _Treatment = new Treatment();

        public Treatment Treatment { get => _Treatment; set => _Treatment = value; }

        public NewTreatment()
        {
            InitializeComponent();
            Treatment = new Treatment();
            bindingSourceSelectedThreatment.DataSource = Treatment;
        }

        

        private void saveButton_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void priceTextBox_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(priceTextBox.Text, @"^\d+\.?\d*$"))
            {
                MessageBox.Show("Invalid price input.");
                priceTextBox.Text = "0";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
