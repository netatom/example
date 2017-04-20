using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int input_number = Convert.ToInt32(input);
            int exit_number = 0;

            for (int i=0; i<2; i++)
            {
                for(int j=0; j<2; j++)
                {
                    for (int k= 0; k<3; k++)
                    {
                        if (exit_number++ == input_number)
                            goto EXIT_FOR;

                        Console.WriteLine(exit_number);
                    }
                }
            }
            goto EXIT_PROGRAM;

        EXIT_FOR:
            Console.WriteLine("exit");

        EXIT_PROGRAM:
            Console.WriteLine("exit2");
        }
    }
}
