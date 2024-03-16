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
        public List<Book> GetAllBooks()
        {
            //TODO: Gọi class BookRepository để lấy toàn bộ sách từ DB
            //Call class BookRepository to retrieve all books from DB
            List<Book> arr = new List<Book>();

            //using object initialization
            arr.Add(new Book()
            {
                BookId = 1,
                BookName = "Đời Ngắn Đừng Ngủ Dài-Short Life Don’t Sleep Long",
                Author = "Robin Sharma",
                PublicationDate = "2023-01-01",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 2,
                BookName = "Mình Là Nắng, Việc Của Mình Là Chói Chang-I Am the Sun, My Job Is to Shine Bright",
                Author = "Kazuko Watanabe",
                PublicationDate = "2023-01-01",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 3,
                BookName = "Tuổi Trẻ Đáng Giá Bao Nhiêu-How Much Is Youth Worth",
                Author = "Rosie Nguyễn",
                PublicationDate = "2018-01-01",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 4,
                BookName = "Snow Crash",
                Description = "Hiro lives in a Los Angeles where franchises line the freeway...",
                Author = "Neal Stephenson",
                PublicationDate = "2001-01-01",
                BookCategoryId = 2
            });

            return arr;
        }
    }
}
