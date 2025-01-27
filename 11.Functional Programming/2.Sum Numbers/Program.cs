namespace _2.Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);
            int[] input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();
            Console.WriteLine(input.Length);
            Console.WriteLine(input.Sum());
        }
    }
}
