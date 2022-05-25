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
           
            double n = weight / (height * height);

            
            if (n <= 16)
            {
                return "Выражение дефицит массы тела";
            }
            else if (n > 16 && n <= 18.5)
            {
                return "Недостаточная масса тела";
            }
            else if (n > 18.5 && n <= 25)
            {
                return "Нормальная масса тела";
            }
            else if (n > 25 && n <= 30)
            {
                return "Избыточная масса тела";
            }
            else if (n > 30 && n <= 35)
            {
                return "Ожирение I степени";
            }
            else if (n > 35 && n <= 40)
            {
                return "Ожирение II степени";
            }
            else if (n > 40)
            {
                return "Ожирение III степени";
            }
            else
            {
                return "Ошибка";
            }

        }

        public static string BMR(int age, double w, double h, string g)
        {
            double n = 0;


            try
            {
                if ((age != 0) && (w != 0) && (h != 0))
                {
                    if (g == "Муж")
                    {
                        n = 66.5 + (13.7 * w) + (5 * h) - (6.9 * age);
                    }
                    else
                    {
                        n = 65.5 + (9.6 * w) + (1.8 * h) - (4.7 * age);
                    }

                    return Convert.ToString(n);
                }
                else
                {
                    return "Ошибка";
                }

            }
            catch
            {
                return "Ошибка";
            }
        }
    }
}
