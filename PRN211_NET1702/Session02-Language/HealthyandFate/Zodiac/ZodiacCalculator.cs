namespace Zodiac
{
    public class ZodiacCalculator
    {
        //Hàm này trả về cung hoàng đạo của bạn 
        //dựa trên tháng và ngày sinh 
        public static string GetZodiacSign(int day, int month)
        {
            switch (month)
            {
                case 1:
                    if (day >= 20)
                        return "Aquarius";
                    else if (day <= 19)
                        return "Capricorn";
                    else
                        return "Invalid date";
                    break;
                case 2:
                    if (day >= 19)
                        return "Pisces";
                    else if (day <= 18)
                        return "Aquarius";
                    else
                        return "Invalid date";
                    break;
                default:
                    return "Invalid date";
                    break;
                case 3:
                    if (day >= 21)
                        return "Aries";
                    else if (day <= 20)
                        return "Pisces";
                    else
                        return "Invalid date";
                    break;
                case 4:
                    if (day >= 20)
                        return "Taurus";
                    else if (day <= 19)
                        return "Aries";
                    else
                        return "Invalid date";
                    break;
                case 5:
                    if (day >= 21)
                        return "Gemini";
                    else if (day <= 20)
                        return "Taurus";
                    else
                        return "Invalid date";
                    break;
                case 6:
                    if (day >= 21)
                        return "Cancer";
                    else if (day <= 20)
                        return "Gemini";
                    else
                        return "Invalid date";
                    break;
                case 7:
                    if (day >= 23)
                        return "Leo";
                    else if (day <= 22)
                        return "Cancer";
                    else
                        return "Invalid date";
                    break;
                case 8:
                    if (day >= 23)
                        return "Virgo";
                    else if (day <= 22)
                        return "Leo";
                    else
                        return "Invalid date";
                    break;
                case 9:
                    if (day >= 23)
                        return "Libra";
                    else if (day <= 22)
                        return "Virgo";
                    else
                        return "Invalid date";
                    break;
                case 10:
                    if (day >= 23)
                        return "Scorpio";
                    else if (day <= 22)
                        return "Libra";
                    else
                        return "Invalid date";
                    break;
                case 11:
                    if (day >= 22)
                        return "Sagittarius";
                    else if (day <= 21)
                        return "Scorpio";
                    else
                        return "Invalid date";
                    break;
                case 12:
                    if (day >= 22)
                        return "Capricorn";
                    else if (day <= 21)
                        return "Sagittarius";
                    else
                        return "Invalid date";
                    break;
                
            }
        }
    }
}
