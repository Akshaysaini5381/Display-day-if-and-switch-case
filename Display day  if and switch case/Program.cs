using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_day__if_and_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day number :");
            int day = int.Parse(Console.ReadLine());
            /*   string result;


               if (day == 1)
                   // result = "Monday";
                   Console.WriteLine("Monday");
               else if (day == 2)
                   // result = "Tuesday";
                   Console.WriteLine("Tuesday");
               else if (day == 3)
                   // result = "Wednesday";
                   Console.WriteLine("Wednesday");
               else if (day == 4)
                   // result = "Thursday";
                   Console.WriteLine("Thursday");
               else if (day == 5)
                   // result = "Friday";
                   Console.WriteLine("Friday");
               else if (day == 6)
                   // result = "Saturday";
                   Console.WriteLine("Saturday");
               else if (day == 7)
                   //  result = "Sunday";
                   Console.WriteLine("Sunday");

               else
                   Console.WriteLine(" not found result :");*/

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not found result");
                    break;

            }
            // Outputs "Thursday" (day 4)




            Console.ReadLine();

        }
    }
}
