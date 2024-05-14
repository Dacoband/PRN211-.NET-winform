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

namespace ConvenienceStore_HuynhThienNhan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StoreAccountService service = new StoreAccountService();
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("You required to input both email or password", "Fill data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            StoreAccount acc = service.CheckLogin(txtEmail.Text, txtPassword.Text);
            if (acc == null)
            {
                MessageBox.Show("Login Failed, Check email or password again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (acc.Role != 1)
            {
                MessageBox.Show("You have no permission to access this function!", "Wrong Prvilege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProductManagementForm f = new();
            f.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to exit app", "Exit App!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
                Application.Exit();
        }
    }
}
