using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>(input);

            foreach (var symbol in stack)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
