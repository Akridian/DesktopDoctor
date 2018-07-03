namespace DesktopDoctor
{
    partial class MedicinesForm
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
            this.toDoctorsButton = new System.Windows.Forms.Button();
            this.addMedicineButton = new System.Windows.Forms.Button();
            this.changeMedicineButton = new System.Windows.Forms.Button();
            this.removeMedicineButton = new System.Windows.Forms.Button();
            this.medicinesDataGridView = new System.Windows.Forms.DataGridView();
            this.searchNameMedicineTextBox = new System.Windows.Forms.TextBox();
            this.searchDescriptionMedicineTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toDoctorsButton
            // 
            this.toDoctorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDoctorsButton.Location = new System.Drawing.Point(672, 12);
            this.toDoctorsButton.Name = "toDoctorsButton";
            this.toDoctorsButton.Size = new System.Drawing.Size(116, 36);
            this.toDoctorsButton.TabIndex = 3;
            this.toDoctorsButton.Text = " Врачи ";
            this.toDoctorsButton.UseVisualStyleBackColor = true;
            this.toDoctorsButton.Click += new System.EventHandler(this.ToDoctorsButton_Click);
            // 
            // addMedicineButton
            // 
            this.addMedicineButton.Location = new System.Drawing.Point(12, 12);
            this.addMedicineButton.Name = "addMedicineButton";
            this.addMedicineButton.Size = new System.Drawing.Size(75, 23);
            this.addMedicineButton.TabIndex = 4;
            this.addMedicineButton.Text = "Добавить";
            this.addMedicineButton.UseVisualStyleBackColor = true;
            this.addMedicineButton.Click += new System.EventHandler(this.AddMedicineButton_Click);
            // 
            // changeMedicineButton
            // 
            this.changeMedicineButton.Location = new System.Drawing.Point(106, 12);
            this.changeMedicineButton.Name = "changeMedicineButton";
            this.changeMedicineButton.Size = new System.Drawing.Size(75, 23);
            this.changeMedicineButton.TabIndex = 4;
            this.changeMedicineButton.Text = "Изменить";
            this.changeMedicineButton.UseVisualStyleBackColor = true;
            this.changeMedicineButton.Click += new System.EventHandler(this.ChangeMedicineButton_Click);
            // 
            // removeMedicineButton
            // 
            this.removeMedicineButton.Location = new System.Drawing.Point(200, 12);
            this.removeMedicineButton.Name = "removeMedicineButton";
            this.removeMedicineButton.Size = new System.Drawing.Size(75, 23);
            this.removeMedicineButton.TabIndex = 4;
            this.removeMedicineButton.Text = "Удалить";
            this.removeMedicineButton.UseVisualStyleBackColor = true;
            this.removeMedicineButton.Click += new System.EventHandler(this.RemoveMedicineButton_Click);
            // 
            // medicinesDataGridView
            // 
            this.medicinesDataGridView.AllowUserToAddRows = false;
            this.medicinesDataGridView.AllowUserToDeleteRows = false;
            this.medicinesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicinesDataGridView.AutoGenerateColumns = false;
            this.medicinesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.medicinesDataGridView.DataSource = this.medicinesBindingSource;
            this.medicinesDataGridView.Location = new System.Drawing.Point(12, 81);
            this.medicinesDataGridView.Name = "medicinesDataGridView";
            this.medicinesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicinesDataGridView.Size = new System.Drawing.Size(776, 357);
            this.medicinesDataGridView.TabIndex = 5;
            // 
            // searchNameMedicineTextBox
            // 
            this.searchNameMedicineTextBox.Location = new System.Drawing.Point(89, 54);
            this.searchNameMedicineTextBox.Name = "searchNameMedicineTextBox";
            this.searchNameMedicineTextBox.Size = new System.Drawing.Size(320, 20);
            this.searchNameMedicineTextBox.TabIndex = 6;
            // 
            // searchDescriptionMedicineTextBox
            // 
            this.searchDescriptionMedicineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDescriptionMedicineTextBox.Location = new System.Drawing.Point(426, 54);
            this.searchDescriptionMedicineTextBox.Name = "searchDescriptionMedicineTextBox";
            this.searchDescriptionMedicineTextBox.Size = new System.Drawing.Size(362, 20);
            this.searchDescriptionMedicineTextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(8, 52);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataSource = typeof(DesktopDoctor.Medicine);
            // 
            // MedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchDescriptionMedicineTextBox);
            this.Controls.Add(this.searchNameMedicineTextBox);
            this.Controls.Add(this.medicinesDataGridView);
            this.Controls.Add(this.removeMedicineButton);
            this.Controls.Add(this.changeMedicineButton);
            this.Controls.Add(this.addMedicineButton);
            this.Controls.Add(this.toDoctorsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicinesForm";
            this.Text = "MedicinesForm";
            this.Load += new System.EventHandler(this.MedicinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button toDoctorsButton;
        private System.Windows.Forms.Button addMedicineButton;
        private System.Windows.Forms.Button changeMedicineButton;
        private System.Windows.Forms.Button removeMedicineButton;
        private System.Windows.Forms.DataGridView medicinesDataGridView;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchNameMedicineTextBox;
        private System.Windows.Forms.TextBox searchDescriptionMedicineTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}