namespace GenericCountMethodDoubles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                var dbl = double.Parse(Console.ReadLine());
                list.Add(dbl);
            }

            var elem = double.Parse(Console.ReadLine());

            var box = new Box<double>();
            box.Items = list;
            var count = box.GenericCountMethod(elem);
            Console.WriteLine(count);
        }
    }
}
