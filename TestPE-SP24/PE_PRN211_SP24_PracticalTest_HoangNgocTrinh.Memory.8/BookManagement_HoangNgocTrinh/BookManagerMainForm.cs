using Repositories.Entities;
using Services;

namespace BookManagement_HoangNgocTrinh
{
    public partial class BookManagerMainForm : Form
    {
        //backing field _

        private Book _selected = null; //chờ ai đó nhấn chọn 1 dòng trong grid/table
                                       //thì nó đc gán = cuốn sách đang chọn 
                                       //đẩy cuốn sách đc chọn sang màn hình update
        private BookService _bookService = new BookService();
        public BookManagerMainForm()
        {
            InitializeComponent();
        }

        //Làm hàm tiện ích, helper để đi fill data vào trong grid, được dùng sau mỗi chức năng CRUD book
        private void FillDataGridView()
        {
            dgvBookList.DataSource = null; //xoá trắng grid
            dgvBookList.DataSource = _bookService.GetAllBooks();
        }

        public void BookManagerMainForm_Load(object sender, EventArgs e)
        {

            FillDataGridView();// để fill lại grid 

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //gọi màn hình Detail lên. Màn hình này bản chất là class BookDetailFrom, khác truyền thống là nó có phần render bề mặt!!!
            //Nó 1 class nên nó sẽ có _field, prop, methods như bt
            //khai báo biến, new như bt
            //thêm phần render
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog(); //render đi em 
            //f.Show(); //nguy hiểm nhen, vì cứ new là có object, cửa sổ mới!!!
            //F5 laji grid
            FillDataGridView();

        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //người dùng có thể chọn 1 dòng hay nhiều dòng - chìm chuột, cho nên ta sẽ lấy dòng đầu tiên đc chọn nếu người ta chọn nhiều dòng
            if (dgvBookList.SelectedRows.Count > 0)
            {
                //nếu chọn ít nhất 1 dòng, thì cứ dòng đầu tiên đc chọn là bốc nó ra, đẩy sang màn hình detail
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;  //lấy 1 dòng chính là kiểu object tổng quát, nhưng bản chất là Book do lúc đầu .DataSource = List<Book> của hàm GetAllBooks()
            }
            //TODO: nếu user chọn Cell thay vì chọn nguyên dòng, reset biế _selected về null

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //đẩy sang Form Detail
            //khai biến, new, gán prop, show dialog
            //thằng form detail: mở lên, check selected khác null hem? khác null mode EDIT, SHOW DATA ĐC GỬI SANG

            if (_selected != null) //người dùng phải chọn 1 dòng trong grid
            {
                BookDetailForm f = new BookDetailForm();

                //đưa sách sang
                f.SelectedBook = _selected;
                f.ShowDialog();
            }
            else
                MessageBox.Show("Please select a certain book to edit!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //F5 lai grid
            FillDataGridView();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ta sẽ lấy ra 2 chuỗi đang nằm trong txtBookName & txtDescription
            //và ta where trên cái danh sách books đang có

            var books = new BookService().GetAllBooks();
            dgvBookList.DataSource = null;
            //dgvBookList.DataSource = books.Where(x => false).ToList(); //ko trả về cuốn nào
            //dgvBookList.DataSource = books.Where(x => true).ToList(); //đưa cuốn nào cx đồng ý hết trơn

            //dgvBookList.DataSource = books.Where(
            //    delegate (Book x)
            //    {
            //        return x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || x.Description.ToLower().Contains(txtDescription.Text.ToLower());
            //    }
            //).ToList();

            dgvBookList.DataSource = books.Where(x => x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || x.Description.ToLower().Contains(txtDescription.Text.ToLower())).ToList();


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected != null) //người dùng phải chọn 1 dòng trong grid
            {
                //Trước khi xóa thì mình phải hỏi có muốn xoá không 
                DialogResult answer = MessageBox.Show("Do you want to delete book?", "Delete Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.No)
                {
                    return;
                }
                // User chọn 1 cuốn, thay vì gửi edit thì mình xóa 
                _bookService.DeleteABook(_selected);
                FillDataGridView();
                _selected = null;//Vì đề phòng edit 1 cuốn đã bị xóa 
            }
            else
                MessageBox.Show("Please select a certain book to delete!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
