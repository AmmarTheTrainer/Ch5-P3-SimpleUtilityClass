using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using static System.Console;
//using static System.DateTime;

namespace Ch5_P3_SimpleUtilityClass
{
    static class TimeUtilClass
    {
        //public static void PrintTime() => WriteLine(Now.ToShortTimeString());
        //public static void PrintDate() => WriteLine(Today.ToShortDateString());

        public static void PrintTime() => Console.WriteLine(DateTime.Now.ToShortTimeString());
        public static void PrintDate() => Console.WriteLine(DateTime.Today.ToShortDateString());
    }
}
