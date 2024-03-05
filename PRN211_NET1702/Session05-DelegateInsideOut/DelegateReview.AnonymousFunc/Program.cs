namespace DelegateReview.AnonymousFunc
{
    //viết hàm in ra các số tự nhiên từ 1 đến 100 dùng delegate 
    delegate void NoInputNoOutput(); //void F()
    internal class Program
    {
        static void Main(string[] args) {
            NoInputNoOutput f = PrintNumbers;
            f();
            f = delegate () {
                Console.WriteLine("The list of number from 1... 100");
                for(int i = 0; i <= 100; i++) {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            };
            Console.WriteLine("Anonymous function");
            f();

            f = delegate () {
                Console.WriteLine("The list of number from 1... 100");
                for(int i = 0; i <= 100; i++) {
                    if(i % 2 == 0) {
                        Console.Write($"{i} ");
                    }

                }
                Console.WriteLine();
            };
            Console.WriteLine("Anonymous function v2");
            f();
        }

        static void PrintNumbers() {
            Console.WriteLine("The list of number from 1... 100");
            for(int i = 0; i <= 100; i++) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
