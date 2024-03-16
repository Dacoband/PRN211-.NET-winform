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
            btnSave = new Button();
            grbBookInfo = new GroupBox();
            cbxBookCategory = new ComboBox();
            dtpPubliccationDate = new DateTimePicker();
            txtAuthor = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            lblAuthor = new Label();
            txtBookDescription = new TextBox();
            lblBookCategory = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblPublicationDate = new Label();
            lblBookName = new Label();
            txtBookName = new TextBox();
            txtBookID = new TextBox();
            lblBookID = new Label();
            lblDescription = new Label();
            lblHeader = new Label();
            btnCancel = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(1141, 194);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(193, 53);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cbxBookCategory);
            grbBookInfo.Controls.Add(dtpPubliccationDate);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(txtBookDescription);
            grbBookInfo.Controls.Add(lblBookCategory);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(txtBookID);
            grbBookInfo.Controls.Add(lblBookID);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            grbBookInfo.Location = new Point(49, 74);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(1067, 576);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "Book Infomation";
            // 
            // cbxBookCategory
            // 
            cbxBookCategory.FormattingEnabled = true;
            cbxBookCategory.Location = new Point(217, 520);
            cbxBookCategory.Name = "cbxBookCategory";
            cbxBookCategory.Size = new Size(294, 49);
            cbxBookCategory.TabIndex = 7;
            // 
            // dtpPubliccationDate
            // 
            dtpPubliccationDate.Format = DateTimePickerFormat.Short;
            dtpPubliccationDate.Location = new Point(217, 329);
            dtpPubliccationDate.Name = "dtpPubliccationDate";
            dtpPubliccationDate.Size = new Size(211, 47);
            dtpPubliccationDate.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(217, 458);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(787, 47);
            txtAuthor.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(217, 393);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(211, 47);
            txtQuantity.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(600, 393);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(280, 47);
            txtPrice.TabIndex = 5;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor.Location = new Point(28, 477);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(73, 28);
            lblAuthor.TabIndex = 12;
            lblAuthor.Text = "Author";
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(217, 193);
            txtBookDescription.Multiline = true;
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.ScrollBars = ScrollBars.Vertical;
            txtBookDescription.Size = new Size(787, 118);
            txtBookDescription.TabIndex = 2;
            // 
            // lblBookCategory
            // 
            lblBookCategory.AutoSize = true;
            lblBookCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBookCategory.Location = new Point(28, 533);
            lblBookCategory.Name = "lblBookCategory";
            lblBookCategory.Size = new Size(142, 28);
            lblBookCategory.TabIndex = 9;
            lblBookCategory.Text = "Book Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(520, 406);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(54, 28);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantity.Location = new Point(28, 406);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(88, 28);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPublicationDate.Location = new Point(28, 344);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(156, 28);
            lblPublicationDate.TabIndex = 6;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBookName.Location = new Point(28, 138);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(114, 28);
            lblBookName.TabIndex = 5;
            lblBookName.Text = "Book Name";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(217, 125);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(787, 47);
            txtBookName.TabIndex = 1;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(217, 45);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(211, 47);
            txtBookID.TabIndex = 0;
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBookID.Location = new Point(28, 58);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(86, 28);
            lblBookID.TabIndex = 1;
            lblBookID.Text = "Book ID ";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(28, 217);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(162, 28);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Book Description";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Historic", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(49, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(484, 62);
            lblHeader.TabIndex = 9;
            lblHeader.Text = "Add | Update A Book";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(1141, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(193, 53);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1346, 685);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            Name = "BookDetailForm";
            Text = "Add | Update a Book";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private GroupBox grbBookInfo;
        private TextBox txtBookName;
        private TextBox txtBookID;
        private Label lblBookID;
        private Label lblDescription;
        private Label lblHeader;
        private TextBox txtAuthor;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label lblAuthor;
        private TextBox txtBookDescription;
        private Label lblBookCategory;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblPublicationDate;
        private Label lblBookName;
        private ComboBox cbxBookCategory;
        private DateTimePicker dtpPubliccationDate;
        private Button btnCancel;
    }
}