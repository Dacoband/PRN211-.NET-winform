using Repositories.Entities;
using Services;

namespace BookManagement_HuynhThienNhan
{
    public partial class BookManagerMainForm : Form
    {
        public BookManagerMainForm()
        {
            InitializeComponent();
        }

        private void BookManagerMainForm_Load(object sender, EventArgs e)
        {
            BookService service = new BookService();

            // Lấy danh sách sách và danh sách thể loại sách
            var books = service.GetAllBooks();
            var categories = service.GetBookCategories();

            // Kết hợp thông tin từ hai danh sách vào một danh sách mới
            var combinedData = (from book in books
                                join category in categories on book.BookCategoryId equals category.BookCategoryId
                                select new
                                {
                                    BookId = book.BookId,
                                    BookName = book.BookName,
                                    Description = book.Description,
                                    PublicationDate = book.PublicationDate,
                                    Quantity = book.Quantity,
                                    Price = book.Price,
                                    Author = book.Author,
                                    BookCategoryId = book.BookCategoryId,
                                    BookGenreType = category.BookGenreType,
                                    GenreDescription = category.Description
                                }).ToList();

            // Gán danh sách đã kết hợp vào DataSource của DataGridView
            dgvBookList.DataSource = null; // Xóa dữ liệu cũ
            dgvBookList.DataSource = combinedData;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var books = new BookService().GetAllBooks();
            dgvBookList.DataSource = null;

            dgvBookList.DataSource = books.Where(x => x.BookName.ToLower().Contains(txtBookName.Text.ToLower())
                                           || x.Description.ToLower().Contains(txtDescription.Text.ToLower())).ToList();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to exit app ? ", "Quit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
