using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StoreAccountService
    {
        private StoreAccountRepository _repo = new();
        public StoreAccount? CheckLogin(string email, string password)
        {
            return _repo.GetUserAccount(email, password);
        }
    }
}
