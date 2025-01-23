﻿namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();
            for (int i = arguments.Length - 1; i >= 0; i--)
            {
                stack.Push(arguments[i]);
            }

            int result = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                string operation = stack.Pop();
                int number = int.Parse(stack.Pop());
                if (operation == "+")
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}
