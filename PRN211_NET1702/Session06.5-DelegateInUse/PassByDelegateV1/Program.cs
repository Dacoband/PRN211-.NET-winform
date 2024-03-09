namespace PassByDelegateV1
{
    //CHALLENGE #1: IN RA 2 LỜI BÀI HÁT NÀO ĐÓ CỦA TAYLOR SWIFT: THE 1, LOVER
    //              LÀM THEO STYLE TRUYỀN THỐNG

    //CHALLEGE #2: DÙNG DELEGATE ĐỂ IN BÀI HÁT
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#1: Call explicit methods directly as normal - Call hàm có sẵm");
            PrintSongLyricsThe1();
            PrintSongLyricsLover();  //gọi hàm run() có dấu ()

            Console.WriteLine("C#2: Call explicit methods using delegate");
            //PrintSongLyricsThe1();
            //PrintSongLyricsLover();  //gọi hàm run() có dấu ()
            //style Action - void F()

            Action f1 = PrintSongLyricsThe1;  //luật sư = thân chủ; HỢP ĐỒNG UỶ QUYỀN
            f1(); //~ PrintSongLyricsThe1()
            f1 += PrintSongLyricsLover;  //+= nối thêm bài vào, trỏ 2 hàm
                                         //1 luật su = 2 hay nhiều thân chủ - multicast delegates

                                        // = như gán biến xưa nay, chỉ trỏ 1 hàm
                                        // 1 luật sư = 1 thân chủ 
            f1.Invoke(); //run 2 hàm lẻ ; đừng quên ngoặc tròn () run hàm

            //C#3: IN RA THÊM 2 BÀI HÁT NỮA, KO ĐC TẠO HÀM LẺ CÓ SẴN RỒI GÁN
            //     MÀ DÙNG HÀM ẨN DANH VÀ BIỂU THỨC LAMBDA

            Action f2 = delegate () 
            {
                Console.WriteLine("The song lyrics August - by Taylor Swift");
                Console.WriteLine();
                Console.WriteLine(@"[Verse 1]
Salt air, and the rust on your door
...
");

            }; //VIP
            //đầu vào & thân hàm. NHỚ SỬA ĐẦU VÀO CHO PHÙ HỢP

            Action f3 = () => 
            {
                Console.WriteLine("The song lyrics Is it Over Now? - by Taylor Swift");
                Console.WriteLine();
                Console.WriteLine(@"[Intro]
(Is it? Is it? Is it? Is it? Is it?)
...
");
            }; //VIP - CHỈ LÀ HỢP ĐỒNG LUẬT SƯ = THÂN CHỦ = HÀM ẨN DANH THAY 
               //                                           VÌ HÀM CÓ SẴN

            Console.WriteLine("C#3: Call ANONYMOUS/LAMBDA EXPRESSION methods");
            f2();  //LUẬT SƯ LÊN TIẾNG .INVOKE()
            f3(); 

        }


        static void PrintSongLyricsThe1()
        {
            Console.WriteLine("The song The 1 - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(@"[Verse 1]
I'm doing good, I'm on some new shit
Been saying ""yes"" instead of ""no""
I thought I saw you at the bus stop, I didn't though
I hit the ground running each night
I hit the Sunday matinée
You know the greatest films of all time were never made
...
"); //verbatim
        }

        static void PrintSongLyricsLover()
        {
            Console.WriteLine("The song Lover - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(@"[Verse 1]
We could leave the Christmas lights up 'til January
And this is our place, we make the rules
And there's a dazzling haze, a mysterious way about you, dear
Have I known you twenty seconds or twenty years?

[Chorus]
Can I go where you go?
Can we always be this close?
Forever and ever, ah
Take me out and take me home
You're my, my, my, my lover
...
");
        }
    }
}

