using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var carsQueue = new Queue<string>();
            int totalPassedCars = 0;

            while (!input.Equals("end"))
            {
                if (input == "green")
                {
                    int count = Math.Min(carsToPass, carsQueue.Count);
                    totalPassedCars += count;

                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(carsQueue.Dequeue() + " passed!");
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{totalPassedCars} cars passed the crossroads.");
        }
    }
}
