namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        // Java : xét về cách biến được lưu trong RAM thì có 2 loại DATA TYPE 
        //1. PRIMITIVE DATA TYPE : Tốn 1 vùng ram để lưu value 
        //                          Kiểu dữ liệu SINGLE Value
        //                          Int long double float chả boolean 

        //2. Object Data Type (References data type, "Pointer")
        // Tốn 2 vùng ram, 1 vùng cho biến con trỏ, tham chiếu 
        //                 1 vùng ram bự cho việc view new, lưu new obj 
        // String , Cat, Dog, File, Exception, Random, 

        // C# gần y chang 100%
        //1. Value Type (~ PRIMITIVE IN JAVA)
        //2. REFERENCE TYPE : i chang 
        static void PlayWithValueTypeArray()
        {
            //Bài toán : tui cần lưu trữ 10 con số nguyên của trò chơi 5 10 15 20 
            //Tính tổng giùm tôi 10 con số này 
            // Trả lời : 
            // Answer 1 : Dùng biến lẻ, Khai báo biến lẻ
            // Answer 2 : Dùng biến sỉ, Khai báo biến sỉ : Mảng
            //                          Mua 1 lốc nhưng đc nhiều biến 

            int a1 = 5, a2 = 10, a3 = 15, a4 = 20, a5 = 25, a6 = 30, a7 = 35, a8 = 40, a9 = 45, a10 = 50;
            
            int sum = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10;
            int[] arr = new int[10];
            //có 10 biến i đã được tạo ra 
            // arr[0] arr[1] arr[2] arr[3] arr[4] arr[5]
            //    a1    a2      a3     a4    a5     a6
            //gán giá trị 
            arr[0] = a1;
            arr[1] = a2;
            arr[2] = a3;
            arr[3] = a4;
            arr[4] = a5;
            arr[5] = a6;

            // [index chỉ ra số thứ tự của từng biến trong 1 đám biến đã được khai báo , đếm từ 0]
            //[index = 0 ] => ta có quyền, hay xài FOR cho mảng !
        }
    }
}
