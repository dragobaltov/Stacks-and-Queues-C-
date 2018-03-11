using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>(Console.ReadLine().Split(' '));
            int nthToss = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i <= nthToss; i++)
                {
                    if (i == nthToss)
                    {
                        Console.WriteLine("Removed " + queue.Dequeue());
                    }
                    else
                    {
                        queue.Enqueue(queue.Dequeue());
                    }
                }
            }

            Console.WriteLine("Last is " + queue.Dequeue());
        }
    }
}
