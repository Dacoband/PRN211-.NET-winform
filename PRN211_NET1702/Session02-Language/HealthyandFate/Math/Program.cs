using Bmi; // import java.util ; bên java
           // Muốn sài đồ chơi của người ở nơi khác phải xin phép


namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumA, sumO =2024;

           sumA = SumOddList(ref sumO);
            Console.WriteLine($"Sum Odd  :{0}", sumO);
        }

        //MUSN CHƠI VỚI RÈ THÌ BẮT BUỘC BIẾN TRUYỀN VÀO REF PHẢI CÓ 
        //1 GIÁ TRỊ DEFAULT NÀO ĐÓ, INITIAL VALUE 
        //NẾU TRONG HÀM CÓ GSN BIẾN REF, THÌ TA ĐÈ VALUE DEFAULT 
        //NẾU TRONG HÀM QUÊN KHÔNG GÁN REF THÌ VẪN XÀI DEAFAULT 
        //TRONG HÀM SỬA Ở BÊN NGOÀI XA VA, REF, OUT ĐỀU LÀ 
        //PASS BY REFERENCE 



        // Tính tổng các số từ 1 đến 100
        //out 

        // ref nó lỏng lẻo hơn out không bắt buộc ta phai gán 
        //Giá trị cho biến out thich thì gắn không thích thì chử
        public static int SumOddList(ref int sumOdd)
        {
            int sumAll = 0, sumO = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumAll += i;
                if (i % 2 == 0)
                    sumO += i;
            }
            sumOdd= sumO;
            return sumAll;
        }
        // tui cần tính in ra 100 con số tự nhiên đếm được từ 1 liên tiếp 
        static void Print100FirstIntegers()
        {
            Console.WriteLine(@"12 
     3 4 
         5 6
             7 8
                 9 10
                      11 12 13 14 15 .....");
            Console.WriteLine(" 100 first integers");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i + " ");
            }

        }
        static void ChecReadOnlyPram(in int n)
        {
            Console.WriteLine($"before changeing it value :{n}");
            // n = 2024;

            int m = n; // từ khoa in đứng kế bên biến local ở tham số
            //ham biến hóa biến n kê bên thành readonly , có nghĩa là
            //biến readonly mức local - mức tham số
            // về  nhà : static void CheckReadOnlyParam{ in Student s}
            // biến đưa vào là biến object trỏ 1 vùng new 
            Console.WriteLine($"After updating is value :{n}");
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");

        //    double bmi = BmiCaculator.GetBMI(55, 1.73);

        //    // Sài thư viện do mình viết ra 
        //    //Gọi hàm của class khác ở namespace khác ở project khác
        //    // ở dll khác

        //    Console.WriteLine($"Your Weight Status : {BmiCaculator.EvalueateWeightStatus(bmi)} ");
        //}


        // mantra : Thần chú static chỉ chơi với static 
        //Lý do : public class Student { static String name; }
        // Toàn trường sài chung 1 tên vc !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //ôn kĩ static trên youtube vì nó còn đuọcw dùng cho 
        //DESIGN PATTERNS ,VÍ DỤ :Singleton

        //Out : Tôi hứa sẽ có 1 giá trị thêm được trả về qua hướng tham số đầu vào
        //Nếu không chịu làm lời hưa này => báo lỗi cú pháp 
        //Gán giá trị out là bắt buộc 
        //Luôn có giá trị trả về nếu sài hàm out

        //Trong hàm thay đổi bên ngoài bị ảnh hưởng khác truyền thống => Đây là kĩ thuật truyền tham chiếu theo style tham chiều
        //PASS BY REFERENCE 
        //TAO ĐƯA M 1 BIẾN NGOÀI HÀM , TRONG HÀM M ĐỔI VALUE GIÙM TAO 
        //Những gì trong hàm , bên ngoài bị luôn ,

        //Khác truyền thống : Pass by value , Tao chỉ láy value m đưa sau đó không care m



        // svm tab giống java
        //static void Main(string[] args)
        //{
        //    ChecReadOnlyPram(10);
        //    Print100FirstIntegers();
        //    int sumE;
        //    int sumA = SumIntegersList(out sumE);
        //    Console.WriteLine($"Sum of all integers: {sumA}");
        //    Console.WriteLine($"Sum of even integers: {sumE}");

        //    //OUT có 2 cách sài //Truyền nó vào hàm out
        //    //Cách 2 : Vừa khai báo vừa truyền vào hàm out 
        //    sumA = SumIntegersList(out int sumEven);
        //    Console.WriteLine($"Sum Even: {sumEven} ");




        //}



    }
}