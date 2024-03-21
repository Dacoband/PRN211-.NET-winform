namespace BookManagement_HuynhThienNhan
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
            grbLoginForm = new GroupBox();
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblHeaderLogin = new Label();
            grbLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // grbLoginForm
            // 
            grbLoginForm.BackgroundImageLayout = ImageLayout.None;
            grbLoginForm.Controls.Add(btnLogin);
            grbLoginForm.Controls.Add(txtPassword);
            grbLoginForm.Controls.Add(txtEmail);
            grbLoginForm.Controls.Add(lblPassword);
            grbLoginForm.Controls.Add(lblEmail);
            grbLoginForm.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            grbLoginForm.Location = new Point(155, 146);
            grbLoginForm.Name = "grbLoginForm";
            grbLoginForm.Size = new Size(534, 408);
            grbLoginForm.TabIndex = 0;
            grbLoginForm.TabStop = false;
            grbLoginForm.Text = "LoginForm";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(34, 91);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(68, 28);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(34, 198);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 28);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(34, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(384, 34);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(34, 249);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(384, 34);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(198, 327);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblHeaderLogin
            // 
            lblHeaderLogin.AutoSize = true;
            lblHeaderLogin.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderLogin.Location = new Point(253, 52);
            lblHeaderLogin.Name = "lblHeaderLogin";
            lblHeaderLogin.Size = new Size(320, 46);
            lblHeaderLogin.TabIndex = 1;
            lblHeaderLogin.Text = "Book Management";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 699);
            Controls.Add(lblHeaderLogin);
            Controls.Add(grbLoginForm);
            Name = "LoginForm";
            Text = "LoginForm";
            grbLoginForm.ResumeLayout(false);
            grbLoginForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbLoginForm;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblHeaderLogin;
    }
}