namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < entries; i++)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split();
                string name = commandArgs[0];
                decimal grade = decimal.Parse(commandArgs[1]);
                if (!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                }

                students[name].Add(grade);
            }

            foreach(var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(v => v.ToString("f2")))} (avg: {student.Value.Average():F2})");
            }
        }
    }
}
