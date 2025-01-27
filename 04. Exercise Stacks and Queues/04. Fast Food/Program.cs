namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodAmount = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            foreach (int order in orders)
            {
                queue.Enqueue(order);
            }
            Console.WriteLine(queue.Max());
            bool ordersFailed = false;
            while (queue.Count > 0)
            {
                foodAmount -= queue.First();
                if (foodAmount >= 0)
                {
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    ordersFailed = true;
                    break;
                }
            }
            if (ordersFailed == false)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
