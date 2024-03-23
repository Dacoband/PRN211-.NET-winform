namespace BookTRY1
{
    partial class LoginForm
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
            lblHeader = new Label();
            grbLoginForm = new GroupBox();
            txtEmailLogin = new TextBox();
            label2 = new Label();
            btnExit = new Button();
            btnLogin = new Button();
            grbLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(387, 82);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(169, 40);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Login User";
            // 
            // grbLoginForm
            // 
            grbLoginForm.Controls.Add(txtEmailLogin);
            grbLoginForm.Controls.Add(label2);
            grbLoginForm.Controls.Add(btnExit);
            grbLoginForm.Controls.Add(btnLogin);
            grbLoginForm.Location = new Point(225, 125);
            grbLoginForm.Name = "grbLoginForm";
            grbLoginForm.Size = new Size(509, 286);
            grbLoginForm.TabIndex = 1;
            grbLoginForm.TabStop = false;
            grbLoginForm.Text = "Login Form";
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailLogin.Location = new Point(93, 147);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(324, 31);
            txtEmailLogin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(220, 80);
            label2.Name = "label2";
            label2.Size = new Size(70, 31);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(323, 227);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(93, 227);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 504);
            Controls.Add(grbLoginForm);
            Controls.Add(lblHeader);
            Name = "LoginForm";
            Text = "LoginForm";
            grbLoginForm.ResumeLayout(false);
            grbLoginForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbLoginForm;
        private TextBox txtEmailLogin;
        private Label label2;
        private Button btnExit;
        private Button btnLogin;
    }
}