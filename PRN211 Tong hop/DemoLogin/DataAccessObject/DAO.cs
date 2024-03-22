using BussinessObject;

namespace DataAccessObject
{
    public class DAO
    {
        private DAO() { }
        private static readonly object lockObject = new object();
        private static DAO instance;
        public static DAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new DAO();
                    }
                    return instance;
                }
            }
        }
        public AccountMember checkLogin(string email, string password) {
            try
            {
                AccountMember member = null;
                var context = new ArtTattoo2023DbContext();
                member = context.AccountMembers
                    .FirstOrDefault(mem => mem.EmailAddress.Equals(email)
                    && mem.Password.Equals(password)&&mem.Role==2);
                return member;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}