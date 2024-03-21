using Repositories;
using Repositories.Entities;

namespace Services
{

    public class BookService
    {
        private BookRepository _repo = new BookRepository();

        public List<Book> GetAllBooks()
        {
            return _repo.GetBooks();
        }
        public List<BookCategory> GetBookCategories()
        {
            return _repo.GetBookCategories();
        }
    }
}
