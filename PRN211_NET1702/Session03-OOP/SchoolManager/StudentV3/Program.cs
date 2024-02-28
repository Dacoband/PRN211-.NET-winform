namespace StudentV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student student = new Student(); đang lỗi 
            //Tool sẽ tự động sổ ra số lượng constructor tưỡng ứng để chọn để đúc object , đưa đúng số thám số mà các cons đg có , 
            // nếu class đã có sẵn các cro thì sdk ko tự động tạo thêm ctor rỗng
            // nếu bạn muốn new ctor rỗng bạn tự tạo phêũ này qua lệnh stor tab => ctor đc khai báo chủ động tường minh không ngầm gì cả - explicit 
            //Logic : một class luôn luôn có ít nhất 1 constructor nào đó để clone object !!!!!


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
}
