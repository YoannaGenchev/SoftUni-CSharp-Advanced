namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                list.Add(str);
            }

            var elem = Console.ReadLine();

            var box = new Box<string>();
            box.Items = list;
            var count = box.GenericCountMethod(elem);
            Console.WriteLine(count);
        }
    }
}
