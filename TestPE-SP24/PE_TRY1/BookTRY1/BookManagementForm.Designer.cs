namespace BookTRY1
{
    partial class BookManagementForm
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
            dgvBookList = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnQuit = new Button();
            grbSearchBook = new GroupBox();
            lblPrice = new Label();
            lblBookName = new Label();
            txtBookPrice = new TextBox();
            txtBookName = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            grbSearchBook.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Historic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(316, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(251, 46);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            lblHeader.Click += lblHeader_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(12, 149);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(928, 282);
            dgvBookList.TabIndex = 1;
            dgvBookList.CellContentClick += dgvBookList_CellContentClick;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(140, 448);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(337, 448);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Book";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(560, 448);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Book";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(808, 502);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // grbSearchBook
            // 
            grbSearchBook.Controls.Add(lblPrice);
            grbSearchBook.Controls.Add(lblBookName);
            grbSearchBook.Controls.Add(txtBookPrice);
            grbSearchBook.Controls.Add(txtBookName);
            grbSearchBook.Controls.Add(btnSearch);
            grbSearchBook.Location = new Point(12, 71);
            grbSearchBook.Name = "grbSearchBook";
            grbSearchBook.Size = new Size(928, 62);
            grbSearchBook.TabIndex = 6;
            grbSearchBook.TabStop = false;
            grbSearchBook.Text = "Search Book";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(548, 30);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(18, 30);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(87, 20);
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            // 
            // txtBookPrice
            // 
            txtBookPrice.Location = new Point(595, 23);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(165, 27);
            txtBookPrice.TabIndex = 2;
            txtBookPrice.TextChanged += textBox2_TextChanged;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(128, 23);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(379, 27);
            txtBookName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(801, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 543);
            Controls.Add(grbSearchBook);
            Controls.Add(btnQuit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvBookList);
            Controls.Add(lblHeader);
            Name = "BookManagementForm";
            Text = "Form1";
            Load += BookManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            grbSearchBook.ResumeLayout(false);
            grbSearchBook.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private DataGridView dgvBookList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnQuit;
        private GroupBox grbSearchBook;
        private Label lblPrice;
        private Label lblBookName;
        private TextBox txtBookPrice;
        private TextBox txtBookName;
        private Button btnSearch;
    }
}
