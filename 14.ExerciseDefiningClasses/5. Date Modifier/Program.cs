namespace _5._Date_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstDayAsString = Console.ReadLine();
            string secondDayAsString = Console.ReadLine();

            DateTime firstDate = DateTime.Parse(firstDayAsString);
            DateTime secondDate = DateTime.Parse(secondDayAsString);

            int daysDiff = DateModifier.CalculateDateDiffInDays(firstDate, secondDate);
            Console.WriteLine(daysDiff);
        }
    }
}
