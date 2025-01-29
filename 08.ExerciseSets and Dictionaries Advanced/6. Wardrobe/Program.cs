namespace _6._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> byColor = new();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];

                if (!byColor.ContainsKey(color))
                {
                    byColor[color] = new Dictionary<string, int>();
                }

                for (int j = 1; j < input.Length; j++)
                {
                    string currentClothing = input[j];

                    if (!byColor[color].ContainsKey(currentClothing))
                    {
                        byColor[color].Add(currentClothing, 0);
                    }

                    byColor[color][currentClothing]++;
                }
            }

            string[] findParam = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in byColor)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in color.Value)
                {
                    string printItem = $"* {cloth.Key} - {cloth.Value}";

                    if (color.Key == findParam[0] && cloth.Key == findParam[1])
                    {
                        printItem += " (found!)";
                    }

                    Console.WriteLine(printItem);
                }
            }
        }
    }
}
