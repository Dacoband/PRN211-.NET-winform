using StudentV5.Entities;

namespace StudentV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { Id ="SE171117", Name ="Nhan Huynh", Email ="NhanHTSE171117@fpt.edu.vn", Yob = 2003, Gpa = 4.0 };
            Console.WriteLine("Check the student info after creating an object");
            s1.ShowProfile();
            Console.WriteLine(s1.ToString()); // Nguyên lí kế thừa 
            // Nếu 1 class không có ToString() ta vẫn gọi được hàm này do mọi class đều thuộc về class tổ tiên là OBJ
            // Và class ông tổ có sẵn hàm ToString(), hàm này chẳng làm gì nhiều, vì ông tổ không chắc Con cháu có info gì, do đó ông tổ chỉ trả về loại class mà đứa chấu thuộc về 
            // tức là trả về data type của obj đang hỏi tostring()
            //Bên java trả lại địa chỉ , con số HEXA tọa độ vùng New 
            // Dân JAVA và Dân C# nếu là dân PRO thì kh bao giờ dùng Tostring()
            // mà TOstring() được gọi ngầm qua tên biến 
            // Gọi ngầm tên em 
            Console.WriteLine("GỌI thầm tên em TOSTRING() ");
            Console.WriteLine(s1);// TOSTRING() phèn lắm , ko PRO 
            //runtime tự đi tìm TOSTRING() để chạy. Con ko có thì đi tìm CHa, Cha ko có thì đi tìm Ông Nội, Ông Nội ko có thì lên ông tổ project.

        }
        //static void Main(string[] args)
        //{
        //    //có thêm 1 cách nữa để new nó 
        //    Student s1 = new Student();
        //    s1.Name = "Ngoc Trinh";
        //    s1.Gpa = 4.0;
        //    s1.Email = "thuc@gmail.com";
        //    s1.Yob = 2023;
        //    Console.WriteLine($"{s1.Name} | {s1.Gpa} | {s1.Email} | {s1.Yob} |");
        //    //hay nè :
        //    Student s2 = new Student() { Id = "se170295", Name = "Thuc", Email = "thuc@gmail.com", Yob = 2003, Gpa = 4.0 };
        //    Console.WriteLine($"{s2.Id} | {s2.Name} | {s2.Yob} | {s2.Gpa}");
        //    // create object using property initiation 
        //    // tạo object và kèm lưỡng việc khởi dộngd gán giá trị cho các đặc tính của project 
        //    //không nhầm lẫn với name-argument 
        //}
    }
}
