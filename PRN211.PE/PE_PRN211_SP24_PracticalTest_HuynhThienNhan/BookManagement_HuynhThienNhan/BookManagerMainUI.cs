using Repositories.Entities;
using Services;

namespace BookManagement_HuynhThienNhan
{
    public partial class BookManagerMainUI : Form
    {
        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ta gọi Service để đỗ data vào 
            BookService service = new BookService();

            dgvBookList.DataSource = null; // Xóa lưới về trắng trơn 
            dgvBookList.DataSource = service.GetAllBooks();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you really want to exist?", "Exist ?",
               MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();// hàm cung cấp bởi SDK tắt 1 cái app 
            }
        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Gọi form BookDetail trắng trơn showw ra chờ user input Book info 
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog();
        }

        private void dgvBookList_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                Book selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;

                BookDetailForm f = new BookDetailForm();
                f.SelectedBook = selected;
                f.ShowDialog();
            }
        }
    }
}
