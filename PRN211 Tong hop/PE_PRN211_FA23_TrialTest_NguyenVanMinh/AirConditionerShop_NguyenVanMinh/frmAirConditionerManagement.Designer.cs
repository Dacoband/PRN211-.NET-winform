namespace AirConditionerShop_NguyenVanMinh
{
    partial class frmAirConditionerManagement
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
            components = new System.ComponentModel.Container();
            lbID = new Label();
            txtACID = new TextBox();
            txtACName = new TextBox();
            txtWarranty = new TextBox();
            txtSound = new TextBox();
            txtFeatureFunction = new TextBox();
            txtPrice = new TextBox();
            lbACName = new Label();
            lbWarranty = new Label();
            lbSound = new Label();
            lbFeatureFunction = new Label();
            lbPrice = new Label();
            lbSupplierCompany = new Label();
            cboSupplierCompany = new ComboBox();
            btnNew = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dgvList = new DataGridView();
            airConditionerShop2023DbContextBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airConditionerShop2023DbContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(12, 19);
            lbID.Name = "lbID";
            lbID.Size = new Size(27, 20);
            lbID.TabIndex = 0;
            lbID.Text = "ID:";
            // 
            // txtACID
            // 
            txtACID.Location = new Point(160, 16);
            txtACID.Name = "txtACID";
            txtACID.Size = new Size(143, 27);
            txtACID.TabIndex = 1;
            // 
            // txtACName
            // 
            txtACName.Location = new Point(161, 65);
            txtACName.Name = "txtACName";
            txtACName.Size = new Size(158, 27);
            txtACName.TabIndex = 2;
            // 
            // txtWarranty
            // 
            txtWarranty.Location = new Point(161, 114);
            txtWarranty.Name = "txtWarranty";
            txtWarranty.Size = new Size(145, 27);
            txtWarranty.TabIndex = 3;
            // 
            // txtSound
            // 
            txtSound.Location = new Point(161, 161);
            txtSound.Name = "txtSound";
            txtSound.Size = new Size(142, 27);
            txtSound.TabIndex = 4;
            // 
            // txtFeatureFunction
            // 
            txtFeatureFunction.Location = new Point(160, 209);
            txtFeatureFunction.Name = "txtFeatureFunction";
            txtFeatureFunction.Size = new Size(174, 27);
            txtFeatureFunction.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(161, 264);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(181, 27);
            txtPrice.TabIndex = 6;
            // 
            // lbACName
            // 
            lbACName.AutoSize = true;
            lbACName.Location = new Point(6, 65);
            lbACName.Name = "lbACName";
            lbACName.Size = new Size(153, 20);
            lbACName.TabIndex = 8;
            lbACName.Text = "AirConditioner Name:";
            // 
            // lbWarranty
            // 
            lbWarranty.AutoSize = true;
            lbWarranty.Location = new Point(6, 117);
            lbWarranty.Name = "lbWarranty";
            lbWarranty.Size = new Size(71, 20);
            lbWarranty.TabIndex = 9;
            lbWarranty.Text = "Warranty:";
            // 
            // lbSound
            // 
            lbSound.AutoSize = true;
            lbSound.Location = new Point(6, 164);
            lbSound.Name = "lbSound";
            lbSound.Size = new Size(146, 20);
            lbSound.TabIndex = 10;
            lbSound.Text = "Sound Pressure Leve:";
            // 
            // lbFeatureFunction
            // 
            lbFeatureFunction.AutoSize = true;
            lbFeatureFunction.Location = new Point(6, 212);
            lbFeatureFunction.Name = "lbFeatureFunction";
            lbFeatureFunction.Size = new Size(127, 20);
            lbFeatureFunction.TabIndex = 11;
            lbFeatureFunction.Text = "Feature Functions:";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(6, 264);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(89, 20);
            lbPrice.TabIndex = 12;
            lbPrice.Text = "Dollar Price:";
            // 
            // lbSupplierCompany
            // 
            lbSupplierCompany.AutoSize = true;
            lbSupplierCompany.Location = new Point(6, 321);
            lbSupplierCompany.Name = "lbSupplierCompany";
            lbSupplierCompany.Size = new Size(134, 20);
            lbSupplierCompany.TabIndex = 13;
            lbSupplierCompany.Text = "Supplier Company:";
            // 
            // cboSupplierCompany
            // 
            cboSupplierCompany.FormattingEnabled = true;
            cboSupplierCompany.Location = new Point(163, 319);
            cboSupplierCompany.Name = "cboSupplierCompany";
            cboSupplierCompany.Size = new Size(183, 28);
            cboSupplierCompany.TabIndex = 14;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(6, 387);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 15;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 387);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(225, 387);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(325, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(437, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(352, 21);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowHeadersWidth = 51;
            dgvList.RowTemplate.Height = 29;
            dgvList.Size = new Size(446, 355);
            dgvList.TabIndex = 20;
            // 
            // airConditionerShop2023DbContextBindingSource
            // 
            airConditionerShop2023DbContextBindingSource.DataSource = typeof(BusinessObjects.Models.AirConditionerShop2023DbContext);
            // 
            // frmAirConditionerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 450);
            Controls.Add(dgvList);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(cboSupplierCompany);
            Controls.Add(lbSupplierCompany);
            Controls.Add(lbPrice);
            Controls.Add(lbFeatureFunction);
            Controls.Add(lbSound);
            Controls.Add(lbWarranty);
            Controls.Add(lbACName);
            Controls.Add(txtPrice);
            Controls.Add(txtFeatureFunction);
            Controls.Add(txtSound);
            Controls.Add(txtWarranty);
            Controls.Add(txtACName);
            Controls.Add(txtACID);
            Controls.Add(lbID);
            Name = "frmAirConditionerManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAirConditionerManagement";
            Load += frmAirConditionerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)airConditionerShop2023DbContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID;
        private TextBox txtACID;
        private TextBox txtACName;
        private TextBox txtWarranty;
        private TextBox txtSound;
        private TextBox txtFeatureFunction;
        private TextBox txtPrice;
        private Label lbACName;
        private Label lbWarranty;
        private Label lbSound;
        private Label lbFeatureFunction;
        private Label lbPrice;
        private Label lbSupplierCompany;
        private ComboBox cboSupplierCompany;
        private Button btnNew;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dgvList;
        private BindingSource airConditionerShop2023DbContextBindingSource;
    }
}