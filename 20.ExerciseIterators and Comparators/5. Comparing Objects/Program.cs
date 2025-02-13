namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var people = new List<Person>();
            while (command != "END")
            {
                var commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(commandArgs[0], int.Parse(commandArgs[1]), commandArgs[2]);
                people.Add(person);
                command = Console.ReadLine();
            }

            int matchingPeopleCount = 0;
            int personIndex = int.Parse(Console.ReadLine());
            personIndex--;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[personIndex].CompareTo(people[i]) == 0)
                {
                    matchingPeopleCount++;
                }
            }

            if (matchingPeopleCount <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matchingPeopleCount} {people.Count - matchingPeopleCount} {people.Count}");
            }
        }
    }
}
