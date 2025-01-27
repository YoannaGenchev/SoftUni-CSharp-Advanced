namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();
            while (command != "Revision")
            {
                string[] commandArgs = command.Split(", ");
                string shop = commandArgs[0];
                string product = commandArgs[1];
                double price = double.Parse(commandArgs[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }

                shops[shop].Add(product, price);

                command = Console.ReadLine();
            }

            var orderedShop = shops.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shop in orderedShop)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var pair in shop.Value)
                {
                    Console.WriteLine($"Product: {pair.Key}, Price: {pair.Value}");
                }
            }
        }
    }
}
