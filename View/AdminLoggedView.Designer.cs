
namespace ToDoApplication123.View
{
    partial class AdminLoggedView
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
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddId = new System.Windows.Forms.TextBox();
            this.txtAddUsername = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.dtAddDateOfCreation = new System.Windows.Forms.DateTimePicker();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.toDoDataSet = new ToDoApplication123.ToDoDataSet();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofcreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new ToDoApplication123.ToDoDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toDoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Magneto", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeAdmin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(173, 9);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(540, 69);
            this.lblWelcomeAdmin.TabIndex = 1;
            this.lblWelcomeAdmin.Text = "Welcome, admin!";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(610, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddId
            // 
            this.txtAddId.Location = new System.Drawing.Point(137, 99);
            this.txtAddId.Name = "txtAddId";
            this.txtAddId.Size = new System.Drawing.Size(100, 20);
            this.txtAddId.TabIndex = 4;
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.Location = new System.Drawing.Point(137, 125);
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.Size = new System.Drawing.Size(100, 20);
            this.txtAddUsername.TabIndex = 5;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(137, 151);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtAddFirstName.TabIndex = 6;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(137, 177);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(100, 20);
            this.txtAddLastName.TabIndex = 7;
            // 
            // dtAddDateOfCreation
            // 
            this.dtAddDateOfCreation.Location = new System.Drawing.Point(90, 227);
            this.dtAddDateOfCreation.Name = "dtAddDateOfCreation";
            this.dtAddDateOfCreation.Size = new System.Drawing.Size(200, 20);
            this.dtAddDateOfCreation.TabIndex = 8;
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(137, 203);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(100, 20);
            this.txtAddPassword.TabIndex = 9;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(610, 203);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 10;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // toDoDataSet
            // 
            this.toDoDataSet.DataSetName = "ToDoDataSet";
            this.toDoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.dateofcreationDataGridViewTextBoxColumn});
            this.dgvUsers.DataSource = this.usersBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(90, 253);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(644, 197);
            this.dgvUsers.TabIndex = 11;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "First_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // dateofcreationDataGridViewTextBoxColumn
            // 
            this.dateofcreationDataGridViewTextBoxColumn.DataPropertyName = "Date_of_creation";
            this.dateofcreationDataGridViewTextBoxColumn.HeaderText = "Date_of_creation";
            this.dateofcreationDataGridViewTextBoxColumn.Name = "dateofcreationDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.toDoDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // AdminLoggedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToDoApplication123.Properties.Resources.admindashboard3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 492);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtAddPassword);
            this.Controls.Add(this.dtAddDateOfCreation);
            this.Controls.Add(this.txtAddLastName);
            this.Controls.Add(this.txtAddFirstName);
            this.Controls.Add(this.txtAddUsername);
            this.Controls.Add(this.txtAddId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWelcomeAdmin);
            this.Name = "AdminLoggedView";
            this.Text = "AdminLoggedView";
            this.Load += new System.EventHandler(this.AdminLoggedView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeAdmin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddId;
        private System.Windows.Forms.TextBox txtAddUsername;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.DateTimePicker dtAddDateOfCreation;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Button btnDisplay;
        private ToDoDataSet toDoDataSet;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ToDoDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofcreationDataGridViewTextBoxColumn;
    }
}