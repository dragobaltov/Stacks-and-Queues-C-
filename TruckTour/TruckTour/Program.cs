using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var petrolStations = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int diff = tokens[0] - tokens[1];
                petrolStations.Enqueue(diff);
            }

            var copy = new Queue<int>(petrolStations);

            for (int i = 0; i < n; i++)
            {
                int currentFuel = 0;
                bool isSolution = true;

                for (int j = 0; j < n; j++)
                {
                    int currentDiff = petrolStations.Dequeue();
                    petrolStations.Enqueue(currentDiff);

                    currentFuel += currentDiff;

                    if (currentFuel < 0)
                    {
                        isSolution = false;
                        break;
                    }
                }

                if (isSolution)
                {
                    Console.WriteLine(i);
                    break;
                }

                copy.Enqueue(copy.Dequeue());
                petrolStations = new Queue<int>(copy);
            }
        }
    }
}
