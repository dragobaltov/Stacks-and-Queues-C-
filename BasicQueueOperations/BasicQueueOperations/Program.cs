using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numbersToEnqueue = tokens[0];
            int numbersToDequeue = tokens[1];
            int numberToFind = tokens[2];
            var queue = new Queue<int>();

            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = Math.Min(elements.Length, numbersToEnqueue);

            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(elements[i]);
            }

            count = Math.Min(queue.Count, numbersToDequeue);

            for (int i = 0; i < count; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (queue.Contains(numberToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
