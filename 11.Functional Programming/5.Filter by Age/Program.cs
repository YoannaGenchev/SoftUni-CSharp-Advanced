namespace _5.Filter_by_Age
{
    internal class Program
    {
        public static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
        {
            switch (condition)
            {
                case "younger": return x => x.Age < ageThreshold;
                case "older": return x => x.Age >= ageThreshold;
                default: throw new ArgumentException(condition);
            }
        }
        public static Action<Person> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return person => Console.WriteLine($"{person.Name}");
                case "age":
                    return person => Console.WriteLine($"{person.Age}");
                case "name age":
                    return person => Console.WriteLine($"{person.Name} - {person.Age}");
                default: throw new ArgumentException(format);
            }
        }
        public static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            var filteredPeople = people.Where(p => filter(p)).ToList();
            foreach(var person in filteredPeople)
            {
                printer(person);
            }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string personData = Console.ReadLine();
                string[] parameters = personData.Split(", ");
                Person person = new Person();
                person.Name = parameters[0];
                person.Age = int.Parse(parameters[1]);
                people.Add(person);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = CreateFilter(condition, age);
            Action<Person> printer = CreatePrinter(format);
            PrintFilteredPeople(people, filter, printer);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
