
namespace JogaCentar.Forms
{
    partial class TreatmentsForm
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
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.bindingSourceSelectedThreatment = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.treatmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.treatmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceTreatments = new System.Windows.Forms.BindingSource(this.components);
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.alertLabel = new System.Windows.Forms.Label();
            this.deleteGroupBox = new System.Windows.Forms.GroupBox();
            this.trainingLabel = new System.Windows.Forms.Label();
            this.treatmentComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelectedThreatment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTreatments)).BeginInit();
            this.addGroupBox.SuspendLayout();
            this.deleteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSelectedThreatment, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(115, 121);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(242, 114);
            this.descriptionTextBox.TabIndex = 27;
            // 
            // bindingSourceSelectedThreatment
            // 
            this.bindingSourceSelectedThreatment.DataSource = typeof(YogaDBLibrary.Models.Treatment);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSelectedThreatment, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(115, 82);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(242, 20);
            this.priceTextBox.TabIndex = 26;
            this.priceTextBox.Leave += new System.EventHandler(this.priceTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSelectedThreatment, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(115, 43);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(242, 20);
            this.nameTextBox.TabIndex = 25;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(259, 249);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 32);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Add";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(115, 249);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(98, 32);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "Save";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // treatmentsDataGridView
            // 
            this.treatmentsDataGridView.AllowUserToAddRows = false;
            this.treatmentsDataGridView.AllowUserToDeleteRows = false;
            this.treatmentsDataGridView.AutoGenerateColumns = false;
            this.treatmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatmentIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.treatmentsDataGridView.DataSource = this.bindingSourceTreatments;
            this.treatmentsDataGridView.Location = new System.Drawing.Point(433, 60);
            this.treatmentsDataGridView.Name = "treatmentsDataGridView";
            this.treatmentsDataGridView.ReadOnly = true;
            this.treatmentsDataGridView.Size = new System.Drawing.Size(467, 395);
            this.treatmentsDataGridView.TabIndex = 31;
            this.treatmentsDataGridView.DoubleClick += new System.EventHandler(this.treatmentsDataGridView_DoubleClick);
            // 
            // treatmentIdDataGridViewTextBoxColumn
            // 
            this.treatmentIdDataGridViewTextBoxColumn.DataPropertyName = "TreatmentId";
            this.treatmentIdDataGridViewTextBoxColumn.HeaderText = "TreatmentId";
            this.treatmentIdDataGridViewTextBoxColumn.Name = "treatmentIdDataGridViewTextBoxColumn";
            this.treatmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceTreatments
            // 
            this.bindingSourceTreatments.DataSource = typeof(YogaDBLibrary.Models.Treatment);
            this.bindingSourceTreatments.CurrentChanged += new System.EventHandler(this.bindingSourceTreatments_CurrentChanged);
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.descriptionLabel);
            this.addGroupBox.Controls.Add(this.priceLabel);
            this.addGroupBox.Controls.Add(this.nameLabel);
            this.addGroupBox.Controls.Add(this.nameTextBox);
            this.addGroupBox.Controls.Add(this.priceTextBox);
            this.addGroupBox.Controls.Add(this.updateButton);
            this.addGroupBox.Controls.Add(this.saveButton);
            this.addGroupBox.Controls.Add(this.descriptionTextBox);
            this.addGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBox.Location = new System.Drawing.Point(40, 60);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(374, 292);
            this.addGroupBox.TabIndex = 36;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add / Update";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(11, 123);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(102, 18);
            this.descriptionLabel.TabIndex = 30;
            this.descriptionLabel.Text = "Description :";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(11, 81);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(55, 18);
            this.priceLabel.TabIndex = 29;
            this.priceLabel.Text = "Price :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(11, 42);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 18);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "Name :";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(35, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(280, 29);
            this.titleLabel.TabIndex = 37;
            this.titleLabel.Text = "Manage Treatments";
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(794, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(106, 32);
            this.backButton.TabIndex = 38;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.BackColor = System.Drawing.Color.Transparent;
            this.alertLabel.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.alertLabel.Location = new System.Drawing.Point(503, 476);
            this.alertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(350, 18);
            this.alertLabel.TabIndex = 39;
            this.alertLabel.Text = "To edit existing data, please select a row.";
            this.alertLabel.UseWaitCursor = true;
            // 
            // deleteGroupBox
            // 
            this.deleteGroupBox.Controls.Add(this.trainingLabel);
            this.deleteGroupBox.Controls.Add(this.treatmentComboBox);
            this.deleteGroupBox.Controls.Add(this.deleteButton);
            this.deleteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGroupBox.Location = new System.Drawing.Point(40, 367);
            this.deleteGroupBox.Name = "deleteGroupBox";
            this.deleteGroupBox.Size = new System.Drawing.Size(374, 127);
            this.deleteGroupBox.TabIndex = 40;
            this.deleteGroupBox.TabStop = false;
            this.deleteGroupBox.Text = "Delete";
            // 
            // trainingLabel
            // 
            this.trainingLabel.AutoSize = true;
            this.trainingLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingLabel.Location = new System.Drawing.Point(11, 35);
            this.trainingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trainingLabel.Name = "trainingLabel";
            this.trainingLabel.Size = new System.Drawing.Size(97, 18);
            this.trainingLabel.TabIndex = 29;
            this.trainingLabel.Text = "Treatment :";
            // 
            // treatmentComboBox
            // 
            this.treatmentComboBox.DataSource = this.bindingSourceTreatments;
            this.treatmentComboBox.DisplayMember = "Name";
            this.treatmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentComboBox.FormattingEnabled = true;
            this.treatmentComboBox.Location = new System.Drawing.Point(115, 35);
            this.treatmentComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.treatmentComboBox.Name = "treatmentComboBox";
            this.treatmentComboBox.Size = new System.Drawing.Size(242, 21);
            this.treatmentComboBox.TabIndex = 30;
            this.treatmentComboBox.ValueMember = "TreatmentId";
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
            // TreatmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogaCentar.Properties.Resources.ownerBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(940, 518);
            this.Controls.Add(this.deleteGroupBox);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.treatmentsDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TreatmentsForm";
            this.Text = "TreatmentsForm";
            this.Load += new System.EventHandler(this.TreatmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelectedThreatment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTreatments)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.deleteGroupBox.ResumeLayout(false);
            this.deleteGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView treatmentsDataGridView;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.GroupBox deleteGroupBox;
        private System.Windows.Forms.Label trainingLabel;
        private System.Windows.Forms.ComboBox treatmentComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.BindingSource bindingSourceSelectedThreatment;
        private System.Windows.Forms.BindingSource bindingSourceTreatments;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}