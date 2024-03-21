using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {
        private BookManagementDbContext _context;
        public List<Book> GetBooks()
        {
            _context = new();
            return _context.Books.ToList();
        }
        public List<BookCategory> GetBookCategories()
        {
            _context = new();
            return _context.BookCategories.ToList();
        }
    }
}
