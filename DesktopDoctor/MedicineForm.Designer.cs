namespace DesktopDoctor
{
    partial class MedicineForm
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
            this.btnAddNewMedicine = new System.Windows.Forms.Button();
            this.labelNameMedicine = new System.Windows.Forms.Label();
            this.tbxNameMedicine = new System.Windows.Forms.TextBox();
            this.tbxDescriptionMedicine = new System.Windows.Forms.TextBox();
            this.labelDescriptionMedicine = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewMedicine
            // 
            this.btnAddNewMedicine.Location = new System.Drawing.Point(425, 248);
            this.btnAddNewMedicine.Name = "btnAddNewMedicine";
            this.btnAddNewMedicine.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewMedicine.TabIndex = 0;
            this.btnAddNewMedicine.Text = "Добавить";
            this.btnAddNewMedicine.UseVisualStyleBackColor = true;
            this.btnAddNewMedicine.Click += new System.EventHandler(this.btnAddNewMedicine_Click);
            // 
            // labelNameMedicine
            // 
            this.labelNameMedicine.AutoSize = true;
            this.labelNameMedicine.Location = new System.Drawing.Point(155, 166);
            this.labelNameMedicine.Name = "labelNameMedicine";
            this.labelNameMedicine.Size = new System.Drawing.Size(113, 13);
            this.labelNameMedicine.TabIndex = 1;
            this.labelNameMedicine.Text = "Название препарата";
            // 
            // tbxNameMedicine
            // 
            this.tbxNameMedicine.Location = new System.Drawing.Point(274, 163);
            this.tbxNameMedicine.Name = "tbxNameMedicine";
            this.tbxNameMedicine.Size = new System.Drawing.Size(310, 20);
            this.tbxNameMedicine.TabIndex = 2;
            // 
            // tbxDescriptionMedicine
            // 
            this.tbxDescriptionMedicine.Location = new System.Drawing.Point(274, 199);
            this.tbxDescriptionMedicine.Name = "tbxDescriptionMedicine";
            this.tbxDescriptionMedicine.Size = new System.Drawing.Size(310, 20);
            this.tbxDescriptionMedicine.TabIndex = 4;
            // 
            // labelDescriptionMedicine
            // 
            this.labelDescriptionMedicine.AutoSize = true;
            this.labelDescriptionMedicine.Location = new System.Drawing.Point(155, 202);
            this.labelDescriptionMedicine.Name = "labelDescriptionMedicine";
            this.labelDescriptionMedicine.Size = new System.Drawing.Size(113, 13);
            this.labelDescriptionMedicine.TabIndex = 3;
            this.labelDescriptionMedicine.Text = "Описание препарата";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(509, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxDescriptionMedicine);
            this.Controls.Add(this.labelDescriptionMedicine);
            this.Controls.Add(this.tbxNameMedicine);
            this.Controls.Add(this.labelNameMedicine);
            this.Controls.Add(this.btnAddNewMedicine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineForm";
            this.Text = "MedicineForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewMedicine;
        private System.Windows.Forms.Label labelNameMedicine;
        private System.Windows.Forms.TextBox tbxNameMedicine;
        private System.Windows.Forms.TextBox tbxDescriptionMedicine;
        private System.Windows.Forms.Label labelDescriptionMedicine;
        private System.Windows.Forms.Button btnCancel;
    }
}