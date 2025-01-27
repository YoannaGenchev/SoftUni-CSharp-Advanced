namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>();
            foreach (string s in songs)
            {
                queue.Enqueue(s);
            }
            string command;
            while(queue.Any())
            {
                command = Console.ReadLine();
                if (command.StartsWith("Add"))
                {
                    string songName = command.Substring(4);
                    if (!queue.Contains(songName))
                    {
                        queue.Enqueue(songName);
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }    
                }
                else
                {
                    switch (command)
                    {
                        case "Play":
                            {
                                queue.Dequeue();
                                break;
                            }
                        case "Show":
                            {
                                Console.WriteLine(string.Join(", ", queue.ToArray()));
                                break;
                            }
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
