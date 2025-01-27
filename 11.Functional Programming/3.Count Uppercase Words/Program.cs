namespace _3.Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startsWithCapitalLetter = word => word[0] == word.ToUpper()[0];
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => startsWithCapitalLetter(w))
                .ToArray();

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
