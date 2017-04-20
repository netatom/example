using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            //후입선출(LIFO) stack
            Stack statck = new Stack(); 
            statck.Push(1);
            statck.Push(2);
            statck.Push(3);
            statck.Push(4);
            statck.Push(5);

            while (statck.Count > 0)
                Console.WriteLine(statck.Pop());
        }
    }
}
