namespace Zodiac
{
    partial class textBoxMonth
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
            lblWelcome = new Label();
            lblDate = new Label();
            lblMonth = new Label();
            lblCopyright = new Label();
            lblZodiacSign = new Label();
            textBoxDay = new TextBox();
            textBox1 = new TextBox();
            btnQuit = new Button();
            btnCheckZodiac = new Button();
            btnShowImage = new Button();
            pic = new PictureBox();
            pnlImage = new Panel();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            pnlImage.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("SimSun", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.FromArgb(128, 255, 128);
            lblWelcome.Location = new Point(40, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(731, 80);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Zodiac Calculator";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("SimSun", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.FromArgb(128, 255, 128);
            lblDate.Location = new Point(40, 158);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(283, 37);
            lblDate.TabIndex = 1;
            lblDate.Text = "Your Birth Day";
            lblDate.Click += label1_Click;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("SimSun", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonth.ForeColor = Color.FromArgb(128, 255, 128);
            lblMonth.Location = new Point(40, 251);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(321, 37);
            lblMonth.TabIndex = 2;
            lblMonth.Text = "Your Birth Month";
            lblMonth.Click += label2_Click;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCopyright.ForeColor = Color.FromArgb(128, 255, 128);
            lblCopyright.Location = new Point(65, 601);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(183, 28);
            lblCopyright.TabIndex = 3;
            lblCopyright.Text = "©2024 Volka";
            // 
            // lblZodiacSign
            // 
            lblZodiacSign.AutoSize = true;
            lblZodiacSign.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblZodiacSign.ForeColor = Color.FromArgb(128, 255, 128);
            lblZodiacSign.Location = new Point(40, 458);
            lblZodiacSign.Name = "lblZodiacSign";
            lblZodiacSign.Size = new Size(278, 28);
            lblZodiacSign.TabIndex = 4;
            lblZodiacSign.Text = "Your Zodiac Sign is";
            // 
            // textBoxDay
            // 
            textBoxDay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDay.Location = new Point(379, 148);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(237, 47);
            textBoxDay.TabIndex = 5;
            textBoxDay.TextChanged += textBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(379, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 47);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.Violet;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuit.ForeColor = Color.Teal;
            btnQuit.Location = new Point(449, 329);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(133, 48);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += button1_Click;
            // 
            // btnCheckZodiac
            // 
            btnCheckZodiac.BackColor = Color.Violet;
            btnCheckZodiac.FlatStyle = FlatStyle.Flat;
            btnCheckZodiac.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheckZodiac.ForeColor = Color.Teal;
            btnCheckZodiac.Location = new Point(245, 329);
            btnCheckZodiac.Name = "btnCheckZodiac";
            btnCheckZodiac.Size = new Size(133, 48);
            btnCheckZodiac.TabIndex = 8;
            btnCheckZodiac.Text = "Check Zodiac";
            btnCheckZodiac.UseVisualStyleBackColor = false;
            btnCheckZodiac.Click += btnCheckZodiac_Click;
            // 
            // btnShowImage
            // 
            btnShowImage.BackColor = Color.Violet;
            btnShowImage.FlatStyle = FlatStyle.Flat;
            btnShowImage.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowImage.ForeColor = Color.Teal;
            btnShowImage.Location = new Point(40, 329);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(133, 48);
            btnShowImage.TabIndex = 9;
            btnShowImage.Text = "Show Image";
            btnShowImage.UseVisualStyleBackColor = false;
            btnShowImage.Click += button3_Click;
            // 
            // pic
            // 
            pic.BackColor = Color.Snow;
            pic.Location = new Point(54, 20);
            pic.Name = "pic";
            pic.Size = new Size(418, 384);
            pic.SizeMode = PictureBoxSizeMode.AutoSize;
            pic.TabIndex = 10;
            pic.TabStop = false;
            pic.Click += pic_Click;
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.BackColor = Color.DarkSalmon;
            pnlImage.Controls.Add(pic);
            pnlImage.Location = new Point(695, 148);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(511, 426);
            pnlImage.TabIndex = 11;
            // 
            // textBoxMonth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(1218, 653);
            Controls.Add(btnShowImage);
            Controls.Add(btnCheckZodiac);
            Controls.Add(btnQuit);
            Controls.Add(textBox1);
            Controls.Add(textBoxDay);
            Controls.Add(lblZodiacSign);
            Controls.Add(lblCopyright);
            Controls.Add(lblMonth);
            Controls.Add(lblDate);
            Controls.Add(lblWelcome);
            Controls.Add(pnlImage);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "textBoxMonth";
            Text = "Zodiac Calculator";
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblDate;
        private Label lblMonth;
        private Label lblCopyright;
        private Label lblZodiacSign;
        private TextBox textBoxDay;
        private TextBox textBox1;
        private Button btnQuit;
        private Button btnCheckZodiac;
        private Button btnShowImage;
        private PictureBox pic;
        private Panel pnlImage;
    }
}
