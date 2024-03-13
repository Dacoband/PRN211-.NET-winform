using Repositories.Entities;

namespace Services
{
    // Mô hình 3 lớp 
    // GUI FORM ------ Services -------- Repository ------------ Database 
    //  [1] -----------[2] --------------[3]---------------------[4]
    // BookManagerMainUI  | BookService | BookRepository 
    //                                          Entities
    //                                              Book Class
    //                      CRUD METHODS        CRUD METHOD nhưng trực tiếp trong Databse
    //                          Trog Memory
    public class BookService
    {
        // Trong đây chứa hàm CRUD liên quan trong Table Book Nhưng trong Ram 
        //Hàm show ra tất cả quyển sách database 
        // ta tạm thời Hard-coded để test 
        public List<Book> GetAllBook()
        {
            List<Book> arr = new List<Book>();
            arr.Add(new Book() { BookId = 1, BookName = "Doi IT", Description = "Sach IT"});

            arr.Add(new Book() { BookId = 2, BookName = "Nha Gia Kim", Description = "Sach Cuoc Song" });

            arr.Add(new Book() { BookId = 3, BookName = "Bon Thoa Uoc", Description = "Sach Ki Nang" });

            return arr; // Cách làm chưa lấy từ database 
        }
    }
}
