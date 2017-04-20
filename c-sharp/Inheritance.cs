using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("기본클래스 실행");
        }
    }

    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("상속클래스 실행");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
        }
    }
}
