using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        // 일반화 메소드
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }

        static void Main(string[] args)
        {
            // int로 배열을 선언한뒤 메소드를 이용해보자
            int[] source = {1,2,3,4,5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target); //CopyArray 메소드<자료형>은 int
            foreach (int element in target)
                Console.WriteLine(element);

            // string으로 배열을 선언한뒤 메소드를 이용해보자
            string[] source2 = { "one", "two", "three", "four", "five" };
            string[] target2 = new string[source2.Length];

            CopyArray<string>(source2, target2); //CopyArray 메소드<자료형>은 string
            foreach (string element in target2)
                Console.WriteLine(element);
        }
    }
}
