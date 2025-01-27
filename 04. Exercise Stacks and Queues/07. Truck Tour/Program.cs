namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<(int, int)> q = new Queue<(int, int)>();
            for (int i = 0; i < n; i++)
            {
                int[] pair = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                int pump = pair[0];
                int km = pair[1];
                q.Enqueue((pump, km));
            }
            int startIndex = 0; 
            
            while (true)
            {
                int totalFuel = 0;

                foreach (var pair in q)
                {
                    totalFuel += pair.Item1;
                    int km = pair.Item2;

                    totalFuel -= km;

                    if (totalFuel < 0)
                    {
                        break;
                    }
                }

                if (totalFuel < 0)
                {
                    q.Enqueue(q.Dequeue());
                    startIndex++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(startIndex);
        }
    }
}
