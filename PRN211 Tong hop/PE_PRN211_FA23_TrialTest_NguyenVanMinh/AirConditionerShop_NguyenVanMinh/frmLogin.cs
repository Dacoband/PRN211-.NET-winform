using Repositories;

namespace AirConditionerShop_NguyenVanMinh
{
    public partial class frmLogin : Form
    {
        IStaffMemberRepository _staffMemberRepository = new StaffMemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var tmp = _staffMemberRepository.CheckLogin(txtUsername.Text, txtPassword.Text);
            if (tmp != null && tmp.Role == 1)
            {
                frmAirConditionerManagement f = new frmAirConditionerManagement();
                f.ShowDialog(); this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }
    }
}