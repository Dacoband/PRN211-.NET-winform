namespace DelegateReview
{
    //một namespace sẽ có nhiều class, các class có thể để riêng từng file hoặc để chung trong 1 tập tin đều ok - đều mang cùng 1 ý nghĩa là namespace có nhiều class!!!

    //delegate là 1 loại class đặc biệt, thay vì class bth Lecturer, Student dùng lưu ingo của các object dạng phức tạp

    //THÌ DELEGATE LÀ 1 CLASS CHUYÊN ĐI LƯU TRỮ TÊN CÁC HÀM CÙNG STYLE NÀO ĐÓ 
    //T COI TÊN HÀM LÀ VALUE
    //DANH TỪ ĐẠI DIỆN CHO NHIỀU VALUE => GỌI LÀ DATA TYPE
    //1 2 3 5 10 1000 -> INT 
    //F1() F2() F3() F4() => F() - DATA TYPE

    //3 THẰNG NGANG CƠ NHAU 
    //1. class bth
    //2. interface
    //3. delegate

    public delegate void NoInputNoOutputDelegate();
    //nhóm void F() nói chung ko vào ko ra
    //ngầm sau lưng chính là 1 calss tên là NoInputNoOutputDelegate ~ Student

    public class Lecturer
    {
        //info của GV
        string _id;
    }
    public class Student
    {
        //info của HS
        int _yob = 2000;
        public void TellHerMessage3() => Console.WriteLine("3. Chúng ta của tương lai");
    }



    internal class Program
    {
        static void Main(string[] args) {
            //int                      yob    = 2004
            //Student                   s     = sv cụ thể new Student(...){...}
            //NoInputNoOutputDelegate     f     = 1 hàm cụ thể
            NoInputNoOutputDelegate f = new NoInputNoOutputDelegate(TellHerMessage1);
            //f là nick name của Tell Her Message 
            //luật sư           thân chủ 
            //1 hàm có lúc này có 2 tên : f  TellHerMessage()
            //                          gọi f() TellHerMessage()
            f();//gọi hàm gián tiếp, không gọi hàm gốc trực tiếp, luật sư hành xử, cũng là thân chủ hành xử 
            f.Invoke();

            f = TellHerMessage2; //new ngầm 
            f();

            f += new Student().TellHerMessage3;
            f();

        }

        static void TellHerMessage1() {
            Console.WriteLine("1. Cuộc sống em ổn không");
        }

        static void TellHerMessage2() => Console.WriteLine("2. Xa anh em phải hạnh phúc");

    }
}