using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StoreAccountRepository
    {
        private ConvenienceStoreDbContext _context = new ConvenienceStoreDbContext();
        public StoreAccount? GetUserAccount(string email, string password)
        {
            _context = new();
            return _context.StoreAccounts.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
    }
}
