using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project.Const
{
    public class ErrorMessages
    {
        public static string AnimalNameExceptionMessage(string title)
        {
            return $"{title} , minimum 2 karakterli olmalıdır girdiğiniz karakter sayısı : {title.Length}";
        }

        public static string NegativeValueExceptionMessage(int val)
        {
            return $"Girdiğiniz veri bilgisi negatif değerler olamaz. Değer : {val}";
        }

        public static string NegativeValueExceptionMessage(decimal val)
        {
            return $"Girdiğiniz veri bilgisi negatif değerler olamaz. Değer : {val}";
        }

        public static string KeeperNameExceptionMessage(string keeperName)
        {
            return $"{keeperName} , minimum 2 karakterli olmalıdır girdiğiniz karakter sayısı : {keeperName.Length}";
        }
    }
}
