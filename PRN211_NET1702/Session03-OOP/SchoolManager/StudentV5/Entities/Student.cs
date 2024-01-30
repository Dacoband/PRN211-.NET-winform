using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public Student()
        {
        }
        //khi biên dịch và runtime sdk tự chèn shift _ tương ứng vào phía sau hậu trường , kỹ thuật này gọilaf autoinplimented property 

        //java không có cách  này 1 cách chính thức mà phải sài thư viện bên thứ 3 : Lombox denpendencies 
        //database first , sau tết gõ 1 lệnh , 50 table trong database sẽ tự đọng convert thành class xài auto prop như trên 


    }
}
