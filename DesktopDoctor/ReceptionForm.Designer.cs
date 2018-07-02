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
            this.saveButton.Location = new System.Drawing.Point(19, 390);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(126, 390);
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
            this.recommendationsLabel.Size = new System.Drawing.Size(90, 13);
            this.recommendationsLabel.TabIndex = 14;
            this.recommendationsLabel.Text = "Рекоммендации";
            // 
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
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
    }
}