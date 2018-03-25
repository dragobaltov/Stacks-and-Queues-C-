using System;
using System.Collections;
using System.Collections.Generic;

namespace StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();

            stack.Push(0);
            stack.Push(1);

            for (int i = 2; i <= n; i++)
            {
                long firstNum = stack.Pop();
                long secondNum = stack.Pop();
                stack.Push(firstNum);
                stack.Push(firstNum + secondNum);
            }

            Console.WriteLine(stack.Peek());
        }
    }
}