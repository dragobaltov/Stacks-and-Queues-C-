using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSequenceWithwholeQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            var wholeQueue = new Queue<long>();
            var secondQueue = new Queue<long>();
            wholeQueue.Enqueue(n);
            secondQueue.Enqueue(n);

            while (true)
            {
                wholeQueue.Enqueue(secondQueue.First() + 1);
                secondQueue.Enqueue(secondQueue.First() + 1);

                if (wholeQueue.Count >= 50)
                    break;

                wholeQueue.Enqueue(2 * secondQueue.First() + 1);
                secondQueue.Enqueue(2 * secondQueue.First() + 1);

                wholeQueue.Enqueue(secondQueue.First() + 2);
                secondQueue.Enqueue(secondQueue.First() + 2);

                secondQueue.Dequeue();
            }

            Console.WriteLine(string.Join(" ", wholeQueue));
        }
    }
}
