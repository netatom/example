using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
        public class rectangle
        {
            public int get_su;
            public int get_su2;

            // 정의를 안하면 컴파일러가 알아서 생성 시작 //생성자1
            public rectangle()
            {
                string get_su = "zero";
                Console.WriteLine("매개변수는{0} 즉 점이다.",get_su);
            }
            // 정의를 안하면 컴파일러가 알아서 생성 끝

            public rectangle(int su) //생성자2
            { 
                    get_su = su;
                    Console.WriteLine("rect은 정사각형이다.");
             }
            public rectangle(int su, int su2) //생성자3
            {
                get_su = su;
                get_su2 = su2;
                if (get_su==get_su2) {
                    Console.WriteLine("rect은 정사각형이다.");
                }
                else
                {
                    Console.WriteLine("rect은 정사각형이 아니다.");
                }
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            rectangle rect1 = new rectangle();
            rectangle rect2 = new rectangle(1,2);
            rectangle rect3 = new rectangle(3);
            rectangle rect4 = new rectangle(4,4);
            rectangle rect5 = new rectangle(5,6);
        }
    }
}
