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
    }
}
