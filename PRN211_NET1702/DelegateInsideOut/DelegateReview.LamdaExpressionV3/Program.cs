namespace DelegateReview.LamdaExpressionV3
{
    //tính diện tích hình chữ nhật trả về diện tích 
    delegate double TwoInputOneOutput(double a, double b);
    //viết hàm tính x ^ y 
    //tính chu vi tam giác dựa trên 3 cạnh a,b,c
    //delegate double ThreeInputOneOutput(double a, double b, double c);
    internal class Program
    {
        static void Main(string[] args) {

            TwoInputOneOutput f = (double width, double length) => width * length;
            f = (width, length) => width * length;
            Console.WriteLine($"Area is {f(5, 7)}");
            f = (x, y) => Math.Pow(x, y);
            Console.WriteLine($"2^10 is {f(2, 10)}");
            var fx = (double a, double b, double c) => a + b + c;
            Console.WriteLine($"Chu tam giác là {fx(3, 4, 5)}");
        }

        static double GetArea(double width, double length) => width * length;

    }
}
