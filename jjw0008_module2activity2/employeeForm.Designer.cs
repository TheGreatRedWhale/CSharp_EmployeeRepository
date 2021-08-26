namespace jjw0008_module2activity2
{
    partial class employeeForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.MaskedTextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.positionBox = new System.Windows.Forms.TextBox();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departmentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(121, 14);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(31, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID #:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(164, 14);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(65, 13);
            this.departmentLabel.TabIndex = 2;
            this.departmentLabel.Text = "Department:";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(248, 15);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(47, 13);
            this.positionLabel.TabIndex = 3;
            this.positionLabel.Text = "Position:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(124, 30);
            this.idBox.Mask = "00000";
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(37, 20);
            this.idBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 30);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(106, 20);
            this.nameBox.TabIndex = 4;
            this.nameBox.Text = " ";
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(167, 30);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(75, 20);
            this.departmentBox.TabIndex = 6;
            this.departmentBox.Text = " ";
            // 
            // positionBox
            // 
            this.positionBox.Location = new System.Drawing.Point(248, 30);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(75, 20);
            this.positionBox.TabIndex = 7;
            this.positionBox.Text = " ";
            // 
            // employeeListView
            // 
            this.employeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.idColumn,
            this.departmentColumn,
            this.positionColumn});
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(12, 85);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(311, 256);
            this.employeeListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.employeeListView.TabIndex = 10;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name:";
            this.nameColumn.Width = 105;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID #:";
            this.idColumn.Width = 44;
            // 
            // departmentColumn
            // 
            this.departmentColumn.Text = "Department:";
            this.departmentColumn.Width = 87;
            // 
            // positionColumn
            // 
            this.positionColumn.Text = "Position:";
            this.positionColumn.Width = 71;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 56);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(149, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add Employee";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addEmployee);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(167, 56);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(156, 23);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshEmployees);
            // 
            // employeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 353);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeeListView);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "employeeForm";
            this.Text = "Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.MaskedTextBox idBox;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.TextBox positionBox;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader departmentColumn;
        private System.Windows.Forms.ColumnHeader positionColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button refreshButton;
    }
}

