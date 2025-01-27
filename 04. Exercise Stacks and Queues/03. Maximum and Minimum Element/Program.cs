namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            string command;
            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                if (command.StartsWith('1'))
                {
                    string[] commandArgs = command.Split();
                    stack.Push(int.Parse(commandArgs[1]));
                }
                else if(stack.Any())
                {
                    switch(command)
                    {
                        case "2":
                            {
                                stack.Pop();
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine(stack.Max());
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine(stack.Min());
                                break;
                            }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack.ToArray()));
        }
    }
}
