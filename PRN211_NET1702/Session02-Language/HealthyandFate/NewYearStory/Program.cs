using Bmi;
using Zodiac;

namespace NewYearStory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string enZodiac =  ZodiacCalculator.GetZodiacEnglish(9, 28);
            //Console.WriteLine($"Zodiac English: {enZodiac}");

            //var viZodiac = ZodiacCalculator.GetZodiacVietnamese(enZodiac);
            //Console.WriteLine($"Zodiac VietNamese: {viZodiac}");

            //var : là kĩ thuật khai báo biến nhưng không thèm chỉ ra data type .Dâta type sẽ được suy luận ngầm từ lúc bạn gán gia trị cho biến đó,nghĩa là đến khi biên dịch app sang MSIL thì trình biên dịch sẽ tự gán data type cho biến dựa trên value biến được gán. vì value gán có data type 
            //Kĩ thuật này được gọi là Type Inference - Suy luận kiểu 

            bool running = true;
            while (running)
            {
                Console.WriteLine("1. Compute BMI Index");
                Console.WriteLine("2. Get the Zodiac Sign");
                Console.WriteLine("3. Quit");
                int choice = 0;

                while (choice < 1 || choice > 3)
                {
                    Console.Write("Choose an option (1, 2, or 3): ");
                    string input = Console.ReadLine();

                    // Try to parse the input as an integer
                    if (!int.TryParse(input, out choice))
                    {
                        choice = 0;
                        Console.WriteLine("Invalid input. Please enter a number (1, 2, or 3).");
                    }
                    else if (choice < 1 || choice > 3)
                    {
                        Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    }
                }

                switch (choice)
                {
                    case 1:
                        ComputeBMI();
                        break;
                    case 2:
                        GetZodiacSign();
                        break;
                    case 3:
                        running = false;
                        break;
                }

                // Reset choice to allow for new input
                choice = 0;
            }

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

        public static void GetZodiacSign()
        {
            Console.Write("Enter your birth year: ");
            if (!int.TryParse(Console.ReadLine(), out int year) || year < 1) 
            {
                Console.WriteLine("Invalid year.");
                return;
            }

            Console.WriteLine("Enter your birth month |1 -> 12|: ") ;
            if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month.");
                return;
            }

            Console.WriteLine("Enter your birth day |1 -> 31|: ");
            if (!int.TryParse(Console.ReadLine(),out int day) ||  day < 1 || day > 31)
            {
                Console.WriteLine("Invalid day.");
                return;
            }

            // Check if the year is a leap year
            bool isLeapYear = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));

            // Check Feb Validation
            if (month == 2 && ((isLeapYear && day > 29) || (!isLeapYear && day > 28)))
            {
                Console.WriteLine("Invalid date.");
                return;
            }

            // Check for days in months with only 30 days
            if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
            {
                Console.WriteLine("Invalid date.");
                return;
            }

            string enZodiac = ZodiacCalculator.GetZodiacEnglish(month, day);
            var viZodiac= ZodiacCalculator.GetZodiacVietnamese(enZodiac);
            Console.WriteLine($"Your Zodiac sign is {enZodiac} ({viZodiac}).");
        }
    }
    
}
