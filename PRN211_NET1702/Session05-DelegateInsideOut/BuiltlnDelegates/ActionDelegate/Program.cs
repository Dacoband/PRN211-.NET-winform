namespace ActionDelegate
{
    // Challenge #1 : Viết hàm in ra câu lệnh thông báo : Nam em ra viện rồi !!!!
    //                  Viết theo Style truyền thống , nhớ run hàm 
    //Challenge #2 : Viết hàm in ra câu thông báo Nam em và 35 triệu !!!
    //               Dùng Delegate & Anonymous FUNCTION 
    delegate void NoInputNoOutputDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge #1 - Call method as normal");
            ShowNotfications();
            Console.WriteLine("Challenge #2 - Call method using method anonymous func");
            NoInputNoOutputDelegate f = delegate ()
            {
                Console.WriteLine("2/2/2024: Nam em bi phat 25 trieu  \n");
            };
            f();
        } 

        
        static void ShowNotfications()
        {
            Console.WriteLine("2/2/2024: Nam em ra vien roi \n");
        }

    }
}
