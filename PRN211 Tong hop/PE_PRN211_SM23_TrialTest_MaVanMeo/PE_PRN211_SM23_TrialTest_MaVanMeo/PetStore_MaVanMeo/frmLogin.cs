using PetStore_MaVanMeo_Repository.Repository;
namespace PetStore_MaVanMeo
{
    public partial class frmLogin : Form
    {
        private IShopMemberRepository _memberRepository;
        public frmLogin()
        {
            _memberRepository = new ShopMemberRepository();
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check xem null
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Ban phai nhap Email");
                txtEmail.Focus();
                return;
            }


            if (txtPass.Text == "")
            {
                MessageBox.Show("Ban phai nhap Mat khau");
                txtPass.Focus();
                return;
            }

            //goi xuong DB de check xem email va pass co ko?
            //check mat khau va user
            var member = _memberRepository.GetPetShopMembers()
                .FirstOrDefault(m => m.EmailAddress == txtEmail.Text && m.MemberPassword == txtPass.Text);
            if (member == null)
            {
                MessageBox.Show("Email or Pass invalid...");
                txtEmail.Focus();
                return;
            }
            else
            {
                if (member.MemberRole == 2)
                {
                    frmPetManagement frmPet = new();
                    frmPet.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You have no permission to access this function");
                }

            }
        }
    }
}