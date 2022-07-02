namespace JogaCentar.Forms
{
    partial class NewTraining
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
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trainerLabel = new System.Windows.Forms.Label();
            this.treatmentLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.trainerComboBox = new System.Windows.Forms.ComboBox();
            this.treatmentComboBox = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.bindingSourceSelectedTraining = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTrainers = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTreatments = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceHours = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTrainingStatuses = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelectedTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTreatments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrainingStatuses)).BeginInit();
            this.SuspendLayout();
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.label2);
            this.addGroupBox.Controls.Add(this.textBox1);
            this.addGroupBox.Controls.Add(this.comboBox2);
            this.addGroupBox.Controls.Add(this.label1);
            this.addGroupBox.Controls.Add(this.comboBox1);
            this.addGroupBox.Controls.Add(this.trainerLabel);
            this.addGroupBox.Controls.Add(this.treatmentLabel);
            this.addGroupBox.Controls.Add(this.timeLabel);
            this.addGroupBox.Controls.Add(this.trainerComboBox);
            this.addGroupBox.Controls.Add(this.treatmentComboBox);
            this.addGroupBox.Controls.Add(this.timePicker);
            this.addGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBox.Location = new System.Drawing.Point(24, 85);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(374, 333);
            this.addGroupBox.TabIndex = 36;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Training info:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceSelectedTraining, "TrainingStatusId", true));
            this.comboBox2.DataSource = this.bindingSourceTrainingStatuses;
            this.comboBox2.DisplayMember = "Status_Description";
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(115, 158);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 21);
            this.comboBox2.TabIndex = 37;
            this.comboBox2.ValueMember = "StatusId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Status :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceSelectedTraining, "TrainingTime", true));
            this.comboBox1.DataSource = this.bindingSourceHours;
            this.comboBox1.DisplayMember = "Description";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(284, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "Hour";
            // 
            // trainerLabel
            // 
            this.trainerLabel.AutoSize = true;
            this.trainerLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerLabel.Location = new System.Drawing.Point(11, 42);
            this.trainerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trainerLabel.Name = "trainerLabel";
            this.trainerLabel.Size = new System.Drawing.Size(70, 18);
            this.trainerLabel.TabIndex = 18;
            this.trainerLabel.Text = "Trainer :";
            // 
            // treatmentLabel
            // 
            this.treatmentLabel.AutoSize = true;
            this.treatmentLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentLabel.Location = new System.Drawing.Point(11, 81);
            this.treatmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.treatmentLabel.Name = "treatmentLabel";
            this.treatmentLabel.Size = new System.Drawing.Size(97, 18);
            this.treatmentLabel.TabIndex = 19;
            this.treatmentLabel.Text = "Treatment :";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(11, 123);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(55, 18);
            this.timeLabel.TabIndex = 20;
            this.timeLabel.Text = "Date :";
            // 
            // trainerComboBox
            // 
            this.trainerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceSelectedTraining, "TrainerId", true));
            this.trainerComboBox.DataSource = this.bindingSourceTrainers;
            this.trainerComboBox.DisplayMember = "Account";
            this.trainerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerComboBox.FormattingEnabled = true;
            this.trainerComboBox.Location = new System.Drawing.Point(115, 43);
            this.trainerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.trainerComboBox.Name = "trainerComboBox";
            this.trainerComboBox.Size = new System.Drawing.Size(242, 21);
            this.trainerComboBox.TabIndex = 22;
            this.trainerComboBox.ValueMember = "EmployeeId";
            // 
            // treatmentComboBox
            // 
            this.treatmentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceSelectedTraining, "TreatmentId", true));
            this.treatmentComboBox.DataSource = this.bindingSourceTreatments;
            this.treatmentComboBox.DisplayMember = "Name";
            this.treatmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentComboBox.FormattingEnabled = true;
            this.treatmentComboBox.Location = new System.Drawing.Point(115, 82);
            this.treatmentComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.treatmentComboBox.Name = "treatmentComboBox";
            this.treatmentComboBox.Size = new System.Drawing.Size(242, 21);
            this.treatmentComboBox.TabIndex = 23;
            this.treatmentComboBox.ValueMember = "TreatmentId";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "yyyy.MM.dd";
            this.timePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceSelectedTraining, "TrainingDate", true));
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(115, 121);
            this.timePicker.Margin = new System.Windows.Forms.Padding(2);
            this.timePicker.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(121, 20);
            this.timePicker.TabIndex = 24;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(308, 445);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 32);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Add";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(90, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(192, 29);
            this.titleLabel.TabIndex = 39;
            this.titleLabel.Text = "New Training";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(32, 445);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 32);
            this.cancelButton.TabIndex = 40;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // bindingSourceSelectedTraining
            // 
            this.bindingSourceSelectedTraining.DataSource = typeof(YogaDBLibrary.Models.Training);
            // 
            // bindingSourceTrainers
            // 
            this.bindingSourceTrainers.DataSource = typeof(YogaDBLibrary.Models.Employee);
            // 
            // bindingSourceTreatments
            // 
            this.bindingSourceTreatments.DataSource = typeof(YogaDBLibrary.Models.Treatment);
            // 
            // bindingSourceHours
            // 
            this.bindingSourceHours.DataSource = typeof(YogaDBLibrary.ScheduleTime);
            // 
            // bindingSourceTrainingStatuses
            // 
            this.bindingSourceTrainingStatuses.DataSource = typeof(YogaDBLibrary.Models.Training_Statuses);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSelectedTraining, "Comment", true));
            this.textBox1.Location = new System.Drawing.Point(16, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 100);
            this.textBox1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Comment :";
            // 
            // NewTraining
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::JogaCentar.Properties.Resources.running;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(453, 509);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.saveButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewTraining";
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelectedTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTreatments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrainingStatuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label trainerLabel;
        private System.Windows.Forms.Label treatmentLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ComboBox trainerComboBox;
        private System.Windows.Forms.ComboBox treatmentComboBox;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource bindingSourceSelectedTraining;
        private System.Windows.Forms.BindingSource bindingSourceTrainers;
        private System.Windows.Forms.BindingSource bindingSourceTreatments;
        private System.Windows.Forms.BindingSource bindingSourceHours;
        private System.Windows.Forms.BindingSource bindingSourceTrainingStatuses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}