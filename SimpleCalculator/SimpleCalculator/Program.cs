using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var stack = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 1)
            {
                int leftOperand = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int rightOperand = int.Parse(stack.Pop());

                if (operation == "+")
                {
                    stack.Push((leftOperand + rightOperand).ToString());
                }
                else
                {
                    stack.Push((leftOperand - rightOperand).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
