namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

            int entries = int.Parse(Console.ReadLine());
            for (int i = 0; i < entries; i++)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split();
                string continent = commandArgs[0];
                string country = commandArgs[1];
                string city = commandArgs[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new Dictionary<string, List<string>>();
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new List<string>();
                }

                continentsData[continent][country].Add(city);
            }

            foreach (var continent in continentsData)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
