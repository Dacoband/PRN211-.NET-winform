using StudentV2.Entities;

namespace StudentV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            // toàn bộ infor bên trong ko đc dổ j cả
            // default value
            //chứng minh default value
            s1.showInfor();
            s1.SetGpt(8.6);
            Console.WriteLine("After updating the gpa :");
            s1.showInfor();
            // new thì gọi phễu để tạo mới object 
            //get set thì chỉnh sửa thao tác đã đc new 
            //ko tao ra thêm objet mới .. ychang cách bạn update FB 
        }
    }
}
