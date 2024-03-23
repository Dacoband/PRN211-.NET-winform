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
        private BookManagementTryContext _context = new BookManagementTryContext();
        public List<Book> GetBook()
        {
            _context = new();
            return _context.Books.ToList();
        }
        public void CreateBook(Book book)
        {
            _context = new();
            _context.Books.Add(book);
            _context.SaveChanges();
        } //Check trùng key : ChatGPT -> How to handle duplicate of primary key in C# using EF core when inserting a new book in Book Management app 
        public void UpdateBook(Book book)
        {
            _context = new();
            _context.Books.Update(book);
            _context.SaveChanges();
        }
        public void DeleteBook(Book book)
        {
            _context = new();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
