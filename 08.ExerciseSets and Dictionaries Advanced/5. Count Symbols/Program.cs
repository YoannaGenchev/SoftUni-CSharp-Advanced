namespace _5._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> sym = new Dictionary<char, int>();
            foreach (char symbol in text)
            {
                if (!sym.ContainsKey(symbol)) sym[symbol] = 0;
                sym[symbol]++;
            }

            foreach (var (symbol, count) in sym.OrderBy(x => x.Key))
                Console.WriteLine($"{symbol}: {count} time/s");
        }
    }
}
