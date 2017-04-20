using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    delegate void Notify(string message); // 델리게이트 선언

    class Notify_class // 델리게이트 인스턴스
    {
        public Notify EventOccured;
    }

    class Event
    {
        private string name;
        public Event(string name)
        {
            this.name = name;
        }

        public void SomethingHappened(string message)
        {
            Console.WriteLine("{0}.somethinghappened! : {1}", name, message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notify_class notifier = new Notify_class();
            Event listener1 = new Event("call1");
            Event listener2 = new Event("call2");
            Event listener3 = new Event("call3");

            notifier.EventOccured += listener1.SomethingHappened;
            notifier.EventOccured += listener2.SomethingHappened;
            notifier.EventOccured += listener3.SomethingHappened;
            notifier.EventOccured("You have got call.");
            Console.WriteLine();

            notifier.EventOccured -= listener2.SomethingHappened;
            notifier.EventOccured("call2 delete complete.");
            Console.WriteLine();

        }
    }
}
