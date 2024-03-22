using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookManagementMemberService
    {
        //public bool CheckUserAccount(string Email, string Password)
        //{
        //    using (SqlConnection connection = new SqlConnection(GetConnectionString()))
        //    {
        //        connection.Open();
        //        string query = "SELECT COUNT(*) from UserAccount\r\nwhere Email = @Email and Password=@Password";
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("@Email", Email);
        //        cmd.Parameters.AddWithValue("@Password", Password);
        //        int count = (int)cmd.ExecuteScalar(); // Số lượng bản ghi tìm thấy

        //        // Trả về kết quả của việc kiểm tra thông tin đăng nhập
        //        return count > 0;
        //    } 
        //}
        //public int GetUserRole(string Email)
        //{
        //    using (SqlConnection connection = new SqlConnection(GetConnectionString()))
        //    {
        //        connection.Open();
        //        string query = "select Role  from UserAccount where Email = @Email ";
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("@Email", Email);
        //        object result = cmd.ExecuteScalar(); 
        //        return Convert.ToInt32(result);
        //    }
        //}

        public UserAccount CheckLogin(string Email, string Password)
        {
            BookManagementMemberRepository rp = new BookManagementMemberRepository();
            UserAccount account = rp.Get(Email);
            //if (account == null)
            //{
            //    return null;

            //}
            //if (account.Password == Password)
            //{
            //    return account;
            //}
            //return null;
            return account != null && account.Password == Password ? account : null;
        }
    }
}
