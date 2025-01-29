namespace _8._List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Predicate<int>> predicate = new();

            int end = int.Parse(Console.ReadLine());

            HashSet<int> divide = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            int[] num = Enumerable.Range(1, end).ToArray();

            foreach (var divider in divide)
            {
                predicate.Add(p => p % divider == 0);
            }

            foreach (var number in num)
            {
                bool isDivisible = true;

                foreach (var match in predicate)
                {
                    if (!match(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
