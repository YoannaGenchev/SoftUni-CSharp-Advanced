namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            foreach (int i in clothes)
            {
                stack.Push(i);
            }
            int numOfRacks = 1;
            int currRack = 0;
            while (stack.Count > 0)
            {
                if (currRack + stack.Peek() <= capacity)
                {
                    currRack += stack.Pop();
                }
                else
                {
                    currRack = stack.Pop();
                    numOfRacks++;
                }
            }

            Console.WriteLine(numOfRacks);
        }
    }
}
