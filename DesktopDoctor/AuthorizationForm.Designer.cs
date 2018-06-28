namespace DesktopDoctor
{
    partial class AuthorizationForm
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
            this.toPatientsButton = new System.Windows.Forms.Button();
            this.toMedicinesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toPatientsButton
            // 
            this.toPatientsButton.Location = new System.Drawing.Point(78, 379);
            this.toPatientsButton.Name = "toPatientsButton";
            this.toPatientsButton.Size = new System.Drawing.Size(99, 23);
            this.toPatientsButton.TabIndex = 0;
            this.toPatientsButton.Text = "Пациенты";
            this.toPatientsButton.UseVisualStyleBackColor = true;
            this.toPatientsButton.Click += new System.EventHandler(this.ToPatientsButton_Click);
            // 
            // toMedicinesButton
            // 
            this.toMedicinesButton.Location = new System.Drawing.Point(593, 379);
            this.toMedicinesButton.Name = "toMedicinesButton";
            this.toMedicinesButton.Size = new System.Drawing.Size(107, 23);
            this.toMedicinesButton.TabIndex = 1;
            this.toMedicinesButton.Text = "Медикаменты";
            this.toMedicinesButton.UseVisualStyleBackColor = true;
            this.toMedicinesButton.Click += new System.EventHandler(this.ToMedicinesButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.toMedicinesButton);
            this.Controls.Add(this.toPatientsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toPatientsButton;
        private System.Windows.Forms.Button toMedicinesButton;
    }
}