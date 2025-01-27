namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                                                   .Select(int.Parse)
                                                   .ToList();
            int[] sorted = numbers.OrderByDescending(x => x).ToArray();

            int length = 3;
            if (sorted.Length < 3)
            {
                length = sorted.Length;
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write($"{sorted[i]} ");
            }
        }
    }
}
