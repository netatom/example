using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine("{0} : 고양이 호출", Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";

            kitty.Meow();
            Console.WriteLine("{0}, {1}", kitty.Name, kitty.Color);

            Cat nero = new Cat();
            nero.Color = "검정색";
            nero.Name = "네로";

            nero.Meow();
            Console.WriteLine("{0}, {1}", nero.Name, nero.Color);
        }
    }
}
