using BookStore_Repository.Entities;
using Services;

namespace BookStore_QuangSE171655
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;//TODO: kiem tra rong
            string password = txtPassword.Text;//TODO: kiem tra rong
            BookManagementMemberService se = new BookManagementMemberService();

            BookManagementMember account = se.CheckLogin(email, password);
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
            if (account.MemberRole != 1)
            {
                MessageBox.Show("You are not allowed to this function!"
                     , "Access denied"
                     , MessageBoxButtons.OK
                     , MessageBoxIcon.Error);
                return;
            }
            //ngon,role admin roi thi mo form login
            BookManagerForm bookMgt = new BookManagerForm();
            bookMgt.Show();
            this.Hide();
        }
    }
}