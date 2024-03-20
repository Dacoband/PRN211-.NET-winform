using Repositories.Entities;
using Services;

namespace BookManagement_HuynhThienNhan
{

    public partial class BookManagerMainUI : Form
    {
        //Backing Field _ 
        private Book _selected = null;// Chờ ai đó nhắn chọn 1 dòng trong grid/ table 
        //thì nó được gán = cuốn sách đang chọn 
        //đẩy cuốn sách được chọn sang màn hình 

        // vf detail form cũng là class nên nó prop như thường, khác là class có thể render 
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
            //gọi màn hình Detail lên. Màn hình này bản chất là một class BookDetailForm, khác truyền thống nó có phần render bề mặt 
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog();
        }

        private void dgvBookList_SelectionChanged_1(object sender, EventArgs e)
        {
            //người dùng có thể chọn 1 dòng hay nhìu dòng - chìm chuột , cho nên ta sẽ lấy dòng đầu tiên được chọn nếu ngườin ta chọnnhiuf dòng 
            if (dgvBookList.SelectedRows.Count > 0)
            {
                // nếu chọn ít nhất 1 dòng thì cứ lấy dòng đầu tiên được chọn , đẩy sang màn hình detail 
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;// lấy 1 dòng chính là 1 kiểu object tổng quát , nhưng bản thân là book lúc đầu .DataSource = List<Book> của hàm GetAllBooks()

                //đẩy sang màn Form Detail 
                //Khai biến, new , gán prop ,show dialog 
                //thằng form detail : mở lên check selected khác null hok ?? khác null mode Edit ,Show dagta được gửi sang 
                BookDetailForm f = new BookDetailForm();
                //đưa sách sang 
                f.SelectedBook = _selected;
                f.ShowDialog();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
