using BusinessObjects.Models;

namespace DataAccessObjects
{
    public class StaffMemberDAO
    {
        private static StaffMemberDAO instance = null;
        private static object lockObject = new object();

        private StaffMemberDAO() { }

        public static StaffMemberDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StaffMemberDAO();
                }
                return instance;
            }
        }
        public StaffMember CheckLogin(string email, string password)
        {
            using var db = new AirConditionerShop2023DbContext();
            return db.StaffMembers.SingleOrDefault(m => m.EmailAddress.Equals(email) && m.Password.Equals(password));

        }
    }
}