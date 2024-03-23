using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookCategoryRepository
    {
        private BookManagementDbContext _context = new BookManagementDbContext();
        //ta không cần làm hàm xóa sửa thêm vì ta chỉ cần lấy tất cả Category 
        public List<BookCategory> GetBookCategories()
        {
            _context = new();
            return _context.BookCategories.ToList();
        }

    }

    
}
