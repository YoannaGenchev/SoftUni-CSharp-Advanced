namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Family family = new();
            for (int i = 0; i < n; i++)
            {
                var arguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = arguments[0];
                var age = int.Parse(arguments[1]);
                Person person = new(name, age);
                family.AddMember(person);
            }

            Person oldest = family.GetOldestMember();
            Console.WriteLine(oldest.ToString());
        }
    }
}
