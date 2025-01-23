namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Queue<string> children = new Queue<string>();
            foreach (string name in names)
            {
                children.Enqueue(name);
            }

            int n = int.Parse(Console.ReadLine());
            while (children.Count > 1)
            {
                for (int i = 1; i <= n - 1; i++)
                {
                    string name = children.Dequeue();
                    children.Enqueue(name);
                }
                string removedChildName = children.Dequeue();
                Console.WriteLine($"Removed {removedChildName}");
            }
            string lastChildName = children.Dequeue();
            Console.WriteLine($"Last is {lastChildName}");
        }
    }
}
