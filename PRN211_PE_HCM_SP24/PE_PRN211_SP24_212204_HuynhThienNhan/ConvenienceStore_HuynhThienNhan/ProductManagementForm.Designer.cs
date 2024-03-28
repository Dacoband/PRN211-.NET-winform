namespace ConvenienceStore_HuynhThienNhan
{
    partial class ProductManagementForm
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
            grbSearch = new GroupBox();
            txtDescription = new TextBox();
            txtProductName = new TextBox();
            btnSearch = new Button();
            lblDescription = new Label();
            lblName = new Label();
            dgvProductList = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnQuit = new Button();
            lblProductList = new Label();
            grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(78, 19);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(345, 53);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Product Manager";
            // 
            // grbSearch
            // 
            grbSearch.Controls.Add(txtDescription);
            grbSearch.Controls.Add(txtProductName);
            grbSearch.Controls.Add(btnSearch);
            grbSearch.Controls.Add(lblDescription);
            grbSearch.Controls.Add(lblName);
            grbSearch.Location = new Point(12, 86);
            grbSearch.Name = "grbSearch";
            grbSearch.Size = new Size(1164, 90);
            grbSearch.TabIndex = 1;
            grbSearch.TabStop = false;
            grbSearch.Text = "Search Product";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(641, 35);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(365, 27);
            txtDescription.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(118, 35);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(381, 27);
            txtProductName.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1039, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(518, 38);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            lblDescription.Click += label3_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Product Name";
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(12, 224);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.Size = new Size(891, 355);
            dgvProductList.TabIndex = 2;
            dgvProductList.SelectionChanged += dgvProductList_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(982, 245);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(982, 322);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(163, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Product";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(982, 403);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(163, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(982, 537);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(163, 29);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblProductList
            // 
            lblProductList.AutoSize = true;
            lblProductList.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductList.Location = new Point(18, 189);
            lblProductList.Name = "lblProductList";
            lblProductList.Size = new Size(147, 31);
            lblProductList.TabIndex = 8;
            lblProductList.Text = "Product List";
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 612);
            Controls.Add(lblProductList);
            Controls.Add(btnQuit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvProductList);
            Controls.Add(grbSearch);
            Controls.Add(lblHeader);
            Name = "ProductManagementForm";
            Text = "Product Management Form";
            Load += ProductManagementForm_Load;
            grbSearch.ResumeLayout(false);
            grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbSearch;
        private TextBox txtDescription;
        private TextBox txtProductName;
        private Button btnSearch;
        private Label lblDescription;
        private Label lblName;
        private DataGridView dgvProductList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnQuit;
        private Label lblProductList;
    }
}
