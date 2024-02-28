using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentV2.Entities
{
    internal class Student
    {
        private string _id;//_________
        private string _name;//_________
        private string _email;//________ placeholder chừa chổ trong khuôn 
        private int _yob;   // để đổ vật liệu vào 
        private double _gpa;
        //phễu nhận vật liệu vào và chayr vào bên trong hole-der
        //Diều gì xảy ra nếu khuôn không có chổ để đổ vật liệu vào bên trong. về lí thuyết ta có 1 object full không khí do khuông rỗng , nếu không đổ vât liệu sắt đồng chì thì rõ ráng bên trong có không khí lấp đầy các ngóc ngoắc của không => 1 object tự có sẵn thông tin , 1 object mang giá trị default vậy thif nếu khuôn ko ó constructor thì mặc định sdk và runtime sẽ tự động tạo ra cho bn 1 phễu rỗng không do-nothing không nhận đầu vào , không xử lý gì cả giống khuôn đóng nắp có sẵn bên trong không cần lm j cả 
        //SDK tự tạo cho bn phễu dang như sau : 
        // lúc thực thi app 
        // public static (){không có j bên trong } => giúp ta gõ đc cú pháp new student ko lm j chỉ điền default khi đó các đc tính bên trong object mang giá trị mặc định lun + chuối gán rỗng số gán 0
        //bool -> false 

        // Mặc định object giấu thông tin . show ra qua Get() ai hỏi tôi trả lời
        public string GetId() { return _id; }
        public String GetName() { return _name; }
        public String GetEmail() { return _email; }
        public int GetYob() { return _yob; }
        public double GetGgpa() { return _gpa; }
        public void showInfor() => Console.WriteLine($"{_id} | {_email} |{_gpa} | {_name} | {_yob}");

        //object giả sử object đã được đúc xong , ta có nhu cầu chỉnh sửa nó 

        public void SetGpt(double gpa)
        {
            _gpa = gpa;
        }

        public void SetYob(int yob)
        {
            _yob = yob;
        }
        //new trc set sau 

        //public Student(string id, string name, string email, int yob, double gpa)
        //{
        //    _id = id;
        //    _name = name;
        //    _email = email;
        //    _yob = yob;
        //    _gpa = gpa;
        //}
    }
}
