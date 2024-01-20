﻿using Zodiac;

namespace NewYearStory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enZodiac =  ZodiacCalculator.GetZodiacEnglish(9, 28);
            Console.WriteLine($"Zodiac English: {enZodiac}");

            var viZodiac = ZodiacCalculator.GetZodiacVietnamese(enZodiac);
            Console.WriteLine($"Zodiac VietNamese: {viZodiac}");
            //var : là kĩ thuật khai báo biến nhưng không thèm chỉ ra data type .Dâta type sẽ được suy luận ngầm từ lúc bạn gán gia trị cho biến đó,nghĩa là đến khi biên dịch app sang MSIL thì trình biên dịch sẽ tự gán data type cho biến dựa trên value biến được gán. vì value gán có data type 
            //Kĩ thuật này được gọi là Type Inference - Suy luận kiểu 
        }
    }
    
}
