using Repositories;
using Repositories.Entities;

namespace Services
{
    //3-layer Architecture:
    // [1]            [2]                [3]                          SQLSERVER        
    //UI-Forms  ---- Services  ------- Repositories -----------------    DB
    //MainUI    ---- BookService       BookRepository (Book Entity)    Book Table
    //  request/response         <----->      
    //  đưa data xuống DB                chơi trực tiếp DB: lên, xuống
    //  lấy data từ DB show                                 CRUD table thực sự
    //            RAM                             DB ĐĨA CỨNG HDD/SSD 
    public class BookService
    {
        //gọi repo để lấy data từ DB thực sự 
        //làm ẩu thì có thể gọi trực tiếp DbContext 
        
        private BookRepository _repo = new BookRepository();
        public List<Book> GetAllBooks()
        {
            return _repo.GetBooks();
        }

    }
}
