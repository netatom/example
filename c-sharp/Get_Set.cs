using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class BirthdayInfo
    {
        private string name; //public 아니라 private 이므로 아래 get이나 set이 필요하다
        private DateTime birthday;
    
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
                // 내장클래스는 F12를 눌러서 내용을 확인 할수 있다
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // 프로퍼티 get, set을 주의하여 보자
            BirthdayInfo birth = new BirthdayInfo();

            birth.Name = "HongGil Dong"; //set
            birth.Birthday = new DateTime(2017); //set

            Console.WriteLine("Name: {0}", birth.Name); //get
            Console.WriteLine("Birthday: {0}", birth.Birthday); //get
            Console.WriteLine("Age: {0}", birth.Age); //get
        }
    }
}
