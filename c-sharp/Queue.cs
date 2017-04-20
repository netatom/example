using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //collections 클래스를 추가해줘야 한다

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            // 선입선출(FIFO)을 위한 queue를 사용하자
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0)
                Console.WriteLine(que.Dequeue());

        }
    }
}
