namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            var command = Console.ReadLine();
            while (command != "END")
            {
                command = command.Replace(",", "");
                var commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (commandArgs[0])
                {
                    case "Push":
                        {
                            for (int i = 1; i < commandArgs.Length; i++)
                            {
                                stack.Push(int.Parse(commandArgs[i]));
                            }
                            break;
                        }
                    case "Pop":
                        {
                            try
                            {
                                stack.Pop();
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                }

                command = Console.ReadLine();
            }

            foreach (var elem  in stack)
            {
                Console.WriteLine(elem.ToString());
            }

            foreach (var elem in stack)
            {
                Console.WriteLine(elem.ToString());
            }
        }
    }
}
