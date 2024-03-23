using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookService
    {
        private BookRepository _repo = new();
        public List<Book> GetAllBook()
        {
           return _repo.GetBook();
        }
        public void AddABook(Book book)
        {
            _repo.CreateBook(book);
        }
        public void DeleteABook(Book book)
        {
            _repo.DeleteBook(book);
        }
        public void UpdateABook(Book book)
        {
            _repo.UpdateBook(book);
        }
    }
}
