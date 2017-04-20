using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    // 추상 클래스는 인터페이스와 달리 구현을 가질수 있다 즉 인터페이스와 차이는 구현을 갖고 안갖고 차이
    abstract class AbstractBase
    {
        protected void PrivateMethod1()
        {
            Console.WriteLine("추상클래스(abstract) 그리고 private 메소드");
        }

        public void PublicMethod1()
        {
            Console.WriteLine("추상클래스(abstract) 그리고 public 메소드");
        }

        public abstract void AbstractMethod1();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethod1()
        {
            Console.WriteLine("서브 클래스");
            PrivateMethod1();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethod1();
            obj.PublicMethod1();
        }
    }
}