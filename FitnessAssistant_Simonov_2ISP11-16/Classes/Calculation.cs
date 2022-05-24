using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant_Simonov_2ISP11_16.Classes
{
    public static class Calculation
    {

        public static string BMI(double weight, double height)
        {
            double n = weight / (Math.Pow((height / 100), 2));
            if (n <= 16)
            {
                return Math.Round(n).ToString() + "Выражение дефицит массы тела";
            }
            else if (n > 16 && n <= 18.5)
            {
                return Math.Round(n).ToString() + "Выражение дефицит массы тела";
            }
            else if (n > 18.5 && n <= 25)
            {
                return Math.Round(n).ToString() + "Выражение дефицит массы тела";
            }
            else if (n > 25 && n <= 30)
            {
                return Math.Round(n).ToString() + "Выражение дефицит массы тела";
            }
            else if (n > 30 && n <= 35)
            {
                return Math.Round(n).ToString() + "Выражение дефицит массы тела";
            }
            else if (n > 35 && n <= 40)
            {
                return Math.Round(n).ToString() + "Выражение дефицит массы тела";
            }
            else if (n > 40)
            {
                return Math.Round(n).ToString() + "Выражение дефицит массы тела";
            }
            else
            {
                return "Ошибка!";
            }

        }

        public static double BMR(bool gender)
        {
            double w = 0;
            double h = 0;
            double g = 0;
            double n = 0;

            if (gender)
            {
                n = 66.5 + (13.7 * w) + (5 * h) - (6.9 * g); 
            }
            else
            {
                n = 655 + (9.6 * w) + (1.8 * h) - (4.7 * g);
            }
            return n;
        }
    }
}
