using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// java  java.util com.mycompany.myproject.mydouble.
namespace StudentV1.Entities
{
    internal class Student
    {
        //class là cái khuôn bên trong chứa place holder ứng với các đặc điểm của mỗi obj thuộc về Class/ Nhóm này 
        // Để có được 1 sản phẩm từ khuôn clone ra obj, ta cần phải đúc - hành động đổ vật liệu vào trong khuôn 

        private string _id; // place holder
        private string _name; // quy uớc dùng cú pháp con lạc Đà 
        private string _email; // và _ở đâu từ _basicSalary 
        private int _yob; 
        private double _gpa;

        public Student() { }

        public Student(string id, string name, string email, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _email = email;
            _yob = yob;
            _gpa = gpa;
        }


        // Ctrl . tạo phễu 
        // mặc định info của t là private cho sự riêng tư 
        // hành động giao tiếp để thấy đc info của nhau 

        public string GetName() =>  _name;
        
        public string GetEmail() => _email;
        
        public int GetYob() => _yob;
        
        public double GetGpa() => _gpa;
        // expression body 

        // hành động show hết info, show hết profile, show những thứ internal 1 lượt thành => ToString()
        // biến đổi mọi thứ thành chuỗi dài show ra 
        // 1 phiên bản trả về chuỗi, 1 phiên bản in ra all 
        public void ShowProfile()
        {
            Console.WriteLine(@$"Here is my info: 
Id: {_id}
Name: {_name}
Email: {_email}
Yob: {_yob}
GPA: {_gpa}");
        }// verbatim interpolation

        
    }
}
