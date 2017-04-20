using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("continue? yes/no ");
                string answer = Console.ReadLine();

                if (answer == "no")
                    break;
            }
        }
    }
}
