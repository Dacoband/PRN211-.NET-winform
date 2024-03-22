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
        //Các hàm CRUD của table Member/Account
        //ham tra ve 1 account nao do theo username/email
        public UserAccount Get(string email)
        {
            //db dang moc vao csdl co san 3 table, list cac data
            BookManagementDbContext db = new BookManagementDbContext();
            return db.UserAccounts.FirstOrDefault(x => x.Email == email);
        }
    }
}
