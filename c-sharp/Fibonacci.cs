using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static int fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return fibonacci(n - 1) + fibonacci(n - 2);
        }
        static void printprofile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("input the name");
                return;
            }

            Console.WriteLine("name:{0}, phone:{1}", name, phone);
        }
        static void Main(string[] args)
        {
            printprofile("", "000-000-0000");
            printprofile("sung", "111-111-1111");

            Console.WriteLine("10 fiboncci number: {0}", fibonacci(10));
        }
    }
}

