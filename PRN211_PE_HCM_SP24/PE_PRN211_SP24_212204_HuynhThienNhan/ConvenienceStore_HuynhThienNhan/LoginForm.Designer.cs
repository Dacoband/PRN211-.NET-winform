namespace ConvenienceStore_HuynhThienNhan
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
            btnQuit = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            grbLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(339, 43);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(222, 53);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Login User";
            // 
            // grbLoginForm
            // 
            grbLoginForm.Controls.Add(btnQuit);
            grbLoginForm.Controls.Add(btnLogin);
            grbLoginForm.Controls.Add(txtPassword);
            grbLoginForm.Controls.Add(txtEmail);
            grbLoginForm.Controls.Add(lblPassword);
            grbLoginForm.Controls.Add(lblEmail);
            grbLoginForm.Location = new Point(177, 99);
            grbLoginForm.Name = "grbLoginForm";
            grbLoginForm.Size = new Size(570, 331);
            grbLoginForm.TabIndex = 1;
            grbLoginForm.TabStop = false;
            grbLoginForm.Text = "Login Form";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(310, 272);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(180, 29);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(86, 272);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(177, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(338, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 71);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 27);
            txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(56, 153);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(56, 74);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 505);
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
        private Button btnQuit;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
    }
}