using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("<<< Value to Day Number >>>\n");
            Console.Write("Please enter a number from 1 - 7: ");
            Console.WriteLine("\nThat number corresponds to the day " + Day(int.Parse(Console.ReadLine())));
            Console.ReadLine();
        }

        static string Day(int num)
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            return days[num - 1];
        }
    }
}
