using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Employee
    {
        private string name;
        private string position;

        public void setname(string name)
        {
            this.name = name; // 오른쪽 변수는 매개변수
        }
        public string getname()
        {
            return this.name;
        }

        public void setposition(string position)
        {
            this.position = position; // 오른쪽 변수는 매개변수
        }
        public string getposition()
        {
            return this.position; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee lion = new Employee();
            lion.setname("lion");
            lion.setposition("king of jungle");
            Console.WriteLine("{0}:{1}", lion.getname(), lion.getposition());

            Employee tiger = new Employee();
            tiger.setname("tiger");
            tiger.setposition("king of forest");
            Console.WriteLine("{0}:{1}", tiger.getname(), tiger.getposition());
        }
    }
}
