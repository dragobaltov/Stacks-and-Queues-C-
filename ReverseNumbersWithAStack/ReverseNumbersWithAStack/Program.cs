using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbersWithAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(input);

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
