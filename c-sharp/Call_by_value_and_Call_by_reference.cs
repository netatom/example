using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void swap2(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine("x:{0}, y:{1}", x, y);

            swap(x, y);
            Console.WriteLine("x:{0}, y:{1}", x, y);

            int x2 = 3;
            int y2 = 4;
            Console.WriteLine("x:{0}, y:{1}", x2, y2);

            swap2(ref x2, ref y2);

            Console.WriteLine("x:{0}, y:{1}", x2, y2);
        }
    }
}