namespace BookManagement_HuynhThienNhan
{
    partial class BookManagerMainForm
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
            lblHeader = new Label();
            grbSearchCertiral = new GroupBox();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            btnSearch = new Button();
            lblBookDescription = new Label();
            lblBookName = new Label();
            lblBookList = new Label();
            dgvBookList = new DataGridView();
            lblCopyRight = new Label();
            btnAddBook = new Button();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            btnQuit = new Button();
            grbSearchCertiral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Historic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(27, 22);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(293, 54);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // grbSearchCertiral
            // 
            grbSearchCertiral.Controls.Add(txtDescription);
            grbSearchCertiral.Controls.Add(txtBookName);
            grbSearchCertiral.Controls.Add(btnSearch);
            grbSearchCertiral.Controls.Add(lblBookDescription);
            grbSearchCertiral.Controls.Add(lblBookName);
            grbSearchCertiral.Location = new Point(27, 88);
            grbSearchCertiral.Name = "grbSearchCertiral";
            grbSearchCertiral.Size = new Size(1019, 158);
            grbSearchCertiral.TabIndex = 1;
            grbSearchCertiral.TabStop = false;
            grbSearchCertiral.Text = "Search Certiral";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(370, 87);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(272, 27);
            txtDescription.TabIndex = 9;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(22, 87);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(255, 27);
            txtBookName.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(856, 87);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 41);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Location = new Point(370, 50);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(123, 20);
            lblBookDescription.TabIndex = 6;
            lblBookDescription.Text = "Book Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(22, 50);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(87, 20);
            lblBookName.TabIndex = 5;
            lblBookName.Text = "Book Name";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Location = new Point(27, 279);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(69, 20);
            lblBookList.TabIndex = 2;
            lblBookList.Text = "Book List";
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(27, 313);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(805, 370);
            dgvBookList.TabIndex = 3;
            dgvBookList.CellContentClick += dgvBookList_CellContentClick;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblCopyRight
            // 
            lblCopyRight.AutoSize = true;
            lblCopyRight.Location = new Point(27, 728);
            lblCopyRight.Name = "lblCopyRight";
            lblCopyRight.Size = new Size(98, 20);
            lblCopyRight.TabIndex = 4;
            lblCopyRight.Text = "© 2024 Volka";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(883, 313);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(119, 39);
            btnAddBook.TabIndex = 8;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(883, 392);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(119, 44);
            btnUpdateBook.TabIndex = 9;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(883, 483);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(119, 38);
            btnDeleteBook.TabIndex = 10;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(883, 695);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(119, 44);
            btnQuit.TabIndex = 11;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // BookManagerMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 791);
            Controls.Add(btnQuit);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnAddBook);
            Controls.Add(lblCopyRight);
            Controls.Add(dgvBookList);
            Controls.Add(lblBookList);
            Controls.Add(grbSearchCertiral);
            Controls.Add(lblHeader);
            Name = "BookManagerMainForm";
            Text = "Book Manager";
            Load += BookManagerMainForm_Load;
            grbSearchCertiral.ResumeLayout(false);
            grbSearchCertiral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbSearchCertiral;
        private Label lblBookList;
        private DataGridView dgvBookList;
        private Label lblCopyRight;
        private TextBox txtDescription;
        private TextBox txtBookName;
        private Button btnSearch;
        private Label lblBookDescription;
        private Label lblBookName;
        private Button btnAddBook;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private Button btnQuit;
    }
}
