namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool invalidResult = false;
            foreach (char c in input)
            {
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        {
                            stack.Push(c);
                            break;
                        }
                    case ')':
                        {
                            if (stack.Count > 0 && stack.Peek() == '(')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                invalidResult = true;
                            }
                            break;
                        }
                    case ']':
                        {
                            if (stack.Count > 0 && stack.Peek() == '[')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                invalidResult = true;
                            }
                            break;
                        }
                    case '}':
                        {
                            if (stack.Count > 0 && stack.Peek() == '{')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                invalidResult = true;
                            }
                            break;
                        }
                }

                if (invalidResult)
                {
                    break;
                }
            }

            if (!invalidResult && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
