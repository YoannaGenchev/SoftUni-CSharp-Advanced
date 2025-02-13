namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var elems = new List<string>();
            for (int i = 1; i < commandArgs.Length; i++)
            {
                elems.Add(commandArgs[i]);
            }

            var iter = new ListyIterator<string>(elems);

            command = Console.ReadLine();
            while (command != "END")
            {
                switch (command)
                {
                    case "HasNext":
                        {
                            Console.WriteLine(iter.HasNext());
                            break;
                        }
                    case "Print":
                        {
                            try
                            {
                                iter.Print();
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case "Move":
                        {
                            Console.WriteLine(iter.Move());
                            break;
                        }
                }

                command = Console.ReadLine();
            }
        }
    }
}
