using StudentV1.Entities;

namespace StudentV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateAStudentObjectV1();
            CreateAStudentObjectV2();
            CreateAStudentObjectV3();
        }

        static void CreateAStudentObjectV1()
        { //tạo mới 1 object sinh viên, 1 sinh viên cụ thể, 1 thing complex, style truyền thống 
            // Con người luôn có xu hướng đặt tên cho mọi thứ quang họ sau khi đã mô tả chúng 
            // name : Leonardo... nick: Messi , goal : 800 ...
            // ta gọi object này là messi 
            // 3.14 vẫn gọi là PI 
            //style kieu moi 
            Student Thuc = new Student("SE170295", "ThucNM", "thuc@fpt.edu.vn", 2003, 1.0);
            Thuc.ShowProfile();
        }

        static void CreateAStudentObjectV2()
        {
            var Nhan = new Student("SE171117", "NhanHT", "Nhan@fpt.edu.vn", 2003, 5.0);
            Nhan.ShowProfile();
        }

        static void CreateAStudentObjectV3()
        {
            //Style new kiểu mới 
            // bỏ kiểu dữ liệu sau new vì đã có data type rồi 
            Student Bao = new ("SE171317", "BaoNDG", "Bao@fpt.edu.vn", 2003, 1.0);
            Bao.ShowProfile();
            // tự xuy luận nhật là student  do value gắn vào 
        }

        static void CreateAStudentObjectV4()
        {
            // Lộn xộn đưa value vào hàm lộn xộn thứu tự, miễ là đi kèm tên biến máy runtime biết để map value cho đúng 
            //NAMED_ARGUMENT , ĐƯA VALUE KÈM TÊN THAM SỐ
            var Nhan = new Student("SE171117", "NhanHT", "Nhan@fpt.edu.vn", 2003, 5.0);
            Nhan.ShowProfile();
        }

    }
}
