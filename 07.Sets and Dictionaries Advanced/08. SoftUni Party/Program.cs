namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> vips = new HashSet<string>();
            HashSet<string> regulars = new HashSet<string>();
            while (command != "PARTY")
            {
                if (char.IsDigit(command[0]))
                {
                    vips.Add(command);
                }
                else
                {
                    regulars.Add(command);
                }

                command = Console.ReadLine();
            }

            while (command != "END")
            {
                if (char.IsDigit(command[0]))
                {
                    vips.Remove(command);
                }
                else
                {
                    regulars.Remove(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(vips.Count + regulars.Count);
            if (vips.Count > 0)
            {
                Console.WriteLine(string.Join("\n", vips));
            }
            if (regulars.Count > 0)
            {
                Console.WriteLine(string.Join("\n", regulars));
            }
        }
    }
}
