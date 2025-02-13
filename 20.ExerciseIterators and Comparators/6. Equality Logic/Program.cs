namespace EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sortedSet = new SortedSet<Person>();
            var hashSet = new HashSet<Person>();
            for (int i = 0; i < num; i++)
            {
                var commandArgs = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(commandArgs[0], int.Parse(commandArgs[1]));
                hashSet.Add(person);
                sortedSet.Add(person);
            }

            Console.WriteLine(hashSet.Count);
            Console.WriteLine(sortedSet.Count);
        }
    }
}
