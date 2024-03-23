using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        private BookManagementDbContext _context = new();

        //Hàm này khác truyền thống là chỉ trả về 1 account , 1 row thay vì trả về all 
        //Ta trả về cái dòng mà có email == email gõ vào 
        public  UserAccount? GetUserAccount(string email,  string password)
        {
            _context = new();
            return _context.UserAccounts.FirstOrDefault(x => x.Email == email && x.Password == password);
        }// ? có thể trả về null khi user hoặc pass 
    }
}
