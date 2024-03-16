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
        //book x = cuốn sách bên grid đem sang 
        //          == obj Book bên kia - form chính 
        public Book SelectedBook { get; set; } = null;
        //Nếu của sổ này được gọi từ nút Create Book bên kia thì SelectedBook = null - CHẾ ĐỘ APP 

        //Nếu ở chế độ EDIT - nghĩa là bên màn hình kìa phải set biến selected_book = Book đang chọn rồi mới show màn hình 
        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //khi form này đc mở lên , thì làm đc 
            //1. đổ vào trong cái combobox cái danh sách Category do CategorySẻvice nắm giữ từ DB 

            //2. Nếu Form này ứng với màn hình tạo mới cuốn sách, thì không cần làm gì thêm lúc này !!!
            //3. Nếu form là edit cuốn sách thì ta phải show cuốn sách được lựa chọn từ bên màn hình BookManager 
            // Challenge: Làm sao để bắt cuốn sách bên kia ném sang bên này. 
            // 1. đổ dta vào ComboBox 
            BookCategoryService cat = new BookCategoryService();
            //chính là Cabinet chứa nhiều Category
            //đưa toàn bộ data cho Category 
            cbxBookCategory.DataSource = cat.GetAllCategories();

            //SHow cột nào thì chọn tên cột đó
            cbxBookCategory.DisplayMember = "BookGenreType";
            //Khi user chọn 1 dòng xổ ra, thì ta cần lấy Value gì 
            //Để dùng sau này, thường ta sẽ lấy cột id của data source 
            //Show 1 cột, lấy value cột khác mà xài (Dùng làm FK )
            cbxBookCategory.ValueMember = "BookCategoryId";

            //mặc định Jump nhảy tới value nào trong dãy xổ ra 
            //cbxBookCategory.SelectedValue = 5; // mặc định cách tạo là thuộc về loaji kĩ năng mềm 
            
            //Check hàng nếu selected book đc gán Value thì là mode edit òi
            //Show data vào các ô nhập để bà con edit 
            if(SelectedBook != null)
            {
                txtBookID.Text = SelectedBook.BookId.ToString();
                txtBookName.Text = SelectedBook.BookName;
                txtBookDescription.Text = SelectedBook.Description;
                // làm các nút còn lại 


                // Vi diệu nhất , nhảy đén các loại sách mà sach đang thuộc về 
                cbxBookCategory.SelectedValue = SelectedBook.BookCategoryId;
            }

        }
    }
}
