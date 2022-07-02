
namespace JogaCentar.Forms
{
    partial class TrainingsForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.trainingComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSourceTrainings = new System.Windows.Forms.BindingSource(this.components);
            this.trainingLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.bindingSourceSelectedTraining = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSourceTreatments = new System.Windows.Forms.BindingSource(this.components);
            this.trainerComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSourceTrainers = new System.Windows.Forms.BindingSource(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.treatmentLabel = new System.Windows.Forms.Label();
            this.trainerLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.trainingDataGridView = new System.Windows.Forms.DataGridView();
            this.trainingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingStatusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingStatusesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bindingSourceTrainingStatuses = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSourceHours = new System.Windows.Forms.BindingSource(this.components);
            this.deleteGroupBox = new System.Windows.Forms.GroupBox();
            this.alertLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelectedTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTreatments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataGridView)).BeginInit();
            this.addGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrainingStatuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHours)).BeginInit();
            this.deleteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(59, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(361, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Manage Training Sessions";
            // 
            // trainingComboBox
            // 
            this.trainingComboBox.DataSource = this.bindingSourceTrainings;
            this.trainingComboBox.DisplayMember = "TrainingId";
            this.trainingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingComboBox.FormattingEnabled = true;
            this.trainingComboBox.Location = new System.Drawing.Point(115, 35);
            this.trainingComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.trainingComboBox.Name = "trainingComboBox";
            this.trainingComboBox.Size = new System.Drawing.Size(242, 21);
            this.trainingComboBox.TabIndex = 30;
            this.trainingComboBox.ValueMember = "TrainingId";
            // 
            // bindingSourceTrainings
            // 
            this.bindingSourceTrainings.DataSource = typeof(YogaDBLibrary.Models.Training);
            this.bindingSourceTrainings.CurrentChanged += new System.EventHandler(this.bindingSourceTrainings_CurrentChanged);
            // 
            // trainingLabel
            // 
            this.trainingLabel.AutoSize = true;
            this.trainingLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingLabel.Location = new System.Drawing.Point(11, 35);
            this.trainingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trainingLabel.Name = "trainingLabel";
            this.trainingLabel.Size = new System.Drawing.Size(76, 18);
            this.trainingLabel.TabIndex = 29;
            this.trainingLabel.Text = "Training :";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(259, 74);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 32);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(259, 264);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 32);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Add";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "yyyy.MM.dd";
            this.timePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceSelectedTraining, "TrainingDate", true));
            this.timePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSelectedTraining, "TrainingDate", true));
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(115, 121);
            this.timePicker.Margin = new System.Windows.Forms.Padding(2);
            this.timePicker.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(121, 20);
            this.timePicker.TabIndex = 24;
            // 
            // bindingSourceSelectedTraining
            // 
            this.bindingSourceSelectedTraining.DataSource = typeof(YogaDBLibrary.Models.Training);
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
            // bindingSourceTreatments
            // 
            this.bindingSourceTreatments.DataSource = typeof(YogaDBLibrary.Models.Treatment);
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
            // bindingSourceTrainers
            // 
            this.bindingSourceTrainers.DataSource = typeof(YogaDBLibrary.Models.Employee);
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
            // backButton
            // 
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(804, 14);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(106, 32);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(115, 264);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(98, 32);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Save";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // trainingDataGridView
            // 
            this.trainingDataGridView.AllowUserToAddRows = false;
            this.trainingDataGridView.AllowUserToDeleteRows = false;
            this.trainingDataGridView.AutoGenerateColumns = false;
            this.trainingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainingIdDataGridViewTextBoxColumn,
            this.treatmentIdDataGridViewTextBoxColumn,
            this.trainerIdDataGridViewTextBoxColumn,
            this.trainingDateDataGridViewTextBoxColumn,
            this.trainingTimeDataGridViewTextBoxColumn,
            this.trainingStatusIdDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.trainingStatusesDataGridViewTextBoxColumn,
            this.treatmentDataGridViewTextBoxColumn});
            this.trainingDataGridView.DataSource = this.bindingSourceTrainings;
            this.trainingDataGridView.Location = new System.Drawing.Point(443, 63);
            this.trainingDataGridView.Name = "trainingDataGridView";
            this.trainingDataGridView.ReadOnly = true;
            this.trainingDataGridView.Size = new System.Drawing.Size(467, 445);
            this.trainingDataGridView.TabIndex = 34;
            this.trainingDataGridView.DoubleClick += new System.EventHandler(this.trainingDataGridView_DoubleClick);
            // 
            // trainingIdDataGridViewTextBoxColumn
            // 
            this.trainingIdDataGridViewTextBoxColumn.DataPropertyName = "TrainingId";
            this.trainingIdDataGridViewTextBoxColumn.HeaderText = "TrainingId";
            this.trainingIdDataGridViewTextBoxColumn.Name = "trainingIdDataGridViewTextBoxColumn";
            this.trainingIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treatmentIdDataGridViewTextBoxColumn
            // 
            this.treatmentIdDataGridViewTextBoxColumn.DataPropertyName = "TreatmentId";
            this.treatmentIdDataGridViewTextBoxColumn.HeaderText = "TreatmentId";
            this.treatmentIdDataGridViewTextBoxColumn.Name = "treatmentIdDataGridViewTextBoxColumn";
            this.treatmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trainerIdDataGridViewTextBoxColumn
            // 
            this.trainerIdDataGridViewTextBoxColumn.DataPropertyName = "TrainerId";
            this.trainerIdDataGridViewTextBoxColumn.HeaderText = "TrainerId";
            this.trainerIdDataGridViewTextBoxColumn.Name = "trainerIdDataGridViewTextBoxColumn";
            this.trainerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trainingDateDataGridViewTextBoxColumn
            // 
            this.trainingDateDataGridViewTextBoxColumn.DataPropertyName = "TrainingDate";
            this.trainingDateDataGridViewTextBoxColumn.HeaderText = "TrainingDate";
            this.trainingDateDataGridViewTextBoxColumn.Name = "trainingDateDataGridViewTextBoxColumn";
            this.trainingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trainingTimeDataGridViewTextBoxColumn
            // 
            this.trainingTimeDataGridViewTextBoxColumn.DataPropertyName = "TrainingTime";
            this.trainingTimeDataGridViewTextBoxColumn.HeaderText = "TrainingTime";
            this.trainingTimeDataGridViewTextBoxColumn.Name = "trainingTimeDataGridViewTextBoxColumn";
            this.trainingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trainingStatusIdDataGridViewTextBoxColumn
            // 
            this.trainingStatusIdDataGridViewTextBoxColumn.DataPropertyName = "TrainingStatusId";
            this.trainingStatusIdDataGridViewTextBoxColumn.HeaderText = "TrainingStatusId";
            this.trainingStatusIdDataGridViewTextBoxColumn.Name = "trainingStatusIdDataGridViewTextBoxColumn";
            this.trainingStatusIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trainingStatusesDataGridViewTextBoxColumn
            // 
            this.trainingStatusesDataGridViewTextBoxColumn.DataPropertyName = "Training_Statuses";
            this.trainingStatusesDataGridViewTextBoxColumn.HeaderText = "Training_Statuses";
            this.trainingStatusesDataGridViewTextBoxColumn.Name = "trainingStatusesDataGridViewTextBoxColumn";
            this.trainingStatusesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treatmentDataGridViewTextBoxColumn
            // 
            this.treatmentDataGridViewTextBoxColumn.DataPropertyName = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.HeaderText = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.Name = "treatmentDataGridViewTextBoxColumn";
            this.treatmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.textBox1);
            this.addGroupBox.Controls.Add(this.label2);
            this.addGroupBox.Controls.Add(this.comboBox2);
            this.addGroupBox.Controls.Add(this.label1);
            this.addGroupBox.Controls.Add(this.comboBox1);
            this.addGroupBox.Controls.Add(this.trainerLabel);
            this.addGroupBox.Controls.Add(this.treatmentLabel);
            this.addGroupBox.Controls.Add(this.timeLabel);
            this.addGroupBox.Controls.Add(this.updateButton);
            this.addGroupBox.Controls.Add(this.trainerComboBox);
            this.addGroupBox.Controls.Add(this.treatmentComboBox);
            this.addGroupBox.Controls.Add(this.timePicker);
            this.addGroupBox.Controls.Add(this.saveButton);
            this.addGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBox.Location = new System.Drawing.Point(50, 63);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(374, 312);
            this.addGroupBox.TabIndex = 35;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceSelectedTraining, "TrainingStatusId", true));
            this.comboBox2.DataSource = this.bindingSourceTrainingStatuses;
            this.comboBox2.DisplayMember = "Status_Description";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(115, 158);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 21);
            this.comboBox2.TabIndex = 37;
            this.comboBox2.ValueMember = "StatusId";
            // 
            // bindingSourceTrainingStatuses
            // 
            this.bindingSourceTrainingStatuses.DataSource = typeof(YogaDBLibrary.Models.Training_Statuses);
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
            // bindingSourceHours
            // 
            this.bindingSourceHours.DataSource = typeof(YogaDBLibrary.ScheduleTime);
            // 
            // deleteGroupBox
            // 
            this.deleteGroupBox.Controls.Add(this.trainingLabel);
            this.deleteGroupBox.Controls.Add(this.trainingComboBox);
            this.deleteGroupBox.Controls.Add(this.deleteButton);
            this.deleteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGroupBox.Location = new System.Drawing.Point(46, 381);
            this.deleteGroupBox.Name = "deleteGroupBox";
            this.deleteGroupBox.Size = new System.Drawing.Size(374, 127);
            this.deleteGroupBox.TabIndex = 36;
            this.deleteGroupBox.TabStop = false;
            this.deleteGroupBox.Text = "Delete";
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.BackColor = System.Drawing.Color.Transparent;
            this.alertLabel.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.alertLabel.Location = new System.Drawing.Point(513, 533);
            this.alertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(350, 18);
            this.alertLabel.TabIndex = 40;
            this.alertLabel.Text = "To edit existing data, please select a row.";
            this.alertLabel.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Comment :";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSelectedTraining, "Comment", true));
            this.textBox1.Location = new System.Drawing.Point(111, 195);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 47);
            this.textBox1.TabIndex = 39;
            // 
            // TrainingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogaCentar.Properties.Resources.userBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.deleteGroupBox);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.trainingDataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "TrainingsForm";
            this.Text = "TrainingsForm";
            this.Load += new System.EventHandler(this.TrainingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelectedTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTreatments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataGridView)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrainingStatuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHours)).EndInit();
            this.deleteGroupBox.ResumeLayout(false);
            this.deleteGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox trainingComboBox;
        private System.Windows.Forms.Label trainingLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.ComboBox treatmentComboBox;
        private System.Windows.Forms.ComboBox trainerComboBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label treatmentLabel;
        private System.Windows.Forms.Label trainerLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView trainingDataGridView;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.GroupBox deleteGroupBox;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingStatusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingStatusesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceTrainings;
        private System.Windows.Forms.BindingSource bindingSourceSelectedTraining;
        private System.Windows.Forms.BindingSource bindingSourceTreatments;
        private System.Windows.Forms.BindingSource bindingSourceTrainers;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceTrainingStatuses;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource bindingSourceHours;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}