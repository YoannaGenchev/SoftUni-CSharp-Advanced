namespace _1._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = Console.WriteLine;
            Array.ForEach(words, print);
        }
    }
}
