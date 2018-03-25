using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PoisonousPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> plants = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool change = true;
            int days = 0;

            while (change)
            {
                change = false;
                int previousPlant = plants[0];

                for (int i = 1; i < plants.Count; i++)
                {
                    if (plants[i] > previousPlant)
                    {
                        change = true;
                        previousPlant = plants[i];
                        plants.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        previousPlant = plants[i];
                    }
                }

                if (change)
                    days++;
            }

            Console.WriteLine(days);
        }
    }
}