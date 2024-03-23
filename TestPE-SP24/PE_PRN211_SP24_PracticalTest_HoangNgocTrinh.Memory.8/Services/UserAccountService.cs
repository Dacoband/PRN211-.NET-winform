using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountService
    {
        private UserAccountRepository _repo = new();

        //CLass này đc login form gọi để gửi user để hỏi xem user này ổng không 
        public UserAccount? CheckLogin(string email, string password)
        {
            return _repo.GetUserAccount(email, password);
        }
    }
}
