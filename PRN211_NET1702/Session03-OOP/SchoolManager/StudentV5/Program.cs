using StudentV5.Entities;

namespace StudentV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //có thêm 1 cách nữa để new nó 
            Student s1 = new Student();
            s1.Name = "Ngoc Trinh";
            s1.Gpa = 4.0;
            s1.Email = "thuc@gmail.com";
            s1.Yob = 2023;
            Console.WriteLine($"{s1.Name} | {s1.Gpa} | {s1.Email} | {s1.Yob} |");
            //hay nè :
            Student s2 = new Student() { Id = "se170295", Name = "Thuc", Email = "thuc@gmail.com", Yob = 2003, Gpa = 10 };
            Console.WriteLine($"");
            // create object using property initiation 
            // tạo object và kèm lưỡng việc khởi dộngd gán giá trị cho các đặc tính của project 
            //không nhầm lẫn với name-argument 
        }
    }
};
