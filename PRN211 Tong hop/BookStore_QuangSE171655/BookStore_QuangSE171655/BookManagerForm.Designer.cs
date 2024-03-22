namespace BookStore_QuangSE171655
{
    partial class BookManagerForm
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
            groupBox1 = new GroupBox();
            dtpReleaseDay = new DateTimePicker();
            txtPrice = new Label();
            txtDescription = new TextBox();
            cbCategory = new ComboBox();
            txtAuthor = new TextBox();
            textBox4 = new TextBox();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClose = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            button5 = new Button();
            textBox6 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            dgvBookList = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpReleaseDay);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 77);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(413, 504);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Info";
            // 
            // dtpReleaseDay
            // 
            dtpReleaseDay.Location = new Point(115, 256);
            dtpReleaseDay.Margin = new Padding(3, 4, 3, 4);
            dtpReleaseDay.Name = "dtpReleaseDay";
            dtpReleaseDay.Size = new Size(228, 27);
            dtpReleaseDay.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Location = new Point(221, 315);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(41, 20);
            txtPrice.TabIndex = 15;
            txtPrice.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(113, 144);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(273, 103);
            txtDescription.TabIndex = 14;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(99, 427);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(286, 28);
            cbCategory.TabIndex = 13;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(99, 373);
            txtAuthor.Margin = new Padding(3, 4, 3, 4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(286, 27);
            txtAuthor.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(272, 311);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(99, 311);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(114, 27);
            txtQuantity.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 91);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 27);
            txtName.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(113, 51);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(114, 27);
            txtID.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 431);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 6;
            label8.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 373);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 5;
            label7.Text = "Author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 315);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 4;
            label6.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 264);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 3;
            label5.Text = "Released Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 148);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 2;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 95);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 51);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 12);
            label1.Name = "label1";
            label1.Size = new Size(239, 46);
            label1.TabIndex = 1;
            label1.Text = "Book Manager";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(18, 627);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(408, 99);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(296, 45);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "Exit";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // button3
            // 
            button3.Location = new Point(203, 45);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(111, 45);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 45);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(464, 89);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(437, 103);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            // 
            // button5
            // 
            button5.Location = new Point(328, 44);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 2;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(87, 45);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(234, 27);
            textBox6.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 49);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 0;
            label9.Text = "Keyword";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(464, 245);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 3;
            label10.Text = "Book List";
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = SystemColors.ControlLightLight;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.GridColor = SystemColors.ControlLightLight;
            dgvBookList.Location = new Point(469, 269);
            dgvBookList.Margin = new Padding(3, 4, 3, 4);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 25;
            dgvBookList.Size = new Size(432, 456);
            dgvBookList.TabIndex = 4;
            dgvBookList.CellContentClick += dgvBookList_CellContentClick;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // BookManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 757);
            Controls.Add(dgvBookList);
            Controls.Add(label10);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += BookManagerForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox txtQuantity;
        private TextBox txtName;
        private TextBox txtID;
        private Label label8;
        private ComboBox cbCategory;
        private DateTimePicker dateTimePicker1;
        private TextBox txtAuthor;
        private GroupBox groupBox2;
        private Button btnClose;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private Label label9;
        private Button button5;
        private TextBox textBox6;
        private Label label10;
        private DataGridView dgvBookList;
        private TextBox txtDescription;
        private Label txtPrice;
        private DateTimePicker dtpReleaseDay;
    }
}