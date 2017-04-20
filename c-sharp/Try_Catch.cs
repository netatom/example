using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            try
            {
                for (int i=0; i<5; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (IndexOutOfRangeException happen)
            {
                Console.WriteLine("예외가 발생했습니다:{0}", happen.Message);
            }

            Console.WriteLine("exit");
        }
    }
}
