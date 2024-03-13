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
            dgvBookList.DataSource = service.GetAllBook();
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
            
        }
    }
}
