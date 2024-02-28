using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Công thức chuẩn để làm Class
//1. tạo class - danh từ riêng - tên chung cho 1 nhóm obj tương đồng 

//2. khai báo các đặc điểm - property của 1 obj/class
//  - Dùng truyền thống như java
//  - Dùng FULLPROP (Hậu trường tự gen ra _Backing Field)
//  - Dùng Auto - implememted prop, (PROP TAB TAB, tự gen ngầm _BACKING)

//3. Tạo Contructor có tham số, không tham số (empty ) hoặc cả 2, hoặc không tạo cái phễu nào, nếu không tạo ctor, phễu thì mặc định runtime sẽ tạo giùm 1 cái default/empty, đảm bảo lúc nào cũng new được .

//4. tạo hàm GET/SET (truyền thống JAVA), dùng PROP thì ko cần 

//5. Tạo hàm show hầu hết / toàn bộ INFO , SHOWALL() SHOWPROFILE()
// GIang hồ khuyến cáo nên đặt tên hàm này cho chuẩn, và trả về giá trị thay vì IN trực tiếp, đó là hàm TOSTRING()
//ToString() là tên hàm chuẩn cho mọi class, được OOP khuyên dùng !!!!!!

//6. Tạo các hàm còn lại, bất kì, dùng để xử lí INFO nào đó trong OBJ vừa đc đổ INFO vào qua ngả CONSTRUCTor hay ngả OBJ INITIALIZER.

namespace StudentV5.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private string _email;
        private int _yob;
        private double _gpa;

        public Student(string id, string name, string email, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _email = email;
            _yob = yob;
            _gpa = gpa;
        }
        //Gọi là : AUTO - IMPLEMENT PROPERTY 
        public string Id { get; set; } // Viết kiểu này thì ID , Name hay YOB ,...
        public string Name { get; set; } // Được gọi là PROPerty 
        public string Email { get; set; } // Đặc điểm của 1 object trong tương lai được đúc 
        public int Yob { get; set; } // Ngầm phía sau có _field tương ứng để store value đổ vào 
        // vậy mún gõ code này khi quên cú pháp, gõ PROP TAB TAB 
        // Nếu muốn gõ có cả _BACKING FIELD gõ : PROPFULL TAB TAB
        //Phải đọc property theo 3 cách : GET, SET, biến thông thường 
        //Gán biến -> SET, đọc biến tên biến -> GET
        // Biến là có được cơ hộ GET 
        //Biến 
        public double Gpa { get; set; }

        public Student()
        {
        }
        //khi biên dịch và runtime sdk tự chèn shift _ tương ứng vào phía sau hậu trường , kỹ thuật này gọilaf autoinplimented property 

        //java không có cách  này 1 cách chính thức mà phải sài thư viện bên thứ 3 : Lombox denpendencies 
        //database first , sau tết gõ 1 lệnh , 50 table trong database sẽ tự đọng convert thành class xài auto prop như trên 
        public void ShowProfile() => Console.WriteLine("{0} | {1} | {2} | {3} | {4}", Id, Name, Yob, Email, Gpa);

        // java : hàm con trùng tên hàm cha 
        //        Override
        // C#: Override, New 
        public override string tostring() => $"{id} | {name} | {yob} | {email} | {gpa}";

    }
}


