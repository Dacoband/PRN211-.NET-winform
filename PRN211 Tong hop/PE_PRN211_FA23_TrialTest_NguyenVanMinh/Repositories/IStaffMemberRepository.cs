using BusinessObjects.Models;

namespace Repositories
{
    public interface IStaffMemberRepository
    {
        StaffMember CheckLogin(string username, string password);
    }
}
