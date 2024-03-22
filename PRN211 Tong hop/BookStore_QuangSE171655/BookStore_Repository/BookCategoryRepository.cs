using BookStore_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    //class nay de CRUD the looai sach
    public class BookCategoryRepository
    {
        private BookManagement2023DbContext _context;
        public List<BookCategory> GetAll()
        {
       
        return new BookManagement2023DbContext().BookCategories.ToList();

        }

    }
}
