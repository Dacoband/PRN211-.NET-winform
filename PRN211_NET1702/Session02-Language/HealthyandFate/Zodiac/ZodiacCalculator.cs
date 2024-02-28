namespace Zodiac
{
    // đây là loại ghi chú bình thường trong code không theo chuẩn quy ước mà MS đề nghị 
    // MS đề  nghị một chuẩn viết document để hướng dẫn sử viết hàm 
    // tương tự như Swagger_UI là chuẩn document hướng dẫn sử dụg API 

    /// <summary>
    /// This class will return the zodiac sign based on the day and month of birth, both in English and Vietnamese
    /// </summary>
    public class ZodiacCalculator
    {
        //Hàm này trả về cung hoàng đạo của bạn 
        //dựa trên tháng và ngày sinh
        /// <summary>
        /// This method will return the zodiac sign in English based on day and month of birth 
        /// </summary>
        /// <param name="day">Day must be between 1...31</param>
        /// <param name="month">Month must be between 1...12</param>
        /// <returns></returns>

        public static string GetZodiacEnglish(int month, int day)
        {
            switch (month)
            {
                case 1:  //Jan
                    if (day < 20)
                        return "Capricorn"; //Ma Kết   
                    return "Aquarius";      //Bảo Bình

                case 2:  //Feb 
                    if (day < 19)
                        return "Aquarius"; //Bảo Bình    
                    return "Pisces";       //Song Ngư

                case 3:  //Mar
                    if (day < 21)
                        return "Pisces";   //Song Ngư 
                    return "Aries";        //Bạch Dương

                case 4:  //Apr
                    if (day < 20)
                        return "Aries";   //Bạch Dương  
                    return "Taurus";      //Kim Ngưu  

                case 5:  //May
                    if (day < 21)
                        return "Taurus";  //Kim Ngưu 
                    return "Gemini";      //Song Tử 

                case 6:  //Jun
                    if (day < 21)
                        return "Gemini";  //Song Tử   
                    return "Cancer";      //Cự Giải   

                case 7:  //Jul            
                    if (day < 23)
                        return "Cancer";  //Cự Giải 
                    return "Leo";         //Sư Tử  

                case 8:  //Aug
                    if (day < 23)
                        return "Leo";     //Sư Tử  
                    return "Virgo";       //Xử Nữ  

                case 9:  //Sep
                    if (day < 23)
                        return "Virgo";   //Xử Nữ     
                    return "Libra";       //Thiên Bình  

                case 10:  //Oct
                    if (day < 23)
                        return "Libra";   //Thiên Bình
                    return "Scorpio";     //Bọ Cạp   

                case 11:  //Nov
                    if (day < 22)
                        return "Scorpio"; //Bọ Cạp  
                    return "Sagittarius"; //Nhân Mã 

                case 12:  //Dec
                    if (day < 22)
                        return "Sagittarius";  //Nhân Mã
                    return "Capricorn";        //Ma Kết

                default: //Wrong month
                    return "HotGirl";
            }
        }


        /// <summary>
        /// This method converts/translates English zodiac sign to Vietnamese zodiac sign 
        /// </summary>
        /// <param name="zodiacEnglish">zodiac sign in English</param>
        /// <returns>The zodiac sign in Vietnamese</returns>
        public static string GetZodiacVietnamese(string zodiacEnglish)
        {
            switch (zodiacEnglish)
            {
                case "Capricorn":
                    return "Ma Kết";
                case "Aquarius":
                    return "Bảo Bình";
                case "Pisces":
                    return "Song Ngư";
                case "Aries":
                    return "Bạch Dương";
                case "Taurus":
                    return "Kim Ngưu";
                case "Gemini":
                    return "Song Tử";
                case "Cancer":
                    return "Cự Giải";
                case "Leo":
                    return "Sư Tử";
                case "Virgo":
                    return "Xử Nữ";
                case "Libra":
                    return "Thiên Bình";
                case "Scorpio":
                    return "Bọ Cạp";
                case "Sagittarius":
                    return "Nhân Mã";
                default:
                    return "Mỹ Tâm";  //one of my dream girls
            }
        }
        //public static string GetZodiacSign(int day, int month)
        //{
        //    switch (month)
        //    {
        //        case 1:
        //            if (day >= 20)
        //                return "Aquarius";
        //            else if (day <= 19)
        //                return "Capricorn";
        //            else
        //                return "Invalid date";
        //            break;
        //        case 2:
        //            if (day >= 19)
        //                return "Pisces";
        //            else if (day <= 18)
        //                return "Aquarius";
        //            else
        //                return "Invalid date";
        //            break;
        //        default:
        //            return "Invalid date";
        //            break;
        //        case 3:
        //            if (day >= 21)
        //                return "Aries";
        //            else if (day <= 20)
        //                return "Pisces";
        //            else
        //                return "Invalid date";
        //            break;
        //        case 4:
        //            if (day >= 20)
        //                return "Taurus";
        //            else if (day <= 19)
        //                return "Aries";
        //            else
        //                return "Invalid date";
        //            break;
        //        case 5:
        //            if (day >= 21)
        //                return "Gemini";
        //            else if (day <= 20)
        //                return "Taurus";
        //            else
        //                return "Invalid date";
        //            break;
        //        case 6:
        //            if (day >= 21)
        //                return "Cancer";
        //            else if (day <= 20)
        //                return "Gemini";
        //            else
        //                return "Invalid date";
        //            break;
        //        case 7:
        //            if (day >= 23)
        //                return "Leo";
        //            else if (day <= 22)
        //                return "Cancer";
        //            else
        //                return "Invalid date";
        //            break;
        //        case 8:
        //            if (day >= 23)
        //                return "Virgo";
        //            else if (day <= 22)
        //                return "Leo";
        //            else
        //                return "Invalid date";
        //            break;
        //        case 9:
        //            if (day >= 23)
        //                return "Libra";
        //            else if (day <= 22)
        //                return "Virgo";
        //            else
        //                return "Invalid date";
        //            break;
        //        case 10:
        //            if (day >= 23)
        //                return "Scorpio";
        //            else if (day <= 22)
        //                return "Libra";
        //            else
        //                return "Invalid date";
        //            break;
        //        case 11:
        //            if (day >= 22)
        //                return "Sagittarius";
        //            else if (day <= 21)
        //                return "Scorpio";
        //            else
        //                return "Invalid date";
        //            break;
        //        case 12:
        //            if (day >= 22)
        //                return "Capricorn";
        //            else if (day <= 21)
        //                return "Sagittarius";
        //            else
        //                return "Invalid date";
        //            break;

        //    }
        //}
    }
}
