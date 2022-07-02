
namespace JogaCentar.Forms
{
    partial class SubscriptionsForm
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
            this.alertLabel = new System.Windows.Forms.Label();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingSourceSelectedSub = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSubStatus = new System.Windows.Forms.ComboBox();
            this.bindingSourceSubStatus = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.trainerLabel = new System.Windows.Forms.Label();
            this.treatmentLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.treatmentComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSourceTreatments = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.subscriptionsDataGridView = new System.Windows.Forms.DataGridView();
            this.subscriptionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofTrainingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendedTrainingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionStatusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionStatusesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSubscriptions = new System.Windows.Forms.BindingSource(this.components);
            this.backButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.addGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelectedSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSubStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTreatments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSubscriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.BackColor = System.Drawing.Color.Transparent;
            this.alertLabel.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.alertLabel.Location = new System.Drawing.Point(507, 490);
            this.alertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(350, 18);
            this.alertLabel.TabIndex = 45;
            this.alertLabel.Text = "To edit existing data, please select a row.";
            this.alertLabel.UseWaitCursor = true;
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.numericUpDown1);
            this.addGroupBox.Controls.Add(this.textBox1);
            this.addGroupBox.Controls.Add(this.comboBoxSubStatus);
            this.addGroupBox.Controls.Add(this.label2);
            this.addGroupBox.Controls.Add(this.userComboBox);
            this.addGroupBox.Controls.Add(this.label1);
            this.addGroupBox.Controls.Add(this.trainerLabel);
            this.addGroupBox.Controls.Add(this.treatmentLabel);
            this.addGroupBox.Controls.Add(this.updateButton);
            this.addGroupBox.Controls.Add(this.treatmentComboBox);
            this.addGroupBox.Controls.Add(this.saveButton);
            this.addGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBox.Location = new System.Drawing.Point(44, 74);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(374, 322);
            this.addGroupBox.TabIndex = 44;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSelectedSub, "Comment", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 40);
            this.textBox1.TabIndex = 42;
            // 
            // bindingSourceSelectedSub
            // 
            this.bindingSourceSelectedSub.DataSource = typeof(YogaDBLibrary.Models.Subscription);
            // 
            // comboBoxSubStatus
            // 
            this.comboBoxSubStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceSelectedSub, "SubscriptionStatusId", true));
            this.comboBoxSubStatus.DataSource = this.bindingSourceSubStatus;
            this.comboBoxSubStatus.DisplayMember = "Status_Description";
            this.comboBoxSubStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubStatus.FormattingEnabled = true;
            this.comboBoxSubStatus.Location = new System.Drawing.Point(115, 148);
            this.comboBoxSubStatus.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSubStatus.Name = "comboBoxSubStatus";
            this.comboBoxSubStatus.Size = new System.Drawing.Size(242, 21);
            this.comboBoxSubStatus.TabIndex = 41;
            this.comboBoxSubStatus.ValueMember = "StatusId";
            // 
            // bindingSourceSubStatus
            // 
            this.bindingSourceSubStatus.DataSource = typeof(YogaDBLibrary.Models.Subscription_Statuses);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Status :";
            // 
            // userComboBox
            // 
            this.userComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceSelectedSub, "UserId", true));
            this.userComboBox.DataSource = this.bindingSourceUsers;
            this.userComboBox.DisplayMember = "Account";
            this.userComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(115, 36);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(242, 21);
            this.userComboBox.TabIndex = 39;
            this.userComboBox.ValueMember = "UserId";
            // 
            // bindingSourceUsers
            // 
            this.bindingSourceUsers.DataSource = typeof(YogaDBLibrary.Models.User);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "User :";
            // 
            // trainerLabel
            // 
            this.trainerLabel.AutoSize = true;
            this.trainerLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerLabel.Location = new System.Drawing.Point(11, 72);
            this.trainerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trainerLabel.Name = "trainerLabel";
            this.trainerLabel.Size = new System.Drawing.Size(97, 18);
            this.trainerLabel.TabIndex = 18;
            this.trainerLabel.Text = "Treatment :";
            this.trainerLabel.Click += new System.EventHandler(this.trainerLabel_Click);
            // 
            // treatmentLabel
            // 
            this.treatmentLabel.AutoSize = true;
            this.treatmentLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentLabel.Location = new System.Drawing.Point(11, 111);
            this.treatmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.treatmentLabel.Name = "treatmentLabel";
            this.treatmentLabel.Size = new System.Drawing.Size(154, 18);
            this.treatmentLabel.TabIndex = 19;
            this.treatmentLabel.Text = "No. of treatments :";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(15, 251);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(98, 32);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // treatmentComboBox
            // 
            this.treatmentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceSelectedSub, "TreatmentId", true));
            this.treatmentComboBox.DataSource = this.bindingSourceTreatments;
            this.treatmentComboBox.DisplayMember = "Name";
            this.treatmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentComboBox.FormattingEnabled = true;
            this.treatmentComboBox.Location = new System.Drawing.Point(115, 73);
            this.treatmentComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.treatmentComboBox.Name = "treatmentComboBox";
            this.treatmentComboBox.Size = new System.Drawing.Size(242, 21);
            this.treatmentComboBox.TabIndex = 22;
            this.treatmentComboBox.ValueMember = "TreatmentId";
            this.treatmentComboBox.SelectedIndexChanged += new System.EventHandler(this.treatmentComboBox_SelectedIndexChanged);
            // 
            // bindingSourceTreatments
            // 
            this.bindingSourceTreatments.DataSource = typeof(YogaDBLibrary.Models.Treatment);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(259, 251);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 32);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Add";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // subscriptionsDataGridView
            // 
            this.subscriptionsDataGridView.AllowUserToAddRows = false;
            this.subscriptionsDataGridView.AllowUserToDeleteRows = false;
            this.subscriptionsDataGridView.AutoGenerateColumns = false;
            this.subscriptionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subscriptionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subscriptionIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.treatmentIdDataGridViewTextBoxColumn,
            this.numberofTrainingsDataGridViewTextBoxColumn,
            this.attendedTrainingsDataGridViewTextBoxColumn,
            this.subscriptionStatusIdDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.subscriptionStatusesDataGridViewTextBoxColumn,
            this.treatmentDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.subscriptionsDataGridView.DataSource = this.bindingSourceSubscriptions;
            this.subscriptionsDataGridView.Location = new System.Drawing.Point(437, 74);
            this.subscriptionsDataGridView.Name = "subscriptionsDataGridView";
            this.subscriptionsDataGridView.ReadOnly = true;
            this.subscriptionsDataGridView.Size = new System.Drawing.Size(467, 395);
            this.subscriptionsDataGridView.TabIndex = 43;
            this.subscriptionsDataGridView.DoubleClick += new System.EventHandler(this.subscriptionsDataGridView_DoubleClick);
            // 
            // subscriptionIdDataGridViewTextBoxColumn
            // 
            this.subscriptionIdDataGridViewTextBoxColumn.DataPropertyName = "SubscriptionId";
            this.subscriptionIdDataGridViewTextBoxColumn.HeaderText = "SubscriptionId";
            this.subscriptionIdDataGridViewTextBoxColumn.Name = "subscriptionIdDataGridViewTextBoxColumn";
            this.subscriptionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treatmentIdDataGridViewTextBoxColumn
            // 
            this.treatmentIdDataGridViewTextBoxColumn.DataPropertyName = "TreatmentId";
            this.treatmentIdDataGridViewTextBoxColumn.HeaderText = "TreatmentId";
            this.treatmentIdDataGridViewTextBoxColumn.Name = "treatmentIdDataGridViewTextBoxColumn";
            this.treatmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberofTrainingsDataGridViewTextBoxColumn
            // 
            this.numberofTrainingsDataGridViewTextBoxColumn.DataPropertyName = "Number_of_Trainings";
            this.numberofTrainingsDataGridViewTextBoxColumn.HeaderText = "Number_of_Trainings";
            this.numberofTrainingsDataGridViewTextBoxColumn.Name = "numberofTrainingsDataGridViewTextBoxColumn";
            this.numberofTrainingsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendedTrainingsDataGridViewTextBoxColumn
            // 
            this.attendedTrainingsDataGridViewTextBoxColumn.DataPropertyName = "Attended_Trainings";
            this.attendedTrainingsDataGridViewTextBoxColumn.HeaderText = "Attended_Trainings";
            this.attendedTrainingsDataGridViewTextBoxColumn.Name = "attendedTrainingsDataGridViewTextBoxColumn";
            this.attendedTrainingsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscriptionStatusIdDataGridViewTextBoxColumn
            // 
            this.subscriptionStatusIdDataGridViewTextBoxColumn.DataPropertyName = "SubscriptionStatusId";
            this.subscriptionStatusIdDataGridViewTextBoxColumn.HeaderText = "SubscriptionStatusId";
            this.subscriptionStatusIdDataGridViewTextBoxColumn.Name = "subscriptionStatusIdDataGridViewTextBoxColumn";
            this.subscriptionStatusIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscriptionStatusesDataGridViewTextBoxColumn
            // 
            this.subscriptionStatusesDataGridViewTextBoxColumn.DataPropertyName = "Subscription_Statuses";
            this.subscriptionStatusesDataGridViewTextBoxColumn.HeaderText = "Subscription_Statuses";
            this.subscriptionStatusesDataGridViewTextBoxColumn.Name = "subscriptionStatusesDataGridViewTextBoxColumn";
            this.subscriptionStatusesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treatmentDataGridViewTextBoxColumn
            // 
            this.treatmentDataGridViewTextBoxColumn.DataPropertyName = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.HeaderText = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.Name = "treatmentDataGridViewTextBoxColumn";
            this.treatmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceSubscriptions
            // 
            this.bindingSourceSubscriptions.DataSource = typeof(YogaDBLibrary.Models.Subscription);
            this.bindingSourceSubscriptions.CurrentChanged += new System.EventHandler(this.bindingSourceSubscriptions_CurrentChanged);
            // 
            // backButton
            // 
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(798, 25);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(106, 32);
            this.backButton.TabIndex = 42;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(39, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(308, 29);
            this.titleLabel.TabIndex = 41;
            this.titleLabel.Text = "Manage Subscriptions";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceSelectedSub, "Number_of_Trainings", true));
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(237, 108);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 43;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SubscriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogaCentar.Properties.Resources.adminBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.subscriptionsDataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "SubscriptionsForm";
            this.Text = "SubscriptionsForm";
            this.Load += new System.EventHandler(this.SubscriptionsForm_Load);
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelectedSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSubStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTreatments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSubscriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Label trainerLabel;
        private System.Windows.Forms.Label treatmentLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox treatmentComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView subscriptionsDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bindingSourceSelectedSub;
        private System.Windows.Forms.ComboBox comboBoxSubStatus;
        private System.Windows.Forms.BindingSource bindingSourceSubStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSourceUsers;
        private System.Windows.Forms.BindingSource bindingSourceTreatments;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofTrainingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendedTrainingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionStatusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionStatusesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceSubscriptions;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}