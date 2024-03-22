using BussinessObject;
using Repository;

namespace LoginTatto
{
    public partial class frmLogin : Form
    {
        IRepository repository = new Repositoryy();


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                AccountMember loginmember = repository.checkLogin(email, password);
                if (loginmember != null)
                {
                    ShowTattoo showTattoo = new ShowTattoo();
                    showTattoo.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("incorrect!");

                }

            }
            catch (Exception ex)
            {



            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                AccountMember loginmember = repository.checkLogin(email, password);
                if (loginmember != null)
                {
                    ShowTattoo showTattoo = new ShowTattoo();
                    showTattoo.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("incorrect!");

                }

            }
            catch (Exception ex)
            {



            }
        }

    }
}
