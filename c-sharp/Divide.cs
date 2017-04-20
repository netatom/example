using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Divide(int a, int b, out int q, out int r)
        {
            q = a / b;
            r = a % b;
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            int c;
            int d;

            Divide(a, b, out c, out d);

            Console.WriteLine("a:{0}, b{1}, a/b:{2}, a%b:{3}", a, b, c, d);
        }
    }
}

