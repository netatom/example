using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input the day: ");
            string day = Console.ReadLine();

            switch(day)
            {
                case "sun":
                    Console.WriteLine("sunday");
                    break;
                case "mon":
                    Console.WriteLine("monday");
                    break;
                case "tue":
                    Console.WriteLine("tuesday");
                    break;
                case "wed":
                    Console.WriteLine("wednesday");
                    break;
                case "thu":
                    Console.WriteLine("thrusday");
                    break;
                case "fri":
                    Console.WriteLine("friday");
                    break;
                case "sat":
                    Console.WriteLine("saturday");
                    break;
                default:
                    Console.WriteLine("not the day");
                    break;
            }
        }
    }
}
