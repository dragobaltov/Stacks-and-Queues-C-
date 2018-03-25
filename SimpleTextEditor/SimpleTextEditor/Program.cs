using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var previousTexts = new Stack<string>();
            StringBuilder text = new StringBuilder();
            previousTexts.Push("");

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int command = int.Parse(tokens[0]);

                switch (command)
                {
                    case 1:
                        text.Append(tokens[1]);
                        previousTexts.Push(text.ToString());
                        break;
                    case 2:
                        int count = int.Parse(tokens[1]);

                        if (count > 0)
                        {
                            int length = Math.Min(count, text.Length);
                            text = text.Remove(text.Length - length, length);
                            previousTexts.Push(text.ToString());
                        }
                        break;
                    case 3:
                        int index = int.Parse(tokens[1]) - 1;

                        if (index >= 0 && index < text.Length)
                        {
                            Console.WriteLine(text.ToString()[index]);
                        }
                        break;
                    case 4:
                        if (previousTexts.Count > 0)
                        {
                            previousTexts.Pop();
                            text = new StringBuilder(previousTexts.Peek());
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}