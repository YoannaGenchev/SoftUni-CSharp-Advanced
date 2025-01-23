namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            string command = null;
            while(command != "end")
            {
                command = Console.ReadLine().ToLower();
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commandArgs[0] == "add")
                {
                    numbers.Push(int.Parse(commandArgs[1]));
                    numbers.Push(int.Parse(commandArgs[2]));

                }
                else if (commandArgs[0] == "remove")
                {
                    int count = int.Parse(commandArgs[1]);
                    if (count <= numbers.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
