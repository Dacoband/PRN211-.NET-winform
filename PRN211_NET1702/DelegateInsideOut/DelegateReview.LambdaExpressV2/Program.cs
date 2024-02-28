namespace DelegateReview.LambdaExpressV2
{
    delegate void OneInputNoOutput(int n);
    internal class Program
    {
        static void Main(string[] args) {
            OneInputNoOutput f = delegate (int n) {
                if(n < 1) {
                    Console.WriteLine("Invalid n, n must be > 0");
                    return;
                }

                Console.WriteLine($"The list of numbers from 1 to {n}");
                for(int i = 1; i <= n; i++) {
                    Console.Write($"{i} ");
                }
            };
            f(5);

            f = (n) => {
                if(n < 1) {
                    Console.WriteLine("Invalid n, n must be > 0");
                    return;
                }

                Console.WriteLine($"The list of numbers from 1 to {n}");
                for(int i = 1; i <= n; i++) {
                    Console.Write($"{i} ");
                }
            };
            f(7);
            //lambda v3 
            f = n => {
                if(n < 1) {
                    Console.WriteLine("Invalid n, n must be > 0");
                    return;
                }

                Console.WriteLine($"The list of numbers from 1 to {n}");
                for(int i = 1; i <= n; i++) {
                    Console.Write($"{i} ");
                }
            };

            f(8);
            //lambda v4 - dây nịt  
            f = paypal => {
                if(paypal < 1) {
                    Console.WriteLine("Invalid n, n must be > 0");
                    return;
                }

                Console.WriteLine($"The list of numbers from 1 to {paypal}");
                for(int i = 1; i <= paypal; i++) {
                    Console.Write($"{i} ");
                }
            };

            f(8);
            //in ra các số chẵn từ 1 cho đên n ko được viết hàm lẻ, ko được dùng biến f 
            OneInputNoOutput fx = delegate (int x) {

            };
            fx = (n) => { };
            fx = n => {
                for(int i = 1; i <= n; i++) {
                    if(i % 2 == 0)
                        Console.Write($"{i} ");
                }
            };
            fx(20);
            //lambda là dùng trong delegate 
            //expression body dùng full tên hàm 
            PrintTriple(5);
            fx = PrintTriple;
            fx(3);
            fx = x => Console.WriteLine($"{x}{x}{x}");
            fx(5);

        }

        static void PrintNumbers(int n) {
            if(n < 1) {
                Console.WriteLine("Invalid n, n must be > 0");
                return;
            }

            Console.WriteLine($"The list of numbers from 1 to {n}");
            for(int i = 1; i <= n; i++) {
                Console.Write($"{i} ");
            }
        }

        static void PrintTriple(int n) => Console.WriteLine($"{n}{n}{n}");

    }
}
