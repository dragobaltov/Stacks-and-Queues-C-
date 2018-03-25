using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxStack = new Stack<int>();
            int maxNum = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input[0] == '1')
                {
                    int number = int.Parse(input.Substring(2));
                    stack.Push(number);

                    if(number > maxNum)
                    {
                        maxNum = number;
                        maxStack.Push(maxNum);
                    }
                }
                else if (input[0] == '2')
                {
                    if (stack.Count > 0)
                    {
                        int deletedElement = stack.Pop();

                        if (deletedElement == maxStack.Peek())
                        {
                            maxStack.Pop();

                            if (maxStack.Count == 0)
                                maxNum = 0;
                            else
                                maxNum = maxStack.Peek();
                        }
                    }
                        
                }
                else
                {
                    if (stack.Count > 0)
                        Console.WriteLine(maxStack.Peek());
                }
            }
        }
    }
}
