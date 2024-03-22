using Repositories;
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
           string email = txtEmail.Text;//TODO: kiem tra rong
            string password = txtPassword.Text;//TODO: kiem tra rong
            BookManagementMemberService bms = new BookManagementMemberService();

            UserAccount account = bms.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login failed! Please check your credentials"
                    , "Wrong credentials"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }
            //not null roi cho vao form quan li sach
            //check xem neu de cho role sao thi cho role do
            if (account.Role != 1)
            {
                MessageBox.Show("You are not allowed to this function!"
                     , "Access denied"
                     , MessageBoxButtons.OK
                     , MessageBoxIcon.Error);
                return;
            }
            //ngon,role admin roi thi mo form login
            BookManagerMainForm bookMgt = new BookManagerMainForm();
            bookMgt.Show();
            this.Hide();
        }
    }
}
