using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Beast
    {
        public void Live()
        {
            Console.WriteLine("Live 메소드");
        }
    }

    class Dog : Beast
    {
        public void Bark()
        {
            Console.WriteLine("Bark 메소드");
        }
    }

    class Cat : Beast
    {
        public void Jump()
        {
            Console.WriteLine("Jump 메소드");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beast beast = new Dog();
            Dog dog = new Dog();
                if(beast is Dog) //is는 객체가 해당 형식에 해당하는 검사 같은면 true 아니면 false
                {
                    dog = (Dog)beast; //형식 변환
                    dog.Bark();
                    Console.WriteLine("true 실행");
                }

            Beast beast2 = new Cat();
            Cat cat = beast2 as Cat; // 형식변환 연산자와 같은 역할로서 실패할 경우 null로 만든다.
                if (cat != null)
                {
                    cat.Jump();
                    Console.WriteLine("true 실행");
                }

            Cat cat2 = beast as Cat; // as 형식변환 연산자와 같은 역할, 실패할 경우 객체참조가 null이 된다.
                if (cat2 != null)
                {
                    cat2.Jump();
                    Console.WriteLine("true 실행");
                }else{
                    Console.WriteLine("cat2 는 cat이 아니다");
                    Console.WriteLine("false 실행");
                }
        }
    }
}