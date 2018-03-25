using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numbersToPush = tokens[0];
            int numbersToPop = tokens[1];
            int numberToFind = tokens[2];
            var stack = new Stack<int>();

            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = Math.Min(numbersToPush, elements.Length);

            for (int i = 0; i < count; i++)
            {
                stack.Push(elements[i]);
            }

            count = Math.Min(numbersToPop, stack.Count);

            for (int i = 0; i < count; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stack.Contains(numberToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
