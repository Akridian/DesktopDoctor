namespace DesktopDoctor
{
    partial class PatientForm
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
            this.fenameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.snilsLabel = new System.Windows.Forms.Label();
            this.policyLabel = new System.Windows.Forms.Label();
            this.receptionDataGridView = new System.Windows.Forms.DataGridView();
            this.receptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goBackButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.startReceptionButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.receptionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fenameLabel
            // 
            this.fenameLabel.AutoSize = true;
            this.fenameLabel.Location = new System.Drawing.Point(31, 22);
            this.fenameLabel.Name = "fenameLabel";
            this.fenameLabel.Size = new System.Drawing.Size(45, 13);
            this.fenameLabel.TabIndex = 0;
            this.fenameLabel.Text = "Fename";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(149, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(277, 22);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(59, 13);
            this.patronymicLabel.TabIndex = 2;
            this.patronymicLabel.Text = "Patronymic";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(31, 66);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gender";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(149, 66);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(49, 13);
            this.birthdateLabel.TabIndex = 4;
            this.birthdateLabel.Text = "Birthdate";
            // 
            // snilsLabel
            // 
            this.snilsLabel.AutoSize = true;
            this.snilsLabel.Location = new System.Drawing.Point(31, 110);
            this.snilsLabel.Name = "snilsLabel";
            this.snilsLabel.Size = new System.Drawing.Size(29, 13);
            this.snilsLabel.TabIndex = 5;
            this.snilsLabel.Text = "Snils";
            // 
            // policyLabel
            // 
            this.policyLabel.AutoSize = true;
            this.policyLabel.Location = new System.Drawing.Point(31, 156);
            this.policyLabel.Name = "policyLabel";
            this.policyLabel.Size = new System.Drawing.Size(35, 13);
            this.policyLabel.TabIndex = 6;
            this.policyLabel.Text = "Policy";
            // 
            // receptionDataGridView
            // 
            this.receptionDataGridView.AllowUserToAddRows = false;
            this.receptionDataGridView.AllowUserToDeleteRows = false;
            this.receptionDataGridView.AutoGenerateColumns = false;
            this.receptionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receptionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Employee,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.receptionDataGridView.DataSource = this.receptionBindingSource;
            this.receptionDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.receptionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.receptionDataGridView.Location = new System.Drawing.Point(0, 385);
            this.receptionDataGridView.MultiSelect = false;
            this.receptionDataGridView.Name = "receptionDataGridView";
            this.receptionDataGridView.ReadOnly = true;
            this.receptionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receptionDataGridView.Size = new System.Drawing.Size(800, 170);
            this.receptionDataGridView.TabIndex = 8;
            this.receptionDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ReceptionDataGridView_CellMouseDoubleClick);
            // 
            // receptionBindingSource
            // 
            this.receptionBindingSource.DataSource = typeof(DesktopDoctor.Reception);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Employee";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(655, 22);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 9;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(34, 203);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // startReceptionButton
            // 
            this.startReceptionButton.Location = new System.Drawing.Point(152, 203);
            this.startReceptionButton.Name = "startReceptionButton";
            this.startReceptionButton.Size = new System.Drawing.Size(95, 23);
            this.startReceptionButton.TabIndex = 11;
            this.startReceptionButton.Text = "Начать прием";
            this.startReceptionButton.UseVisualStyleBackColor = true;
            this.startReceptionButton.Click += new System.EventHandler(this.StartReceptionButton_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "Employee";
            this.Employee.HeaderText = "Врач";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Diagnosis";
            this.dataGridViewTextBoxColumn7.HeaderText = "Диагноз";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Temperature";
            this.dataGridViewTextBoxColumn5.HeaderText = "Температура";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pressure";
            this.dataGridViewTextBoxColumn6.HeaderText = "Давление";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.ControlBox = false;
            this.Controls.Add(this.startReceptionButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.receptionDataGridView);
            this.Controls.Add(this.policyLabel);
            this.Controls.Add(this.snilsLabel);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.fenameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.ShowIcon = false;
            this.Text = "PatientForm";
            ((System.ComponentModel.ISupportInitialize)(this.receptionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fenameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label snilsLabel;
        private System.Windows.Forms.Label policyLabel;
        private System.Windows.Forms.BindingSource receptionBindingSource;
        private System.Windows.Forms.DataGridView receptionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button startReceptionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}