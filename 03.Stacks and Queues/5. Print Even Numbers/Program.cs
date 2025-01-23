namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            while (numbers.Count > 0)
            {
                int num = numbers.Dequeue();
                if (num % 2 == 0)
                {
                    Console.Write(num);
                    if (numbers.Count > 0)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}
