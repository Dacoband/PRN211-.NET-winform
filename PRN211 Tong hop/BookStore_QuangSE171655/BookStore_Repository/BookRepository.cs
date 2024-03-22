using BookStore_Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    /// <summary>
    /// day la class chiu trach nhioem tuong tac truc tiep voi csdl
    /// trong day de lam CRUD sach
    /// </summary>
    public class BookRepository
    {
        /// <summary>
        /// ham nhan vao cuong sang la so nguye
        /// tra ve duy nhat 1 cuon sach -new Book()
        /// phai nho toi db context
        /// neu ma sach sai, ko co sach de return thi return null
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        private BookManagement2023DbContext _context;
        public Book ?Get(int bookId)
        {
            _context = new BookManagement2023DbContext();
            return _context.Books.Find(bookId);
        }
        public List<Book> GetAll () {
            _context = new BookManagement2023DbContext();
            //return _context.Books.ToList(); viet kieu nay chi load dc 1 bang book ko load 
            // duoc cua bang category
            return _context.Books.Include(cat =>cat.BookCategory).ToList();

        }
        
        public void Create(Book book) {
            _context = new BookManagement2023DbContext();
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public void Update(Book book) {
            _context = new BookManagement2023DbContext();
            _context.Books.Update(book);
            _context.SaveChanges(); 
        }
        public void Delete(int id)
        {
            _context = new BookManagement2023DbContext();
            var book = _context.Books.FirstOrDefault(b => b.BookId == id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
         
        }
       // public List<Book> Search(string keyword) { }
       // ko nen xai chuc nang search o day ma nen de o service
       // do nhu cau search khac nhau
       // repo chi nen lam CRUD
    }
}
