﻿using Repositories.Entities;
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

namespace BookManagement_HoangNgocTrinh
{
    public partial class BookDetailForm : Form
    {
        //vì DetailForm cx là 1 class, nên nó có prop như bt. Hơn bt là nó là class có thể render (Bố/Cha clas Form của SDK lo phần render - mối quan hệ kế thừa 

        //public int     Yob { get; set; } = 2003;
        //               .Yob = ???
        public Book SelectedBook { get; set; } = null;
        //mặc định form này mở lên, ko có book nào cả
        //nếu mún có book thì phải
        //.SelectedBook = cuốn muốn gán vào!!!


        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //MỞ MÀN HÌNH DETAIL THÌ TA SẼ:
            //1. FILL ĐẦY CATEGORY DROPDOWN - LẤY DATA TỪ TABLE CATEGORY
            //2. NẾU LÀ EDIT 1 CUỐN SÁCH THÌ FILL DATA CỦA CUỐN SÁCH MÚN
            //   EDIT VÀO CÁC Ô TƯƠNG ỨNG
            //3. NẾU LÀ TẠO MỚI CUỐN SÁCH, THÌ CỨ ĐỂ MÀN HÌNH TRỐNG CHỜ USER NHẬP INFO - KO CẦN LÀM GÌ THÊM

            BookCategoryService cat = new BookCategoryService();

            //đổ full data vào cbo
            cboBookCategoryId.DataSource = cat.GetAllCategories(); //hàm số II

            //chọn cột để hiển thị trên cbo
            cboBookCategoryId.DisplayMember = "BookGenreType";

            //chọn cột để lấy value thực sự cần dùng - what you see is not what you get
            //Chọn Self Help dễ cho user -> code map sang value 5 của cột BookCategoryId, dùng làm FK đẩy vào table BOOK
            cboBookCategoryId.ValueMember = "BookCategoryId";

            //vi diệu
            //nhảy đến giá trị bất kì nào mình thích trong cbo
            //mặc định là đầu danh sách xổ 1 
            //cboBookCategoryId.SelectedValue = 5; //default với mình là sách Self Help  

            //CHECK HÀNG, CÓ PHẢI LÀ EDIT HAY KO
            //CHECK BIẾN SELECTEDBOOK COI CÓ ĐC SET KHÁC NULL KO
            //NẾU CÓ SÁCH THÌ FILL VÀO CÁC Ô
            if (SelectedBook != null)
            {
                lblHeader.Text = "Update selected book";
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookId.Enabled = false; //Không cho edit cột BookID trong mode edit
                txtBookName.Text = SelectedBook.BookName;
                txtBookName.Enabled = false;
                txtDescription.Text = SelectedBook.Description;
                txtDescription.Enabled = false;
                dtpPublicationDate.Value = SelectedBook.PublicationDate;
                txtAuthor.Text = SelectedBook.Author.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                //
                cboBookCategoryId.SelectedValue = SelectedBook.BookCategoryId;  //1 2 3 4 5

                //tuỳ sách có cate gì thì jump đến số đó!!!

            }
            else
                lblHeader.Text = "Create a new book";


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboBookCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //nút save ứng với 2 tình huống, new mới sách edit sách
            //New trong ram, new cuốn cũ hoặc new cuốn mới, rồi đem gửi xuống service 
            Book b = new Book()
            {
                BookId = int.Parse(txtBookId.Text),
                BookName = txtBookName.Text,
                Description = txtDescription.Text,
                Author = txtAuthor.Text,
                Price = double.Parse(txtPrice.Text),
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                BookCategoryId = int.Parse(cboBookCategoryId.SelectedValue.ToString()) //Do Combo box nên phải to string 
            };

            BookService service = new();
            //Kiểm tra xem màn hình đang đâu mode nào , New hay Mode Eidt
            if (SelectedBook != null)
                service.UpdateABook(b);
            else service.AddABook(b);

            //đóng form lại và f5 bên grid
            this.Close();
        }
    }
}
