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
using BookManagement_HuynhThienNhan;
namespace BookManagement_HuynhThienNhan
{
    public partial class BookManagerMainForm : Form
    {
        public BookManagerMainForm()
        {
            InitializeComponent();
        }
        private Book _selected = null;
        private BookService _bookService = new BookService();
        
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

            dgvBookList.DataSource = null;
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

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog();
        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
            }
            
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (_selected != null) //người dùng phải chọn 1 dòng trong grid
            {
                BookDetailForm f = new BookDetailForm();

                //đưa sách sang
                f.SelectedBook = _selected;
                f.ShowDialog();
            }
            else
                MessageBox.Show("Please select a certain book to edit!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
          
        }
    }
}
