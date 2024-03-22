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
            txtPrice = new Label();
            dtpReleaseDay = new DateTimePicker();
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
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Info";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(99, 108);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(239, 78);
            txtDescription.TabIndex = 14;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(87, 320);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(251, 23);
            cbCategory.TabIndex = 13;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(87, 280);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(251, 23);
            txtAuthor.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(238, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(87, 233);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(99, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 23);
            txtName.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(99, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 323);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 6;
            label8.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 280);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 5;
            label7.Text = "Author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 236);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 4;
            label6.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 198);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 3;
            label5.Text = "Released Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 111);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 2;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 71);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 1;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 38);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 1;
            label1.Text = "Book Manager";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(16, 470);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 74);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(259, 34);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Exit";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // button3
            // 
            button3.Location = new Point(178, 34);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(97, 34);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(16, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(406, 67);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(382, 77);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            // 
            // button5
            // 
            button5.Location = new Point(287, 33);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 2;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(76, 34);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(205, 23);
            textBox6.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 37);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 0;
            label9.Text = "Keyword";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(406, 184);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 3;
            label10.Text = "Book List";
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = SystemColors.ControlLightLight;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.GridColor = SystemColors.ControlLightLight;
            dgvBookList.Location = new Point(410, 202);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowTemplate.Height = 25;
            dgvBookList.Size = new Size(378, 342);
            dgvBookList.TabIndex = 4;
            dgvBookList.CellContentClick += dgvBookList_CellContentClick;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Location = new Point(193, 236);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(33, 15);
            txtPrice.TabIndex = 15;
            txtPrice.Text = "Price";
            // 
            // dtpReleaseDay
            // 
            dtpReleaseDay.Location = new Point(101, 192);
            dtpReleaseDay.Name = "dtpReleaseDay";
            dtpReleaseDay.Size = new Size(200, 23);
            dtpReleaseDay.TabIndex = 16;
            // 
            // BookManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(dgvBookList);
            Controls.Add(label10);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
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