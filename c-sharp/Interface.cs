using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    interface IRunnable
    {
        void Run();
        /*  인터페이스는 아래와 같이 멤버정의를 할수 없다
        private void Run()
        {
            Console.WriteLine("Run Run");
        }
        */
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable // 인터페이스를 다중상속 받아보자
    {
        public void Run()
        {
            Console.WriteLine("Run Run");
        }

        public void Fly()
        {
            Console.WriteLine("Fly Fly");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 클래스는 다중상속이 안되며 다중상속의 경우 인터페이스나 추상클래스를 이용하자
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();
            Console.WriteLine("------");

            IRunnable runnable = car as IRunnable; // as를 통해 업캐스팅 되나 안되나 해보자
            runnable.Run();

            IFlyable flyable = car as IFlyable; // as를 통해 업캐스팅을 되나 안되나 해보자
            flyable.Fly();
        }
    }
}
