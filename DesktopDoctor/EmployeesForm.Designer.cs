namespace DesktopDoctor
{
    partial class EmployeesForm
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
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.addNewEmployeeButton = new System.Windows.Forms.Button();
            this.changeEmployeeButton = new System.Windows.Forms.Button();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.ComeBackButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.AllowUserToDeleteRows = false;
            this.employeesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.loginDataGridViewTextBoxColumn,
            this.Fename,
            this.Name1,
            this.Patronymic,
            this.securityLevelDataGridViewTextBoxColumn});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 57);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDataGridView.Size = new System.Drawing.Size(776, 366);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // addNewEmployeeButton
            // 
            this.addNewEmployeeButton.Location = new System.Drawing.Point(12, 28);
            this.addNewEmployeeButton.Name = "addNewEmployeeButton";
            this.addNewEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.addNewEmployeeButton.TabIndex = 1;
            this.addNewEmployeeButton.Text = "Добавить";
            this.addNewEmployeeButton.UseVisualStyleBackColor = true;
            this.addNewEmployeeButton.Click += new System.EventHandler(this.addNewEmployeeButton_Click);
            // 
            // changeEmployeeButton
            // 
            this.changeEmployeeButton.Location = new System.Drawing.Point(93, 28);
            this.changeEmployeeButton.Name = "changeEmployeeButton";
            this.changeEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.changeEmployeeButton.TabIndex = 2;
            this.changeEmployeeButton.Text = "Изменить";
            this.changeEmployeeButton.UseVisualStyleBackColor = true;
            this.changeEmployeeButton.Click += new System.EventHandler(this.changeEmployeeButton_Click);
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.Location = new System.Drawing.Point(174, 28);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.removeEmployeeButton.TabIndex = 3;
            this.removeEmployeeButton.Text = "Удалить";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.removeEmployeeButton_Click);
            // 
            // ComeBackButton
            // 
            this.ComeBackButton.Location = new System.Drawing.Point(713, 28);
            this.ComeBackButton.Name = "ComeBackButton";
            this.ComeBackButton.Size = new System.Drawing.Size(75, 23);
            this.ComeBackButton.TabIndex = 4;
            this.ComeBackButton.Text = "Назад";
            this.ComeBackButton.UseVisualStyleBackColor = true;
            this.ComeBackButton.Click += new System.EventHandler(this.ComeBackButton_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Fename
            // 
            this.Fename.DataPropertyName = "Fename";
            this.Fename.HeaderText = "Fename";
            this.Fename.Name = "Fename";
            this.Fename.ReadOnly = true;
            // 
            // Name1
            // 
            this.Name1.DataPropertyName = "Name";
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // Patronymic
            // 
            this.Patronymic.DataPropertyName = "Patronymic";
            this.Patronymic.HeaderText = "Patronymic";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // securityLevelDataGridViewTextBoxColumn
            // 
            this.securityLevelDataGridViewTextBoxColumn.DataPropertyName = "SecurityLevel";
            this.securityLevelDataGridViewTextBoxColumn.HeaderText = "SecurityLevel";
            this.securityLevelDataGridViewTextBoxColumn.Name = "securityLevelDataGridViewTextBoxColumn";
            this.securityLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(DesktopDoctor.AccountView);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.ControlBox = false;
            this.Controls.Add(this.ComeBackButton);
            this.Controls.Add(this.removeEmployeeButton);
            this.Controls.Add(this.changeEmployeeButton);
            this.Controls.Add(this.addNewEmployeeButton);
            this.Controls.Add(this.employeesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesForm";
            this.ShowIcon = false;
            this.Text = "EmployeesForm";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Button addNewEmployeeButton;
        private System.Windows.Forms.Button changeEmployeeButton;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.Button ComeBackButton;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityLevelDataGridViewTextBoxColumn;
    }
}