namespace DesktopDoctor
{
    partial class EditEmployeeForm
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
            this.SecurityLevelsComboBox = new System.Windows.Forms.ComboBox();
            this.SecurityLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.fenameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronimycLabel = new System.Windows.Forms.Label();
            this.fenameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronimicTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.comfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.securityLevelLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityLevelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SecurityLevelsComboBox
            // 
            this.SecurityLevelsComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecurityLevelsComboBox.DataSource = this.SecurityLevelsBindingSource;
            this.SecurityLevelsComboBox.DisplayMember = "Name";
            this.SecurityLevelsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecurityLevelsComboBox.FormattingEnabled = true;
            this.SecurityLevelsComboBox.Location = new System.Drawing.Point(210, 235);
            this.SecurityLevelsComboBox.Name = "SecurityLevelsComboBox";
            this.SecurityLevelsComboBox.Size = new System.Drawing.Size(141, 21);
            this.SecurityLevelsComboBox.TabIndex = 1;
            this.SecurityLevelsComboBox.ValueMember = "Id";
            // 
            // SecurityLevelsBindingSource
            // 
            this.SecurityLevelsBindingSource.DataSource = typeof(DesktopDoctor.SecurityLevel);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmButton.Location = new System.Drawing.Point(336, 284);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Создать";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(166, 160);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTextBox.Location = new System.Drawing.Point(210, 157);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(141, 20);
            this.loginTextBox.TabIndex = 5;
            // 
            // fenameLabel
            // 
            this.fenameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fenameLabel.AutoSize = true;
            this.fenameLabel.Location = new System.Drawing.Point(407, 163);
            this.fenameLabel.Name = "fenameLabel";
            this.fenameLabel.Size = new System.Drawing.Size(56, 13);
            this.fenameLabel.TabIndex = 6;
            this.fenameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(434, 189);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Имя";
            // 
            // patronimycLabel
            // 
            this.patronimycLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patronimycLabel.AutoSize = true;
            this.patronimycLabel.Location = new System.Drawing.Point(409, 215);
            this.patronimycLabel.Name = "patronimycLabel";
            this.patronimycLabel.Size = new System.Drawing.Size(54, 13);
            this.patronimycLabel.TabIndex = 8;
            this.patronimycLabel.Text = "Отчество";
            // 
            // fenameTextBox
            // 
            this.fenameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fenameTextBox.Location = new System.Drawing.Point(471, 160);
            this.fenameTextBox.Name = "fenameTextBox";
            this.fenameTextBox.Size = new System.Drawing.Size(190, 20);
            this.fenameTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(471, 186);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(190, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // patronimicTextBox
            // 
            this.patronimicTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patronimicTextBox.Location = new System.Drawing.Point(471, 212);
            this.patronimicTextBox.Name = "patronimicTextBox";
            this.patronimicTextBox.Size = new System.Drawing.Size(190, 20);
            this.patronimicTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(210, 183);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(141, 20);
            this.passwordTextBox.TabIndex = 12;
            // 
            // comfirmPasswordTextBox
            // 
            this.comfirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comfirmPasswordTextBox.Location = new System.Drawing.Point(210, 209);
            this.comfirmPasswordTextBox.Name = "comfirmPasswordTextBox";
            this.comfirmPasswordTextBox.Size = new System.Drawing.Size(141, 20);
            this.comfirmPasswordTextBox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(159, 186);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Пароль";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(77, 212);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(127, 13);
            this.confirmPasswordLabel.TabIndex = 15;
            this.confirmPasswordLabel.Text = "Подтверждение пароля";
            // 
            // securityLevelLabel
            // 
            this.securityLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.securityLevelLabel.AutoSize = true;
            this.securityLevelLabel.Location = new System.Drawing.Point(110, 238);
            this.securityLevelLabel.Name = "securityLevelLabel";
            this.securityLevelLabel.Size = new System.Drawing.Size(94, 13);
            this.securityLevelLabel.TabIndex = 16;
            this.securityLevelLabel.Text = "Уровень доступа";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.Location = new System.Drawing.Point(437, 284);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.securityLevelLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.comfirmPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.patronimicTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.fenameTextBox);
            this.Controls.Add(this.patronimycLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.fenameLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SecurityLevelsComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEmployeeForm";
            this.ShowIcon = false;
            this.Text = "EditEmployeeForm";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SecurityLevelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SecurityLevelsComboBox;
        private System.Windows.Forms.BindingSource SecurityLevelsBindingSource;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label fenameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label patronimycLabel;
        private System.Windows.Forms.TextBox fenameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox patronimicTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox comfirmPasswordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label securityLevelLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}