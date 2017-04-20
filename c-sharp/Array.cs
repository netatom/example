using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            // scores라는 배열을 5개 사이즈로 선언하자
            int[] scores = new int[5];
            scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            scores[3] = 40;
            scores[4] = 50;

            // 배열의 값을 foreach를 사용해서 show에 값을 넣은 뒤 표출해보자
            foreach (int show in scores)
                Console.WriteLine(show);

            // 배열의 총합을 구해보자
            int sum = 0;
            foreach (int hap in scores)
                sum += hap;

            int average = sum / scores.Length;

            Console.WriteLine("평균값 {0}", average);

        }
    }
}
