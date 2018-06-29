namespace DesktopDoctor
{
    partial class EditMedicineForm
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
            this.addMedicineButton = new System.Windows.Forms.Button();
            this.medicineNameLabel = new System.Windows.Forms.Label();
            this.medicineNameTextBox = new System.Windows.Forms.TextBox();
            this.medicineDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.medicineDescriptionLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMedicineButton
            // 
            this.addMedicineButton.Location = new System.Drawing.Point(425, 248);
            this.addMedicineButton.Name = "addMedicineButton";
            this.addMedicineButton.Size = new System.Drawing.Size(75, 23);
            this.addMedicineButton.TabIndex = 0;
            this.addMedicineButton.Text = "Добавить";
            this.addMedicineButton.UseVisualStyleBackColor = true;
            this.addMedicineButton.Click += new System.EventHandler(this.AddMedicineButton_Click);
            // 
            // medicineNameLabel
            // 
            this.medicineNameLabel.AutoSize = true;
            this.medicineNameLabel.Location = new System.Drawing.Point(155, 166);
            this.medicineNameLabel.Name = "medicineNameLabel";
            this.medicineNameLabel.Size = new System.Drawing.Size(113, 13);
            this.medicineNameLabel.TabIndex = 1;
            this.medicineNameLabel.Text = "Название препарата";
            // 
            // medicineNameTextBox
            // 
            this.medicineNameTextBox.Location = new System.Drawing.Point(274, 163);
            this.medicineNameTextBox.Name = "medicineNameTextBox";
            this.medicineNameTextBox.Size = new System.Drawing.Size(310, 20);
            this.medicineNameTextBox.TabIndex = 2;
            // 
            // medicineDescriptionTextBox
            // 
            this.medicineDescriptionTextBox.Location = new System.Drawing.Point(274, 199);
            this.medicineDescriptionTextBox.Name = "medicineDescriptionTextBox";
            this.medicineDescriptionTextBox.Size = new System.Drawing.Size(310, 20);
            this.medicineDescriptionTextBox.TabIndex = 4;
            // 
            // medicineDescriptionLabel
            // 
            this.medicineDescriptionLabel.AutoSize = true;
            this.medicineDescriptionLabel.Location = new System.Drawing.Point(155, 202);
            this.medicineDescriptionLabel.Name = "medicineDescriptionLabel";
            this.medicineDescriptionLabel.Size = new System.Drawing.Size(113, 13);
            this.medicineDescriptionLabel.TabIndex = 3;
            this.medicineDescriptionLabel.Text = "Описание препарата";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(509, 248);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.medicineDescriptionTextBox);
            this.Controls.Add(this.medicineDescriptionLabel);
            this.Controls.Add(this.medicineNameTextBox);
            this.Controls.Add(this.medicineNameLabel);
            this.Controls.Add(this.addMedicineButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMedicineForm";
            this.Text = "MedicineForm";
            this.Load += new System.EventHandler(this.EditMedicineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addMedicineButton;
        private System.Windows.Forms.Label medicineNameLabel;
        private System.Windows.Forms.TextBox medicineNameTextBox;
        private System.Windows.Forms.TextBox medicineDescriptionTextBox;
        private System.Windows.Forms.Label medicineDescriptionLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}