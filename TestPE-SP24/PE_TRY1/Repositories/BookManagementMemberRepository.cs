using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookManagementMemberRepository
    {
        private BookManagementTryContext _context = new BookManagementTryContext();
        public BookManagementMember? GetMember(string email)
        {
            _context = new();
            return _context.BookManagementMembers.FirstOrDefault(x => x.Email == email);
        }// ? có thể trả về null khi user hoặc pass  
    }
}
