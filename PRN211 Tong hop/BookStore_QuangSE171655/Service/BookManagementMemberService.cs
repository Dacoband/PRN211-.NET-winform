using BookStore_Repository;
using BookStore_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookManagementMemberService
    {
    //class nay se tuong tac voi 2 ben 
    //goi repo de xu ly DB xong mang qua form
    public BookManagementMember CheckLogin(string email,string password)
        {
            BookManagementMemberRepository repo = new BookManagementMemberRepository();
          
            BookManagementMember account = repo.Get(email);//tim account theo email
        
            if (account == null)
                return null;//email ko ton tai
        if(account.Password==password)
                return account;
            return null;
        }
    }
}
