using Bmi; // tương đương import java.util ; bên java
           // Muốn xài đồ của project khác thì phải xin phép

namespace Math
{
    internal class Program
    {
        //svm tab là psvm bên Java 
        static void Main(string[] args)
        {
            CheckReadOnlyParam(1000);
            Print100FirstIntegers();
            int sumE;
            int sumA = SumEvenList(out sumE);

            Console.WriteLine($"Sum All : {0} | Sum Evens {1}", sumA ,sumE);
        }

        //tui cần in ra 100 số tự nhiên liên tiếp bắt đầu từ 1 
        static void Print100FirstIntegers()
        {
            Console.WriteLine(@"1 2 
3 4 
  5 6
    7 8
      9 10 11 12
              13 14 15 16 ... ");
            Console.WriteLine("100 first integers");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + " "); // Write in so xuong hang
            }
        }
        // Tính tổng các số từ 1 ... 100 ->5050
        public int SumIntegerList()
        {
            int sumAll = 0;
            for (int i = 0;i < 100;i++)
                sumAll += i;
            
            return sumAll;
        }
        //Tính tổng số chẵn 1 ... 10 
        public static int SumEvenList(out int sumEven)
        {
            int sumE = 0 ; 
            int sumAll = 0;
            for(int i = 0; i<= 10 ; i++)
            {
                sumAll += i;
                if (i % 2 == 0)
                    sumE += 1;
            }
            sumEven = sumE ;//TÍnh xong bên trong đổ ra ngoài 
                            // tui hứa sẽ thêm 1 giá trị đc trả về qua ngã hướng
                            //Tham số đầu vào 
                            //Nếu không chiiuj làm lời hứa này, báo lỗi cú pháp 
                            //Gán giá trị cho biến out là bắt buộc 
                            //Luôn có giá trị trả về nếu xài hàm có out
            return sumAll;
        }

        static void CheckReadOnlyParam(int n)
        {
            Console.WriteLine($"n before changing its value : {n} ");
            //n = 2024; // change the value of n 
            int m = n; // từ khóa in đứng kế bên biến bên local ở tham số 
                // hàm, biến hóa biến n kế bên thành readOnly, có nghĩa là 
                // trong hàm từ nay cấm được thay đổi value của tham số 
                //biến readOnly mức local - mức tham số 

                //To do at home : Static void CheckReadOnlyParam(in Student s)
                //biến đưa vào là biến object, trỏ 1 vùng new 
            Console.WriteLine($"n after updating its value: {n}");

        }
        // Mantra : thần chú : static chỉ chơi với static
        // Lý do : public class student {static string name; }
        // toàn đối tượng sẽ bị xài chung tên với nhau hết !!!
        // Ôn kĩ về static trên YT
        // Static sẽ còn dùng cho Desgin Patterns, ví dụ Singleton 

         
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");

        //    double bmi =  BMICalculator.GetBMI(62, 17.3);
        //    //Xafi thư viện do mình viết ra 
        //    // Gọi hàm của class khác ở namespace khác ở project khác 
        //    // ở DLL khác .
        //    Console.WriteLine($"Your weight status: {BMICalculator.EvaluateWeightStatus(bmi)}");

        //}
    }
}
