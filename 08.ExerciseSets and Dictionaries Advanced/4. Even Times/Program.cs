namespace _4._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> num = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (!num.ContainsKey(inputNumber))
                {
                    num.Add(inputNumber, 0);
                }

                num[inputNumber]++;
            }

            int evenNumber = num
                .Where(x => x.Value % 2 == 0)
                .FirstOrDefault()
                .Key;

            Console.WriteLine(evenNumber);
        }
    }
}
