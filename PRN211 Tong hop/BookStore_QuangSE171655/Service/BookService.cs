using BookStore_Repository.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookService
    {
        private BookRepository _repo =new BookRepository();
        public List<Book> GetAllBooks()
        {
           return _repo.GetAll();

        }

    }
}
