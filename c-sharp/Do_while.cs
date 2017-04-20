using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                Console.WriteLine("i: {0}", i--);
            }
            while (i > 0) ;

            do
            {
                Console.WriteLine("j: {0}", i++);
            }
            while (i < 11);


        }
    }
}
