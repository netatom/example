using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // hashtable을 사용하기 위해 추가해줘야한다

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["1"] = "one"; // 왼쪽 키 오른쪽 값
            ht["2"] = "two"; // 왼쪽 키 오른쪽 값
            ht["3"] = "three"; // 왼쪽 키 오른쪽 값
            ht["4"] = "four"; // 왼쪽 키 오른쪽 값
            ht["5"] = "five"; // 왼쪽 키 오른쪽 값

            Console.WriteLine(ht["1"]);
            Console.WriteLine(ht["2"]);
            Console.WriteLine(ht["3"]);
            Console.WriteLine(ht["4"]);
            Console.WriteLine(ht["5"]);
        }
    }
}

