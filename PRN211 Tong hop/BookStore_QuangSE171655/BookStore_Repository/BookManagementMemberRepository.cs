using BookStore_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Repository
{
    public class BookManagementMemberRepository
    {
        //Các hàm CRUD của table Member/Account
        //ham tra ve 1 account nao do theo username/email
        public BookManagementMember Get(string email)
        {
            //db dang moc vao csdl co san 3 table, list cac data
            BookManagement2023DbContext db = new BookManagement2023DbContext();
           return db.BookManagementMembers.FirstOrDefault(x => x.Email == email);  
        }
    }
}
