using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    // delegate를 사용하기 위해서는 선언을 먼저 해야한다
    delegate int MyDelegate(int a, int b); // 참조할 반환형식이 int이다

    class Calculator
    {
        public int plus(int a, int b)
        {
            return a + b;
        }

        public int minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback; // 델리게이트 객체 생성

            Callback = new MyDelegate(Calc.plus);  //델리게이트 인스턴스를 생성
            Console.WriteLine("델리게이트 호출: "+Callback(3, 4));

            Callback = new MyDelegate(Calc.minus); //델리게이트 인스턴스를 생성
            Console.WriteLine("델리게이트 호출: " + Callback(4, 3));
        }
    }
}
