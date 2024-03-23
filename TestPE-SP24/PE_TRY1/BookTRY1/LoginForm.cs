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

namespace BookTRY1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BookManagementMemberService service = new BookManagementMemberService();
            //Kiểm tra rỗng hay ko 
            if (string.IsNullOrEmpty(txtEmailLogin.Text))
            {
                MessageBox.Show("You required to input both email", "Fill data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            BookManagementMember acc = service.CheckLogin(txtEmailLogin.Text);
            if (acc == null)
            {
                MessageBox.Show("Login Failed, Check email again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
            if (acc.MemberRole != 1)
            {
                MessageBox.Show("You have no permission to access this function!", "Wrong Prvilege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BookManagementForm f = new();
            f.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to exit app", "Exit App!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
                    Application.Exit();
        }
    }
}
