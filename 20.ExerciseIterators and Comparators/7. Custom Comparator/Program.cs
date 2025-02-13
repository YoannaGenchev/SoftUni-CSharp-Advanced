namespace CustomComparator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
            Array.Sort(nums, new CustomComparator());
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
