namespace _1.Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
