using BookStore_Repository.Entities;
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

namespace BookStore_QuangSE171655
{
    public partial class BookManagerForm : Form
    {
        private BookService _bookService = new BookService();
        private BookCategoryService _categoryService = new BookCategoryService();
        public BookManagerForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookManagerForm_Load(object sender, EventArgs e)
        {
            //load danh sach vào grid
            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;//xóa lưới cũ lấy lưới mới
            dgvBookList.DataSource = result;
            //giau cot category
            dgvBookList.Columns["BookCategory"].Visible = false;
            //do toan bo category vao combobox
            cbCategory.DataSource = _categoryService.GetAllCategories();
            //giau cot ko can chi show generetype
            cbCategory.DisplayMember = "BookGenreType";
            cbCategory.ValueMember = "BookCategoryId";
            //nghia la lay categoryID
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selectedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                //co trong tay 1 object cua 1 cuon sach duoc chon roi
                //cham tung field do vao form
                txtID.Text = selectedBook.BookId.ToString();
                txtName.Text = selectedBook.BookName;
                txtDescription.Text = selectedBook.Description;
                dtpReleaseDay.Value = selectedBook.ReleaseDate;
                txtQuantity.Text = selectedBook.Quantity.ToString();
                txtPrice.Text = selectedBook.Price.ToString();
                cbCategory.SelectedValue = selectedBook.BookCategoryId;
                txtAuthor.Text = selectedBook.Author;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
