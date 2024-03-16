namespace BookManagement_HuynhThienNhan
{
    partial class BookManagerMainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManagerMainUI));
            lblHeader = new Label();
            grbSearchCriteria = new GroupBox();
            btnSearch = new Button();
            txtBookDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookName = new Label();
            lblDescriptionSearch = new Label();
            lblBookList = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dgvBookList = new DataGridView();
            lblCopyRight = new Label();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Historic", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(30, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(344, 62);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            lblHeader.Click += label1_Click;
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtBookDescription);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Controls.Add(lblDescriptionSearch);
            grbSearchCriteria.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            grbSearchCriteria.Location = new Point(94, 74);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Size = new Size(1230, 182);
            grbSearchCriteria.TabIndex = 5;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria  ";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.FromArgb(255, 255, 128);
            btnSearch.Location = new Point(1017, 115);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(139, 50);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(646, 83);
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(211, 47);
            txtBookDescription.TabIndex = 3;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(183, 83);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(211, 47);
            txtBookName.TabIndex = 2;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBookName.Location = new Point(28, 96);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(114, 28);
            lblBookName.TabIndex = 1;
            lblBookName.Text = "Book Name";
            // 
            // lblDescriptionSearch
            // 
            lblDescriptionSearch.AutoSize = true;
            lblDescriptionSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescriptionSearch.Location = new Point(448, 96);
            lblDescriptionSearch.Name = "lblDescriptionSearch";
            lblDescriptionSearch.Size = new Size(162, 28);
            lblDescriptionSearch.TabIndex = 3;
            lblDescriptionSearch.Text = "Book Description";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBookList.Location = new Point(30, 271);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(145, 41);
            lblBookList.TabIndex = 6;
            lblBookList.Text = "Book List";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(1090, 296);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(193, 53);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create a Book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Yellow;
            btnUpdate.Location = new Point(1090, 379);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(193, 53);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update a Book";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Yellow;
            btnDelete.Location = new Point(1090, 465);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(193, 53);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete a Book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button3_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Yellow;
            btnExit.Location = new Point(1090, 558);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(193, 53);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(60, 312);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(973, 309);
            dgvBookList.TabIndex = 7;
            dgvBookList.CellContentClick += dgvBookList_CellContentClick;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged_1;
            // 
            // lblCopyRight
            // 
            lblCopyRight.AutoSize = true;
            lblCopyRight.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCopyRight.Location = new Point(30, 642);
            lblCopyRight.Name = "lblCopyRight";
            lblCopyRight.Size = new Size(133, 31);
            lblCopyRight.TabIndex = 0;
            lblCopyRight.Text = "©Volka.24";
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(1398, 704);
            Controls.Add(lblCopyRight);
            Controls.Add(dgvBookList);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(lblBookList);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BookManagerMainUI";
            Text = "Book Manager";
            Load += Form1_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbSearchCriteria;
        private Label lblBookName;
        private Label lblDescriptionSearch;
        private Label lblBookList;
        private Button btnSearch;
        private TextBox txtBookDescription;
        private TextBox txtBookName;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dgvBookList;
        private Label lblCopyRight;
    }
}
