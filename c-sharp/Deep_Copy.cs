using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Myclass
    {
        public int su1;
        public int su2;

        public Myclass Deepcopy()
        {
            Myclass newCopy = new Myclass();
            newCopy.su1 = this.su1;
            newCopy.su2 = this.su2;

            return newCopy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("normal copy");
            {
                Myclass field = new Myclass();
                field.su1 = 10;
                field.su2 = 20;

                Myclass target = field;
                target.su2 = 30;

                Console.WriteLine("{0} {1}", field.su1, field.su2);
                Console.WriteLine("{0} {1}", target.su1, target.su2);
            }
            Console.WriteLine("deep copy");
            {
                Myclass field = new Myclass();
                field.su1 = 10;
                field.su2 = 20;

                Myclass target2 = field.Deepcopy(); // field 객체의 deepcopy메소드를 호출
                target2.su2 = 30;

                Console.WriteLine("{0} {1}", field.su1, field.su2);
                Console.WriteLine("{0} {1}", target2.su1, target2.su2);
            }
        }
    }
}
