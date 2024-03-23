using Repositories;
using Repositories.Entities;

namespace Services
{
    public class BookManagementMemberService
    {
        private BookManagementMemberRepository _repo = new();
        public BookManagementMember? CheckLogin(string email)
        {
            return _repo.GetMember(email);
        }
    }
}
