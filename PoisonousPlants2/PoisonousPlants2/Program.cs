using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PoisonousPlants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] daysOfDeath = new int[n];
            var previousPlants = new Stack<int>();
            previousPlants.Push(0);

            for (int i = 1; i < plants.Length; i++)
            {
                int lastDay = 0;

                while (previousPlants.Count > 0 && plants[previousPlants.Peek()] >= plants[i])
                {
                    lastDay = Math.Max(lastDay, daysOfDeath[previousPlants.Pop()]);
                }

                if (previousPlants.Count > 0)
                {
                    daysOfDeath[i] = lastDay + 1;
                }

                previousPlants.Push(i);
            }

            Console.WriteLine(daysOfDeath.Max());
        }
    }
}