namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();

            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}
