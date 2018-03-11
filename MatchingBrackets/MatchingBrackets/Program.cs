using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var openBracketsIndexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openBracketsIndexes.Push(i);
                }
                else if(input[i] == ')')
                {
                    int currentStartIndex = openBracketsIndexes.Pop();

                    Console.WriteLine(input.Substring(currentStartIndex, i - currentStartIndex + 1));
                }
            }
        }
    }
}
