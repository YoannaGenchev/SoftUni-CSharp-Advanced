namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command1 = Console.ReadLine();
            var args1 = command1.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var tuple1 = new MyTuple<string, string>($"{args1[0]} {args1[1]}", args1[2]);
            Console.WriteLine(tuple1.ToString());

            var command2 = Console.ReadLine();
            var args2 = command2.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var tuple2 = new MyTuple<string, int>(args2[0], int.Parse(args2[1]));
            Console.WriteLine(tuple2.ToString());

            var command3 = Console.ReadLine();
            var args3 = command3.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var tuple3 = new MyTuple<int, double>(int.Parse(args3[0]), double.Parse(args3[1]));
            Console.WriteLine(tuple3.ToString());
        }
    }
}
