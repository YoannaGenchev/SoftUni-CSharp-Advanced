namespace GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                var box = new Box<int>(num);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
