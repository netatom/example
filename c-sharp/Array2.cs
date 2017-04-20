using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2차원 배열을 선언하고 첫번째 행의 0번째 열의 값을 지워보자
            int[,] array = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Array.Clear(array, 0, 1);

            for (int i=0; i<array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("[{0},{1}]:{2}", i,j,array[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 2차원 배열을 선언하고 첫번째 행의 2,3번째 열의 값을 지워보자
            int[,] array2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            Array.Clear(array2, 1, 2);

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write("[{0},{1}]:{2}", i, j, array2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 2차원 배열을 선언하고 두번째 행의 1,2,3번째 열의 값을 지워보자
            int[,] array3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Array.Clear(array3, 3, 3);

            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.Write("[{0},{1}]:{2}", i, j, array3[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
