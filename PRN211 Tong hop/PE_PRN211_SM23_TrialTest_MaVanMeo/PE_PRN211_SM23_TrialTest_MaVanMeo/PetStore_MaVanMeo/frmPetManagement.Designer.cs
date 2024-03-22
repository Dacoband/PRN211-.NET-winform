namespace PetStore_MaVanMeo
{
    partial class frmPetManagement
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPetId = new TextBox();
            txtDescription = new TextBox();
            txtPetName = new TextBox();
            dtImportDate = new DateTimePicker();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            cboPetGroup = new ComboBox();
            dgvPet = new DataGridView();
            groupBox1 = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            label8 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPet).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 54);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 0;
            label1.Text = "Pet Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(772, 214);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 1;
            label2.Text = "Pet Group";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 309);
            label3.Name = "label3";
            label3.Size = new Size(60, 30);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(772, 130);
            label4.Name = "label4";
            label4.Size = new Size(95, 30);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(772, 50);
            label5.Name = "label5";
            label5.Size = new Size(122, 30);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 218);
            label6.Name = "label6";
            label6.Size = new Size(130, 30);
            label6.TabIndex = 5;
            label6.Text = "Import Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 134);
            label7.Name = "label7";
            label7.Size = new Size(107, 30);
            label7.TabIndex = 6;
            label7.Text = "Pet Name";
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(279, 52);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(348, 37);
            txtPetId.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(963, 43);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(348, 37);
            txtDescription.TabIndex = 8;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(279, 127);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(348, 37);
            txtPetName.TabIndex = 10;
            // 
            // dtImportDate
            // 
            dtImportDate.Location = new Point(284, 218);
            dtImportDate.Name = "dtImportDate";
            dtImportDate.Size = new Size(350, 37);
            dtImportDate.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(284, 302);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(348, 37);
            txtPrice.TabIndex = 12;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(963, 127);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(348, 37);
            txtQuantity.TabIndex = 13;
            // 
            // cboPetGroup
            // 
            cboPetGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPetGroup.FormattingEnabled = true;
            cboPetGroup.Location = new Point(963, 211);
            cboPetGroup.Name = "cboPetGroup";
            cboPetGroup.Size = new Size(348, 38);
            cboPetGroup.TabIndex = 14;
            // 
            // dgvPet
            // 
            dgvPet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPet.Location = new Point(63, 401);
            dgvPet.Name = "dgvPet";
            dgvPet.ReadOnly = true;
            dgvPet.RowHeadersWidth = 72;
            dgvPet.RowTemplate.Height = 39;
            dgvPet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPet.Size = new Size(1248, 437);
            dgvPet.TabIndex = 15;
            dgvPet.CellDoubleClick += dgvPet_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Location = new Point(63, 857);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1248, 155);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(947, 62);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 58);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(687, 62);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 58);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(440, 62);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 58);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(189, 62);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 58);
            btnSave.TabIndex = 0;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(772, 309);
            label8.Name = "label8";
            label8.Size = new Size(120, 30);
            label8.TabIndex = 17;
            label8.Text = "Input value";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(963, 311);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(202, 37);
            txtSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1195, 306);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 46);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmPetManagement
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 1031);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(dgvPet);
            Controls.Add(cboPetGroup);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(dtImportDate);
            Controls.Add(txtPetName);
            Controls.Add(txtDescription);
            Controls.Add(txtPetId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPetManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPetManagement";
            Load += frmPetManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPet).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPetId;
        private TextBox txtDescription;
        private TextBox txtPetName;
        private DateTimePicker dtImportDate;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private ComboBox cboPetGroup;
        private DataGridView dgvPet;
        private GroupBox groupBox1;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Label label8;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}