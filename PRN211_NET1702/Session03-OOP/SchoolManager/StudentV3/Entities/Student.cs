using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentV3.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private string _email;
        private int _yob;
        private double _gpa;

        public Student(string id, string name, string email, int yob, double gpa) : this(id, name)
        {
            _email = email;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }



        //constructor có tham số  ctrl . chọn generate cons..
        // để tạo riêng constructor default / emty ta có thể chủ động tạo ra nó bằng accsh gỏ ctor tab
        //public Student()
        //{

        //}

        //Ngoài đời có nhiều cách để đúc infor 
        //web form đăng kí member 
        //name (*) :___________
        //Email(*) : ____________
        //Yob:_____________
        //Address:________________
        //Company:___________________
        //



        // có bao nhiêu cái phễu thì có bâys nhiêu cách đúc object , bấy nhiêu accsh new

    }
}
