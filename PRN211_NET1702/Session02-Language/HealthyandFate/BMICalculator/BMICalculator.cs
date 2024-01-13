using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi 
{
    public class BMICalculator
    {
        // một class khi tạo ra là để Internal, che giấu không cho
        // Xuất hiện bên ngoài namespace | Thư mục | Căn phòng nó đang đóng 
        // không gõ Internal được gọi là Default, giấu luôn 
        // Vậy nếu muốn Public class vượt ra khỏi căn phòng, vượt ra khỏi namespace, ta gõ public 
        // Che giấu, mở ra , được gọi chung là Encapsulation
        // Và public/private/protected/default - không gõ từ khóa / internal 
        // được gọi chung là : Accessor, Accessor Modifier, Access Specifier.

        public static double GetBMI(double weight, double height) => weight / (height * height); // Kiểu viết theo kiểu Expression Body 

        public static string EvaluateWeightStatus(double bmi)
        {
            if (bmi < 18.5)
                return "You are underweight.";
            if (bmi < 25)
                return "You have a normal weight.";
            if (bmi < 30)
                return "You are overweight.";
            if (bmi < 35)
                return "You have Class I obesity.";


            return "Obese !!";
        }
    }
}
