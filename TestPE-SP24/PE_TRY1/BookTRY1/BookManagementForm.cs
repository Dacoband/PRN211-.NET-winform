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
            dgvBookList.DataSource = null; //xoá tr?ng grid
            dgvBookList.DataSource = _bookService.GetAllBook();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Ki?m tra h?p l? cho giá sách
            double searchPrice;
            if (!double.TryParse(txtBookPrice.Text, out searchPrice))
            {
                MessageBox.Show("Please enter a valid price.");
                return; // D?ng th?c hi?n ph??ng th?c n?u giá không h?p l?
            }

            // L?y danh sách sách t? d?ch v? và th?c hi?n tìm ki?m
            var books = new BookService().GetAllBook();
            dgvBookList.DataSource = null;

            // Tìm ki?m sách d?a trên ph?n c?a tên sách ch?a trong txtBookName
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
