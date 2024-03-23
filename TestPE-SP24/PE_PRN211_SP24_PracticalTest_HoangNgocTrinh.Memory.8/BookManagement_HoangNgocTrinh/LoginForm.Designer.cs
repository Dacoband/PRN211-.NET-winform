namespace BookManagement_HoangNgocTrinh
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
            grbLoginInfo = new GroupBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            btnExit = new Button();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            lblHeader = new Label();
            grbLoginInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grbLoginInfo
            // 
            grbLoginInfo.BackColor = SystemColors.WindowFrame;
            grbLoginInfo.Controls.Add(btnLogin);
            grbLoginInfo.Controls.Add(txtPassword);
            grbLoginInfo.Controls.Add(btnExit);
            grbLoginInfo.Controls.Add(txtEmail);
            grbLoginInfo.Controls.Add(lblPassword);
            grbLoginInfo.Controls.Add(lblEmail);
            grbLoginInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbLoginInfo.ForeColor = Color.Yellow;
            grbLoginInfo.Location = new Point(263, 188);
            grbLoginInfo.Name = "grbLoginInfo";
            grbLoginInfo.Size = new Size(498, 330);
            grbLoginInfo.TabIndex = 1;
            grbLoginInfo.TabStop = false;
            grbLoginInfo.Text = " Login Info";
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(26, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(205, 107);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '#';
            txtPassword.Size = new Size(257, 34);
            txtPassword.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(262, 253);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 42);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(205, 43);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 31);
            txtEmail.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Red;
            lblPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Yellow;
            lblPassword.Location = new Point(43, 114);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 31);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Red;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Yellow;
            lblEmail.Location = new Point(43, 50);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(73, 31);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Red;
            lblHeader.Font = new Font("Segoe UI", 39F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(401, 57);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(207, 87);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1013, 577);
            Controls.Add(grbLoginInfo);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            grbLoginInfo.ResumeLayout(false);
            grbLoginInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbLoginInfo;
        private Button btnLogin;
        private TextBox txtPassword;
        private Button btnExit;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblHeader;
    }
}