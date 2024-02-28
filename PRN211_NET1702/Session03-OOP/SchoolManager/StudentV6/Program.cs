using StudentV6.Entities;

namespace StudentV6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithAnonymousTypeV1();
            PlayWithAnonymousTypeV2();
        }

        static void PlayWithAnonymousTypeV1()
        {
            // Muốn lưu thông tin của 1 lon bia : Mã Vạch (code)
            //                                    Tên bia: Heineken
            //                                    Giá tiền: 23000
            //                                    Ml: 330ml
            //var aBeer = new Beer() {.... }; // cách viết obj initializer
            /*var aBeer = new Beer(code: "Ken", name: ...);*/ // cst,named arg
            //var aBeer = new Beer("ken", 23000); tham số truyền thống 
            var aBeer = new { Code = "KEN201", Name = "Heineken", Price = 23000,  Ml = 330 };
            //thiếu mỗi tên class, còn laji thì mình truyền data vào qua kĩ thuật obj initializer 
            // Về lí thuyết nó chính là class ngầm Beer(Code, Name, Price, Ml) do ta làm biếng tạo sẵn class như vậy 
            // có class & property để điền giá trị vào backing field 
            // runtime sẽ ngầm tạo ra class gì đó tương ứng với prop  này, ta không cần quan tâm tên class mà chỉ quan tâm vùng new này chứa các cột info đã được điền sẵn vào value 
            // kĩ thuật này được gọi là Anonymous Data Type 
            // Ko định nghĩa sẵn cụ thể 1 class - implicit - tạo class ngầm 
            // Runtime sẽ tự làm giùm mình hàm TOSTRING() IN đẹp 

            // dân PRO gọi TOSTRING()

            Console.WriteLine(" Print the detail of an object created by using anonymous data type");
            Console.WriteLine(aBeer);//Ai mà gọi .ToString() là dở 

            Console.WriteLine("Print obj by using properties: ");
            Console.WriteLine($"{aBeer.Code} | {aBeer.Name} | {aBeer.Price} | {aBeer.Ml}");// in dejp 


        }

        static void PlayWithAnonymousTypeV2()
        {
            Student s1 = new Student() { Id = "SE17117", Name = "Nhan", Email ="NhanHTSE171117@fpt.edu.vn", Yob = 2003, Gpa = 4 };
            Student s2 = new Student() { Id = "SE12", Name = "Bao", Email = "BaoHTSE171117@fpt.edu.vn", Yob = 2003, Gpa = 4 };
            var s3 = new Student() { Id = "SE34", Name = "An", Email = "BaoHTSE171117@fpt.edu.vn", Yob = 2003, Gpa = 4 };
            var s4 = new { Id = "SE177", FullName = "Hong" }; // Anonymous data type - vì không có chỉ định rõ tên khuôn nào đc dùng 
            Console.WriteLine("Check s4 anonymous data type : " + s4);
            //                  GỌI THẦM TÊN EM 
            // Code PRO 
            // Lấy đúng 2 cột của bạn sinh viên nào đó ! 

            var s5 = new { s3.Id, s3.Name };
            Console.WriteLine("Check s5 anonymous data type: " + s5);


        }
    }
}
