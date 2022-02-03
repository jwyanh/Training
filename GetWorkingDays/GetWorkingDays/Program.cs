using System;

namespace ConvertDate_Jiewen
{
    class Program
    {
        public static void Main(string[] args)
        {
            Method methodExample = new Method();
            
            string[] Num = methodExample.InputDate();

            DateTime dateTime1 = DateTime.Parse(Num[0]);
            DateTime dateTime2 = DateTime.Parse(Num[1]);
            TimeSpan diff1 = dateTime2.Subtract(dateTime1);

            //Tring to implement DateTimeExtension To get the working days directly
            //Otherwise, not sure the clear idea of get the holliday since it only specifies the date for a single year

            Console.WriteLine(diff1.ToString("%d"));

        }
    }
}