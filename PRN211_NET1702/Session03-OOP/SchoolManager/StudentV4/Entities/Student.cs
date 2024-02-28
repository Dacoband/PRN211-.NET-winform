using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentV4.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private string _email;
        private int _yob;
        private double _gpa;

        // Câu chuyện của get set
        public string GetName()
        {
            return _name;
        }
        public void SetName(String name)
        {
            _name = name;
        }
        public string GetEmail()
        {
            return _email;
        }
        public void SetEmail(string email)
        {
            _email = email;
        }
        //get và set(x) bản chât là đg thao tác trên x 
        //C shrph đưa ra cách viết gộp , quy 2 hàm về chung 1 tên gọi 
        //x thay thế = name , email , ... tùy vào đặc điểm mình muốn get set
        public int Yob
        {
            get => _yob;
            set { _yob = value; }
        }
        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }// cách cái ra nha sau gpa
        //Kĩ thuật viết get set kiểu này gọi là full proberty vì nó chứa đầy đủ tên hàm get set và 1 phêu _ để lưu info get set 
        // field _ đc gọi tên mới là : bakend field  em chống lưng cho get set 
        //nếu bn lỡ quên cú pháp hãy gõ propfull tab tab 
        private int _phone;

        public int phone
        {
            get { return _phone; }  // sửa lại expression 
            set { _phone = value; }
        }
    }
}
