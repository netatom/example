using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static int plus(int a, int b)
        {
            Console.WriteLine("calling int int");
            return a + b;
        }
        static int plus(int a, int b, int c)
        {
            Console.WriteLine("calling int int int");
            return a + b + c;
        }
        static double plus(double a, double b)
        {
            Console.WriteLine("calling double double");
            return a + b;
        }
        static double plus(int a, double b)
        {
            Console.WriteLine("calling int double");
            return a + b;
        }
        static void Main(string[] args)
        {
            //메소드 오버로딩
            Console.WriteLine(plus(1, 2));
            Console.WriteLine(plus(1, 2, 3));
            Console.WriteLine(plus(5.0, 2.5));
            Console.WriteLine(plus(5, 3.5));
        }
    }
}

