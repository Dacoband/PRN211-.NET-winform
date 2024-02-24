using Repositories.Entities;
using Services;

namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //by Using Generic, we can create a flexible bag/room/...
            //for now, the box can hold student/lecturer/student of SE department,...
            //all of these allocated in different memory segmentation line in the real life, we have many cabinets for separate purpose
            //cross function cabiet - tu da nang 
            Cabinet<Student> seList = new Cabinet<Student>();
            //java: ArrayList<Student> seList = new  ArrayList<Student>();
            Cabinet<Student> bizList = new Cabinet<Student>();
            Cabinet<Lecturer> seLecList = new Cabinet<Lecturer>();

            seList.AddItem(new Student() { Id = "SE1", Name = "Do The Hieu", Email = "hieudtse170041@fpt.edu.vn", Yob = 2003, Gpa = 8.0 }); //object initialization
            seList.AddItem(new Student()
            {
                Id = "SE1",
                Name = "Nguyen Duong Gia Bao",
                Email = "hieudtse170041@fpt.edu.vn",
                Yob = 2003,
                Gpa = 8.0
            });
            bizList.AddItem(new Student() { Id = "SS3", Name = "Adu vip", Email = "asda@fpt.edu.vn", Yob = 2003, Gpa = 8.0 });
            seLecList.AddItem(new Lecturer() { Id = "001", Name = "hahdasd", Email = "sdasd@gmail.com", Yob = 1992, Salary = 12323121.00 });

            Console.WriteLine("The SE Student List:");
            seList.PrintAll();
            Console.WriteLine();

            Console.WriteLine("The BIZ Student List:");
            bizList.PrintAll();
            Console.WriteLine();

            Console.WriteLine("The SE Lecturer List:");
            seLecList.PrintAll();
            Console.WriteLine();
        }
    }
}
