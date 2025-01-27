namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] operation = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = operation[0];
            int s = operation[1];
            int x = operation[2];
            Queue<int> queue = new Queue<int>();
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(ints[i]);
            }
            for (int i = 0;i < s; i++)
            {
                queue.Dequeue();
            }
            if(queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if(queue.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
