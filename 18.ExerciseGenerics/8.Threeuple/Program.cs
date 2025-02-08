namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var command1 = Console.ReadLine();
            var args1 = command1.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var tuple1 = new MyTuple<string, string, string>($"{args1[0]} {args1[1]}", args1[2], args1[3]);
            Console.WriteLine(tuple1.ToString());

            var command2 = Console.ReadLine();
            var args2 = command2.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var tuple2 = new MyTuple<string, int, bool>(args2[0], int.Parse(args2[1]), args2[2] == "drunk");
            Console.WriteLine(tuple2.ToString());

            var command3 = Console.ReadLine();
            var args3 = command3.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var tuple3 = new MyTuple<string, double, string>(args3[0], double.Parse(args3[1]), args3[2]);
            Console.WriteLine(tuple3.ToString());
        }
    }
}
