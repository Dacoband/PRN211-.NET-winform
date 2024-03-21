using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_HuynhThienNhan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text; 

            BookManagementDbContext db = new BookManagementDbContext();
            bool isValidUser = db.CheckUserAccount(email, password);
            if (isValidUser)
            {
                int userRole = db.GetUserRole(email);
                if (userRole == 1)
                {
                    BookManagerMainForm form = new BookManagerMainForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You have no permission to access this function.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
