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
        public void AddBook(Book book)
        {
            _repo.Create(book);
        }
        public void UpdateBook(Book book)
        {
            _repo.Update(book);
        }
        public void DeleteBook(int id)
        {
            _repo.Delete(id);
        }
        
    }
}
