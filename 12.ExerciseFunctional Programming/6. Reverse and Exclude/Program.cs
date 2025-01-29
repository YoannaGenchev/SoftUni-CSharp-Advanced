namespace _6._Reverse_and_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Func<int, int, bool> filter = (number, div)
                   => number % div == 0;

            int[] result = input
                .Where(x => !filter(x, n))
                .ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
