namespace HuynhThienNhan_Hola
{
    partial class CreateEmployeeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmployeeName = new Label();
            lblDateBirth = new Label();
            lblDepartment = new Label();
            lblPosition = new Label();
            lblHireDate = new Label();
            txtEmployeeName = new TextBox();
            cbxDepartment = new ComboBox();
            cbxPosition = new ComboBox();
            dtpDateBirth = new DateTimePicker();
            dtpHireDate = new DateTimePicker();
            lblSkills = new Label();
            lbSkills = new ListBox();
            btnAddNew = new Button();
            SuspendLayout();
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(74, 86);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(115, 20);
            lblEmployeeName.TabIndex = 0;
            lblEmployeeName.Text = "EmployeeName";
            // 
            // lblDateBirth
            // 
            lblDateBirth.AutoSize = true;
            lblDateBirth.Location = new Point(74, 159);
            lblDateBirth.Name = "lblDateBirth";
            lblDateBirth.Size = new Size(94, 20);
            lblDateBirth.TabIndex = 1;
            lblDateBirth.Text = "Date of birth";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(74, 230);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(89, 20);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Department";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(74, 311);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(61, 20);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Position";
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Location = new Point(74, 405);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(69, 20);
            lblHireDate.TabIndex = 4;
            lblHireDate.Text = "HireDate";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(201, 79);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(250, 27);
            txtEmployeeName.TabIndex = 5;
            // 
            // cbxDepartment
            // 
            cbxDepartment.FormattingEnabled = true;
            cbxDepartment.Location = new Point(201, 222);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Size = new Size(250, 28);
            cbxDepartment.TabIndex = 6;
            // 
            // cbxPosition
            // 
            cbxPosition.FormattingEnabled = true;
            cbxPosition.Location = new Point(201, 303);
            cbxPosition.Name = "cbxPosition";
            cbxPosition.Size = new Size(250, 28);
            cbxPosition.TabIndex = 7;
            // 
            // dtpDateBirth
            // 
            dtpDateBirth.Location = new Point(201, 152);
            dtpDateBirth.Name = "dtpDateBirth";
            dtpDateBirth.Size = new Size(250, 27);
            dtpDateBirth.TabIndex = 8;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(201, 398);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(250, 27);
            dtpHireDate.TabIndex = 9;
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Location = new Point(639, 86);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(42, 20);
            lblSkills.TabIndex = 10;
            lblSkills.Text = "Skills";
            // 
            // lbSkills
            // 
            lbSkills.FormattingEnabled = true;
            lbSkills.ItemHeight = 20;
            lbSkills.Location = new Point(639, 112);
            lbSkills.Name = "lbSkills";
            lbSkills.Size = new Size(274, 224);
            lbSkills.TabIndex = 11;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(329, 482);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(269, 29);
            btnAddNew.TabIndex = 12;
            btnAddNew.Text = "Add new employee";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // CreateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 556);
            Controls.Add(btnAddNew);
            Controls.Add(lbSkills);
            Controls.Add(lblSkills);
            Controls.Add(dtpHireDate);
            Controls.Add(dtpDateBirth);
            Controls.Add(cbxPosition);
            Controls.Add(cbxDepartment);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblHireDate);
            Controls.Add(lblPosition);
            Controls.Add(lblDepartment);
            Controls.Add(lblDateBirth);
            Controls.Add(lblEmployeeName);
            Name = "CreateEmployeeForm";
            Text = "CreateEmployeeForm";
            Load += CreateEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployeeName;
        private Label lblDateBirth;
        private Label lblDepartment;
        private Label lblPosition;
        private Label lblHireDate;
        private TextBox txtEmployeeName;
        private ComboBox cbxDepartment;
        private ComboBox cbxPosition;
        private DateTimePicker dtpDateBirth;
        private DateTimePicker dtpHireDate;
        private Label lblSkills;
        private ListBox lbSkills;
        private Button btnAddNew;
    }
}
