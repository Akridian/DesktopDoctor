namespace DesktopDoctor
{
    partial class EditPatientForm
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
            this.fenameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.snilsTextBox = new System.Windows.Forms.TextBox();
            this.policyTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.fenameLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.snilsLabel = new System.Windows.Forms.Label();
            this.policyLabel = new System.Windows.Forms.Label();
            this.genderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fenameTextBox
            // 
            this.fenameTextBox.Location = new System.Drawing.Point(100, 26);
            this.fenameTextBox.MaxLength = 50;
            this.fenameTextBox.Name = "fenameTextBox";
            this.fenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fenameTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(100, 64);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(100, 104);
            this.patronymicTextBox.MaxLength = 50;
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronymicTextBox.TabIndex = 2;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(100, 144);
            this.birthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.birthDateTimePicker.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(250, 343);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.femaleRadioButton);
            this.genderGroupBox.Controls.Add(this.maleRadioButton);
            this.genderGroupBox.Location = new System.Drawing.Point(15, 185);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(185, 50);
            this.genderGroupBox.TabIndex = 5;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Пол";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(85, 20);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(72, 17);
            this.femaleRadioButton.TabIndex = 1;
            this.femaleRadioButton.Text = "Женский";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Location = new System.Drawing.Point(7, 20);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(71, 17);
            this.maleRadioButton.TabIndex = 0;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Мужской";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // snilsTextBox
            // 
            this.snilsTextBox.Location = new System.Drawing.Point(100, 264);
            this.snilsTextBox.MaxLength = 50;
            this.snilsTextBox.Name = "snilsTextBox";
            this.snilsTextBox.Size = new System.Drawing.Size(100, 20);
            this.snilsTextBox.TabIndex = 6;
            // 
            // policyTextBox
            // 
            this.policyTextBox.Location = new System.Drawing.Point(100, 300);
            this.policyTextBox.MaxLength = 50;
            this.policyTextBox.Name = "policyTextBox";
            this.policyTextBox.Size = new System.Drawing.Size(100, 20);
            this.policyTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(81, 343);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(12, 107);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(54, 13);
            this.patronymicLabel.TabIndex = 13;
            this.patronymicLabel.Text = "Отчество";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 67);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Имя";
            // 
            // fenameLabel
            // 
            this.fenameLabel.AutoSize = true;
            this.fenameLabel.Location = new System.Drawing.Point(12, 29);
            this.fenameLabel.Name = "fenameLabel";
            this.fenameLabel.Size = new System.Drawing.Size(56, 13);
            this.fenameLabel.TabIndex = 11;
            this.fenameLabel.Text = "Фамилия";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(12, 147);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(86, 13);
            this.birthdateLabel.TabIndex = 14;
            this.birthdateLabel.Text = "Дата рождения";
            // 
            // snilsLabel
            // 
            this.snilsLabel.AutoSize = true;
            this.snilsLabel.Location = new System.Drawing.Point(12, 267);
            this.snilsLabel.Name = "snilsLabel";
            this.snilsLabel.Size = new System.Drawing.Size(45, 13);
            this.snilsLabel.TabIndex = 15;
            this.snilsLabel.Text = "СНИЛС";
            // 
            // policyLabel
            // 
            this.policyLabel.AutoSize = true;
            this.policyLabel.Location = new System.Drawing.Point(12, 303);
            this.policyLabel.Name = "policyLabel";
            this.policyLabel.Size = new System.Drawing.Size(80, 13);
            this.policyLabel.TabIndex = 16;
            this.policyLabel.Text = "Номер полиса";
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.policyLabel);
            this.Controls.Add(this.snilsLabel);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.fenameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.policyTextBox);
            this.Controls.Add(this.snilsTextBox);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.fenameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPatientForm";
            this.ShowIcon = false;
            this.Text = "EditPatientForm";
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fenameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.TextBox snilsTextBox;
        private System.Windows.Forms.TextBox policyTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label fenameLabel;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label snilsLabel;
        private System.Windows.Forms.Label policyLabel;
    }
}