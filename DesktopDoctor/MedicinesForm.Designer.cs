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
            this.dataGridViewMedicines = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desktopDoctorDatabaseDataSet = new DesktopDoctor.DesktopDoctorDatabaseDataSet();
            this.btnGoToDoctors = new System.Windows.Forms.Button();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnChangeMedicine = new System.Windows.Forms.Button();
            this.btnRemoveMedicine = new System.Windows.Forms.Button();
            this.medicinesTableAdapter = new DesktopDoctor.DesktopDoctorDatabaseDataSetTableAdapters.MedicinesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desktopDoctorDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMedicines
            // 
            this.dataGridViewMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMedicines.AutoGenerateColumns = false;
            this.dataGridViewMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewMedicines.DataSource = this.medicinesBindingSource;
            this.dataGridViewMedicines.Location = new System.Drawing.Point(40, 81);
            this.dataGridViewMedicines.Name = "dataGridViewMedicines";
            this.dataGridViewMedicines.Size = new System.Drawing.Size(719, 357);
            this.dataGridViewMedicines.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataMember = "Medicines";
            this.medicinesBindingSource.DataSource = this.desktopDoctorDatabaseDataSet;
            // 
            // desktopDoctorDatabaseDataSet
            // 
            this.desktopDoctorDatabaseDataSet.DataSetName = "DesktopDoctorDatabaseDataSet";
            this.desktopDoctorDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGoToDoctors
            // 
            this.btnGoToDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToDoctors.Location = new System.Drawing.Point(637, 32);
            this.btnGoToDoctors.Name = "btnGoToDoctors";
            this.btnGoToDoctors.Size = new System.Drawing.Size(116, 43);
            this.btnGoToDoctors.TabIndex = 3;
            this.btnGoToDoctors.Text = " Врачи ";
            this.btnGoToDoctors.UseVisualStyleBackColor = true;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Location = new System.Drawing.Point(53, 52);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(75, 23);
            this.btnAddMedicine.TabIndex = 4;
            this.btnAddMedicine.Text = "Добавить";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnChangeMedicine
            // 
            this.btnChangeMedicine.Location = new System.Drawing.Point(147, 52);
            this.btnChangeMedicine.Name = "btnChangeMedicine";
            this.btnChangeMedicine.Size = new System.Drawing.Size(75, 23);
            this.btnChangeMedicine.TabIndex = 4;
            this.btnChangeMedicine.Text = "Изменить";
            this.btnChangeMedicine.UseVisualStyleBackColor = true;
            // 
            // btnRemoveMedicine
            // 
            this.btnRemoveMedicine.Location = new System.Drawing.Point(241, 52);
            this.btnRemoveMedicine.Name = "btnRemoveMedicine";
            this.btnRemoveMedicine.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMedicine.TabIndex = 4;
            this.btnRemoveMedicine.Text = "Удалить";
            this.btnRemoveMedicine.UseVisualStyleBackColor = true;
            // 
            // medicinesTableAdapter
            // 
            this.medicinesTableAdapter.ClearBeforeFill = true;
            // 
            // MedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemoveMedicine);
            this.Controls.Add(this.btnChangeMedicine);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.btnGoToDoctors);
            this.Controls.Add(this.dataGridViewMedicines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicinesForm";
            this.Text = "MedicinesForm";
            this.Load += new System.EventHandler(this.MedicinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desktopDoctorDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMedicines;
        private System.Windows.Forms.Button btnGoToDoctors;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnChangeMedicine;
        private System.Windows.Forms.Button btnRemoveMedicine;
        private DesktopDoctorDatabaseDataSet desktopDoctorDatabaseDataSet;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private DesktopDoctorDatabaseDataSetTableAdapters.MedicinesTableAdapter medicinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}