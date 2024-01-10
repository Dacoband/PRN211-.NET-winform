using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi 
{
    internal class BMICalculator
    {
        public static double GetBMI(double weight, double height) => weight / (height * height);
    }
}
