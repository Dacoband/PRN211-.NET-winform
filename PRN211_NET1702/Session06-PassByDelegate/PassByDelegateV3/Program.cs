namespace PassByDelegateV3
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#5: gọi 2 hàm in 2 bài hát qua tham số hàm ! NEW !!
            PrintSongLyricALAYLM();
            PrintSongLyricThe1();   //style Action cho cả 2

            Action f = PrintSongLyricThe1;
            f = PrintSongLyricALAYLM;
            f = () => { };

            // BIẾN DELEGATE = HÀM NÀO ĐÓ CỤ THỂ CÓ SẴN, = 1 BIỂU THỨC LAMBDA
            //               = 1 ĐOẠN CODE NÀO ĐÓ
            // ĐIỀU GÌ XẢY RA NẾU, KHAI BÁO THAM SỐ CỦA HÀM LÀ 1 DELEGATE??

            f();
        }

        public static void PrintSongLyricThe1()
        {
            Console.WriteLine("The song The 1 - by Taylor Swift\n");
            Console.WriteLine(@"I'm doing good, I'm on some new shit
Been saying ""yes"" instead of ""no""
I thought I saw you at the bus stop, I didn't though
I hit the ground running each night
I hit the Sunday matinée
You know the greatest films of all time were never made");
            Console.WriteLine();
        }

        public static void PrintSongLyricALAYLM()
        {
            Console.WriteLine("The song As Long as You Love Me - by Justin Bieber\n");
            Console.WriteLine(@"As long as you love me
We could be starving
We could be homeless
We could be broke
As long as you love me
I'll be your platinum
I'll be your silver
I'll be your gold");
            Console.WriteLine();
        }
    }
}


