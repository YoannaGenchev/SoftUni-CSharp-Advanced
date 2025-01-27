namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] operation = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = operation[0];
            int s = operation[1];
            int x = operation[2];
            Stack<int> stack = new Stack<int>();
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                stack.Push(ints[i]);
            }
            for (int i = 0;i < s; i++)
            {
                stack.Pop();
            }
            if (!stack.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
