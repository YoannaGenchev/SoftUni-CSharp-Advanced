namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                var box = new Box<string>(str);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
