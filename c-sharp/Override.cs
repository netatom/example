using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class FirstClass
    {
        public virtual void start()
        {
            Console.WriteLine("부모클래스의 메소드로서 virtual을 포함한다 ");
        }
    }

    class SecondClass : FirstClass
    {
        public override void start()
        {
            base.start(); // 부모클래스의 start()메소드를 호출한다.
            Console.WriteLine("자식 클래스로서 부모클래스를 상속받아 재정의 한다");
        }
    }

    class ThirdClass : FirstClass
    {
        public override void start()
        {
            base.start(); // 부모클래스의 start()메소드를 호출한다.
            Console.WriteLine("자식 클래스로서 부모클래스를 상속받아 재정의 한다2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("init");
            FirstClass firstclass = new FirstClass();
            firstclass.start();

            Console.WriteLine("second");
            SecondClass secondclass = new SecondClass();
            secondclass.start();

            Console.WriteLine("third");
            ThirdClass thirdclass = new ThirdClass();
            thirdclass.start();
        }
    }
}
