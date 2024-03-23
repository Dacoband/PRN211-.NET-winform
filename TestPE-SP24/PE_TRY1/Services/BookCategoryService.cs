using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        public List<BookCategory> GetAllCategories()
        {
            BookCategoryRepository _repo = new BookCategoryRepository();
            return _repo.GetBookCategories();

        }
    }
}
