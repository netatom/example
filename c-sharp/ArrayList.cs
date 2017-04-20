using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //ArrayList를 사용하려면 collections 클래스를 추가해줘야 한다

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            // arraylist를 선언하고 각행에 값을 추가하자
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (object obj in list)
                Console.Write("{0}", obj);
            Console.WriteLine();

            // 3번의 값을 제거하자
            list.Remove(2);

            foreach (object obj in list)
                Console.Write("{0}", obj);
            Console.WriteLine();

            // 3번의 값에 7를 넣어보자
            list.Insert(2, 7);

            foreach (object obj in list)
                Console.Write("{0}", obj);
            Console.WriteLine();

            // 문자를 넣어보자
            list.Add("first");
            list.Add("second");

            foreach (object obj in list)
                Console.Write("{0}", obj);
            Console.WriteLine();

        }
    }
}
