namespace BookManagement_HuynhThienNhan
{
    partial class BookDetailForm
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
            grbBookInfo = new GroupBox();
            cboBookCategoryId = new ComboBox();
            label1 = new Label();
            dtpPublicationDate = new DateTimePicker();
            txtAuthor = new TextBox();
            lblAuthor = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            lblPublicationDate = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtBookName = new TextBox();
            txtBookId = new TextBox();
            lblBookName = new Label();
            lblBookId = new Label();
            btnSave = new Button();
            lblHeader = new Label();
            btnClose = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboBookCategoryId);
            grbBookInfo.Controls.Add(label1);
            grbBookInfo.Controls.Add(dtpPublicationDate);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(txtBookId);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblBookId);
            grbBookInfo.Location = new Point(40, 97);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(785, 630);
            grbBookInfo.TabIndex = 4;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "Book Information";
            grbBookInfo.Enter += grbSearchCertiral_Enter;
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(21, 567);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(408, 28);
            cboBookCategoryId.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 544);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 21;
            label1.Text = "Category";
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Location = new Point(21, 442);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(270, 27);
            dtpPublicationDate.TabIndex = 20;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(19, 504);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(702, 27);
            txtAuthor.TabIndex = 19;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(19, 480);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.TabIndex = 18;
            lblAuthor.Text = "Author";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(565, 442);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(156, 27);
            txtPrice.TabIndex = 17;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(564, 419);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(306, 442);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(195, 27);
            txtQuantity.TabIndex = 15;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(306, 419);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 14;
            lblQuantity.Text = "Quantity";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Location = new Point(21, 419);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(119, 20);
            lblPublicationDate.TabIndex = 12;
            lblPublicationDate.Text = "Publication Date";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(21, 183);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(701, 219);
            txtDescription.TabIndex = 11;
            txtDescription.TextChanged += textBox1_TextChanged;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(21, 160);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(20, 121);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(643, 27);
            txtBookName.TabIndex = 9;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(23, 55);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(642, 27);
            txtBookId.TabIndex = 8;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(21, 98);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(87, 20);
            lblBookName.TabIndex = 6;
            lblBookName.Text = "Book Name";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(23, 32);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(62, 20);
            lblBookId.TabIndex = 5;
            lblBookId.Text = "Book ID";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(907, 195);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(218, 41);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSearch_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Historic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(40, 31);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(376, 54);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Add | Update Book";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(907, 357);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(218, 41);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 756);
            Controls.Add(btnClose);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            Controls.Add(btnSave);
            Name = "BookDetailForm";
            Text = "BookDetailForm";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbBookInfo;
        private TextBox txtAuthor;
        private Label lblAuthor;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private Label lblPublicationDate;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtBookName;
        private TextBox txtBookId;
        private Button btnSave;
        private Label lblBookName;
        private Label lblBookId;
        private Label lblHeader;
        private DateTimePicker dtpPublicationDate;
        private Button btnClose;
        private ComboBox cboBookCategoryId;
        private Label label1;
    }
}