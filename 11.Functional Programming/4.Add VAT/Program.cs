namespace _4.Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n * 1.2)
                .ToArray();

            foreach (var pr in prices)
            {
                Console.WriteLine($"{pr:F2}");
            }
        }
    }
}
