using BussinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repositoryy : IRepository
    {
        public AccountMember checkLogin(string email, string password)
       =>DAO.Instance.checkLogin(email, password);
    }
}
