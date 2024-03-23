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

namespace BookTRY1
{
    public partial class BookManagementForm : Form
    {
        private Book _selected = null;
        private BookService _bookService = new BookService();

        public BookManagementForm()
        {
            InitializeComponent();
        }
        private void FillDataGridView()
        {
            dgvBookList.DataSource = null; //xo� tr?ng grid
            dgvBookList.DataSource = _bookService.GetAllBook();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Ki?m tra h?p l? cho gi� s�ch
            double searchPrice;
            if (!double.TryParse(txtBookPrice.Text, out searchPrice))
            {
                MessageBox.Show("Please enter a valid price.");
                return; // D?ng th?c hi?n ph??ng th?c n?u gi� kh�ng h?p l?
            }

            // L?y danh s�ch s�ch t? d?ch v? v� th?c hi?n t�m ki?m
            var books = new BookService().GetAllBook();
            dgvBookList.DataSource = null;

            // T�m ki?m s�ch d?a tr�n ph?n c?a t�n s�ch ch?a trong txtBookName
            dgvBookList.DataSource = books.Where(x => x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) && x.Price == searchPrice).ToList();
        }
        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {

                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
            }
        }
    }
}
