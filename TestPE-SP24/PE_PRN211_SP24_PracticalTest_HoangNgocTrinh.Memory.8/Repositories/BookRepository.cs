using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    //Class này chơi trực tiếp với database hặc SQL qua DbContext 
    //Và class này sẽ bị gọi bởi class BookService
    //          UI -------------BookService ---------------- DbContext ---------------Table 
    //Trong UI phải khai báo Service 
    public class BookRepository
    {
        private BookManagementDbContext _context;
        public List<Book> GetBooks()
        {
            _context = new();
            return _context.Books.ToList();
        }

        //Book Repo cung cấp các hàm CRUD trừcj tiếp với Database qua việc gouij DbContext
        //Mỗi lần xài là phải new 
        //toàn bộ là OOP, Đău obj gọi hàm tươngf ựng là tự biết insert hay UPDATE or DELETE 
        public void CreateBook(Book book)
        {
            _context =new();
            _context.Books.Add(book);
            _context.SaveChanges();
        } //Check trùng key : ChatGPT -> How to handle duplicate of primary key in C# using EF core when inserting a new book in Book Management app 
        public void UpdateBook(Book book)
        {
            _context =new();
            _context.Books.Update(book);
            _context.SaveChanges();
        }
        public void DeleteBook(Book book)
        {
            _context =new();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }


    }
}
