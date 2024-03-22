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

namespace BookManagement_HuynhThienNhan
{
    public partial class BookDetailForm : Form
    {
        public BookDetailForm()
        {
            InitializeComponent();
        }
        public Book SelectedBook { get; set; } = null;
        private void grbSearchCertiral_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            BookCategoryService cat = new BookCategoryService();

            cboBookCategoryId.DataSource = cat.GetAllCategories();
            cboBookCategoryId.DisplayMember = "BookGenreType";
            cboBookCategoryId.ValueMember = "BookCategoryId";

            if (SelectedBook != null)
            {
                lblHeader.Text = "Update selected book";
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookId.Enabled = false;
                txtBookName.Text = SelectedBook.BookName;
                txtBookName.Enabled = false;
                txtDescription.Text = SelectedBook.Description;
                txtDescription.Enabled = false;
                dtpPublicationDate.Value = SelectedBook.PublicationDate;
                txtAuthor.Text = SelectedBook.Author.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                cboBookCategoryId.SelectedValue = SelectedBook.BookCategoryId;
            }
            else
                lblHeader.Text = "Create a new book";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
