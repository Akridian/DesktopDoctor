namespace DesktopDoctor
{
    partial class ReceptionForm
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.patientLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.diagnosisLabel = new System.Windows.Forms.Label();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.symptomsLabel = new System.Windows.Forms.Label();
            this.recommendationsTextBox = new System.Windows.Forms.TextBox();
            this.recommendationsLabel = new System.Windows.Forms.Label();
            this.medicineDataGridView = new System.Windows.Forms.DataGridView();
            this.addMedicineButton = new System.Windows.Forms.Button();
            this.removeMedicineButton = new System.Windows.Forms.Button();
            this.saveRecomendationsButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.medicineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(16, 13);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(56, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "DateLabel";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(258, 13);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(65, 13);
            this.doctorLabel.TabIndex = 1;
            this.doctorLabel.Text = "DoctorLabel";
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Location = new System.Drawing.Point(16, 41);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(66, 13);
            this.patientLabel.TabIndex = 2;
            this.patientLabel.Text = "PatientLabel";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(258, 41);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(74, 13);
            this.temperatureLabel.TabIndex = 3;
            this.temperatureLabel.Text = "Температура";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(353, 38);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(100, 20);
            this.temperatureTextBox.TabIndex = 4;
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Location = new System.Drawing.Point(524, 41);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(58, 13);
            this.PressureLabel.TabIndex = 5;
            this.PressureLabel.Text = "Давление";
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.Location = new System.Drawing.Point(610, 38);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(100, 20);
            this.pressureTextBox.TabIndex = 6;
            // 
            // diagnosisLabel
            // 
            this.diagnosisLabel.AutoSize = true;
            this.diagnosisLabel.Location = new System.Drawing.Point(16, 71);
            this.diagnosisLabel.Name = "diagnosisLabel";
            this.diagnosisLabel.Size = new System.Drawing.Size(51, 13);
            this.diagnosisLabel.TabIndex = 7;
            this.diagnosisLabel.Text = "Диагноз";
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.Location = new System.Drawing.Point(109, 68);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(486, 20);
            this.diagnosisTextBox.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(12, 501);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Location = new System.Drawing.Point(119, 501);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Location = new System.Drawing.Point(109, 110);
            this.symptomsTextBox.MaxLength = 255;
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(486, 56);
            this.symptomsTextBox.TabIndex = 11;
            // 
            // symptomsLabel
            // 
            this.symptomsLabel.AutoSize = true;
            this.symptomsLabel.Location = new System.Drawing.Point(16, 110);
            this.symptomsLabel.Name = "symptomsLabel";
            this.symptomsLabel.Size = new System.Drawing.Size(61, 13);
            this.symptomsLabel.TabIndex = 12;
            this.symptomsLabel.Text = "Симптомы";
            // 
            // recommendationsTextBox
            // 
            this.recommendationsTextBox.Location = new System.Drawing.Point(109, 188);
            this.recommendationsTextBox.MaxLength = 255;
            this.recommendationsTextBox.Multiline = true;
            this.recommendationsTextBox.Name = "recommendationsTextBox";
            this.recommendationsTextBox.Size = new System.Drawing.Size(486, 60);
            this.recommendationsTextBox.TabIndex = 13;
            // 
            // recommendationsLabel
            // 
            this.recommendationsLabel.AutoSize = true;
            this.recommendationsLabel.Location = new System.Drawing.Point(16, 191);
            this.recommendationsLabel.Name = "recommendationsLabel";
            this.recommendationsLabel.Size = new System.Drawing.Size(82, 13);
            this.recommendationsLabel.TabIndex = 14;
            this.recommendationsLabel.Text = "Рекомендации";
            // 
            // medicineDataGridView
            // 
            this.medicineDataGridView.AllowUserToAddRows = false;
            this.medicineDataGridView.AllowUserToDeleteRows = false;
            this.medicineDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicineDataGridView.AutoGenerateColumns = false;
            this.medicineDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.medicineDataGridView.DataSource = this.medicineBindingSource;
            this.medicineDataGridView.Location = new System.Drawing.Point(12, 284);
            this.medicineDataGridView.MultiSelect = false;
            this.medicineDataGridView.Name = "medicineDataGridView";
            this.medicineDataGridView.ReadOnly = true;
            this.medicineDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicineDataGridView.Size = new System.Drawing.Size(776, 211);
            this.medicineDataGridView.TabIndex = 16;
            // 
            // addMedicineButton
            // 
            this.addMedicineButton.Location = new System.Drawing.Point(19, 255);
            this.addMedicineButton.Name = "addMedicineButton";
            this.addMedicineButton.Size = new System.Drawing.Size(182, 23);
            this.addMedicineButton.TabIndex = 17;
            this.addMedicineButton.Text = "Добавить медикамент";
            this.addMedicineButton.UseVisualStyleBackColor = true;
            this.addMedicineButton.Click += new System.EventHandler(this.AddMedicineButton_Click);
            // 
            // removeMedicineButton
            // 
            this.removeMedicineButton.Location = new System.Drawing.Point(223, 255);
            this.removeMedicineButton.Name = "removeMedicineButton";
            this.removeMedicineButton.Size = new System.Drawing.Size(175, 23);
            this.removeMedicineButton.TabIndex = 18;
            this.removeMedicineButton.Text = "Удалить медикамент";
            this.removeMedicineButton.UseVisualStyleBackColor = true;
            this.removeMedicineButton.Click += new System.EventHandler(this.RemoveMedicineButton_Click);
            // 
            // saveRecomendationsButton
            // 
            this.saveRecomendationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveRecomendationsButton.Location = new System.Drawing.Point(226, 501);
            this.saveRecomendationsButton.Name = "saveRecomendationsButton";
            this.saveRecomendationsButton.Size = new System.Drawing.Size(179, 23);
            this.saveRecomendationsButton.TabIndex = 19;
            this.saveRecomendationsButton.Text = "Сохранить рекомендации";
            this.saveRecomendationsButton.UseVisualStyleBackColor = true;
            this.saveRecomendationsButton.Click += new System.EventHandler(this.SaveRecomendationsButton_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataSource = typeof(DesktopDoctor.Medicine);
            // 
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.ControlBox = false;
            this.Controls.Add(this.saveRecomendationsButton);
            this.Controls.Add(this.removeMedicineButton);
            this.Controls.Add(this.addMedicineButton);
            this.Controls.Add(this.medicineDataGridView);
            this.Controls.Add(this.recommendationsLabel);
            this.Controls.Add(this.recommendationsTextBox);
            this.Controls.Add(this.symptomsLabel);
            this.Controls.Add(this.symptomsTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.diagnosisTextBox);
            this.Controls.Add(this.diagnosisLabel);
            this.Controls.Add(this.pressureTextBox);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.dateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceptionForm";
            this.ShowIcon = false;
            this.Text = "ReceptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.medicineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.Label diagnosisLabel;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.Label symptomsLabel;
        private System.Windows.Forms.TextBox recommendationsTextBox;
        private System.Windows.Forms.Label recommendationsLabel;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private System.Windows.Forms.DataGridView medicineDataGridView;
        private System.Windows.Forms.Button addMedicineButton;
        private System.Windows.Forms.Button removeMedicineButton;
        private System.Windows.Forms.Button saveRecomendationsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}