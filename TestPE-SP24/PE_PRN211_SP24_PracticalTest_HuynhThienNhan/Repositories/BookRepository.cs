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

        /// <summary>
        /// Hàm này tạo mới 1 cuốn sách, insert xuống DB qua gọi hành động
        /// của DbContext và đang đc chống lưng bởi Entity Framework
        /// Đầu vào cần là new Book(...) mới tinh nào đó
        /// </summary>
        /// <param name="book"></param>
        public void Create(Book book) //Hàm này để tạo 1 quyển sách mới 
        {
            _context = new();
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        /// <summary>
        /// Hàm này sẽ cập nhật 1 cuốn sách đang có, với thông tin bên trong 
        /// cuốn sách đc điều chỉnh: giá mới, năm xb mới, tên gõ đúng chính tả...
        /// Vẫn cần đưa vào 1 cuốn sách, và phải gọi DbContext
        /// </summary>
        /// <param name="book"></param>
        public void Update(Book book)
        {
            _context = new();
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        /// <summary>
        /// Hàm này xoá 1 cuốn sách theo Id. TA CẦN WHERE THEO ID
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            _context = new();
            var book = _context.Books.FirstOrDefault(b => b.BookId == id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
