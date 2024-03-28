namespace ConvenienceStore_HuynhThienNhan
{
    partial class ProductDetailForm
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
            grbSearch = new GroupBox();
            txtDescription = new TextBox();
            txtProductName = new TextBox();
            btnSearch = new Button();
            lblDescription = new Label();
            lblName = new Label();
            lblHeader = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            grbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // grbSearch
            // 
            grbSearch.Controls.Add(dateTimePicker1);
            grbSearch.Controls.Add(textBox3);
            grbSearch.Controls.Add(textBox2);
            grbSearch.Controls.Add(textBox1);
            grbSearch.Controls.Add(label4);
            grbSearch.Controls.Add(label3);
            grbSearch.Controls.Add(label2);
            grbSearch.Controls.Add(label1);
            grbSearch.Controls.Add(txtDescription);
            grbSearch.Controls.Add(txtProductName);
            grbSearch.Controls.Add(lblDescription);
            grbSearch.Controls.Add(lblName);
            grbSearch.Location = new Point(32, 86);
            grbSearch.Name = "grbSearch";
            grbSearch.Size = new Size(660, 538);
            grbSearch.TabIndex = 3;
            grbSearch.TabStop = false;
            grbSearch.Text = "Search Product";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(137, 116);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(268, 27);
            txtDescription.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(137, 48);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(284, 27);
            txtProductName.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(828, 181);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(122, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Save";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(6, 123);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "ProductName";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 51);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 20);
            lblName.TabIndex = 1;
            lblName.Text = "ProductId";
            lblName.Click += lblName_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(79, 19);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(440, 53);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "Add | Update Product ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 193);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 6;
            label1.Text = "Price";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 261);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 7;
            label2.Text = "ManufactureDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 332);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 8;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 403);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 9;
            label4.Text = "Description";
            // 
            // button1
            // 
            button1.Location = new Point(828, 320);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 4;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 329);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(161, 400);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(284, 27);
            textBox3.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(161, 262);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 648);
            Controls.Add(button1);
            Controls.Add(grbSearch);
            Controls.Add(lblHeader);
            Controls.Add(btnSearch);
            Name = "ProductDetailForm";
            Text = "ProductDetailForm";
            Load += ProductDetailForm_Load;
            grbSearch.ResumeLayout(false);
            grbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbSearch;
        private TextBox txtDescription;
        private TextBox txtProductName;
        private Label lblDescription;
        private Label lblName;
        private Button btnSearch;
        private Label lblHeader;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}