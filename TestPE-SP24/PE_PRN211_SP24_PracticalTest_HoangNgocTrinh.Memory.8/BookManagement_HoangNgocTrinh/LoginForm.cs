using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_HoangNgocTrinh
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserAccountService service = new UserAccountService();
            //Kiểm tra rỗng hay ko 
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("You required to input both email or password", "Fill data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            UserAccount acc = service.CheckLogin(txtEmail.Text, txtPassword.Text);
            if (acc == null)
            {
                MessageBox.Show("Login Failed, Check email or password again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Khac null nhung co the dung role
            if (acc.Role != 1)
            {
                MessageBox.Show("You have no permission to access this function!", "Wrong Prvilege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BookManagerMainForm f = new();
            f.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
