namespace _4._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            Predicate<int> predicate;
            if (command == "even") predicate = x => x % 2 == 0;
            else if (command == "odd") predicate = x => x % 2 != 0;
            else predicate = x => false;

            List<int> numbers = new List<int>();
            for (int i = input[0]; i <= input[1]; i++)
            {
                if (predicate(i)) numbers.Add(i);
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
