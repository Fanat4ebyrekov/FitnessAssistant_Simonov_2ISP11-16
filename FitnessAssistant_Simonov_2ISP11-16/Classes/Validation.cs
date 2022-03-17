using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessAssistant_Simonov_2ISP11_16.Classes;

namespace FitnessAssistant_Simonov_2ISP11_16.Classes
{
    public class Validation
    {

        public static bool ValidationPassword(string password)
        {
            if (password.Length < 8 || password.Length > 20)
                return false;
            if (!password.Any(char.IsDigit))
                return false;
            if (!password.Any(char.IsLower))
                return false;
            if(!password.Any(char.IsUpper))
                return false;
            if (password.Intersect("!@#$%^&*()_-+№;:?").Count()==0)
                return false;

            return true;

        }

        public static bool ValidationLName(string LName)
        {
            if (LName.Intersect("-").Count() == 0)
                return false;
            if (!LName.Any(char.IsLower))
                return false;
            if (!LName.Any(char.IsUpper))
                return false;

            return true;
        }

        public static bool ValidationFName(string FName)
        {
            if (FName.Intersect("-").Count() == 0)
                return false;
            if (!FName.Any(char.IsLower))
                return false;
            if (!FName.Any(char.IsUpper))
                return false;

            return true;
        }

        public static bool ValidationHeight(string Height)
        {
            char[] str2 = Height.Where(i => Char.IsDigit(i)).ToArray();
            if (str2.Length != 0 && Int32.Parse(Height) > 0 && Int32.Parse(Height) <= 300)
                return true;

            else
                return false;
           
        }

        public static bool ValidationVes(string Weght)
        {
            char[] str2 = Weght.Where(i => Char.IsDigit(i)).ToArray();
            if (str2.Length != 0 && Int32.Parse(Weght) > 0 && Int32.Parse(Weght) <= 300)
                return true;

            else
                return false;

        }

        public static bool ValidationBirthday(DateTime Birthday)
        {


            if (Birthday.Date < DateTime.Now.Date)
                return true;
            else
                return true;
        }

        //public static bool ValidationLogin(string str)
        //{
        //    Entites context = new Entites();



        //    return true;

        //}



    }
}
