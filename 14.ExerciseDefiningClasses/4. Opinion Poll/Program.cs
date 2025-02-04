namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<Person> list = new();
            for (int i = 0; i < n; i++)
            {
                var arguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = arguments[0];
                var age = int.Parse(arguments[1]);
                Person person = new(name, age);
                list.Add(person);
            }

            var sortedPeople = list.Where(person =>  person.Age > 30).OrderBy(person => person.Name).ToList();
            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
