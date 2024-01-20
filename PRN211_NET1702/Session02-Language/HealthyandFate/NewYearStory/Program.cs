using Bmi;
using Zodiac;

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

        public static void ComputeBMI()
        {
            Console.WriteLine("Enter your weight (kg)");
            if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
            {
                Console.WriteLine("Invalid weight. Weight must be greater than 0.");
                return;
            }

            Console.WriteLine("Enter your height (m)");
            if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
            {
                Console.WriteLine("Invalid height. Height must be greater than 0.");
                return;
            }

            double bmi = BMICalculator.GetBMI(weight,height);
            string status = BMICalculator.EvaluateWeightStatus(bmi);
            Console.WriteLine(@$"Your BMI: {bmi:F2}
                                 And Your status: {status}");
        }

        public static void GetZodiacSign(string enZodiac)
        {

        }
    }
    
}
