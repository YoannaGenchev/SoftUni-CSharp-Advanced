namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void SwapMethod<T>(List<T> list, int idx1, int idx2)
        {
            T elem1 = list[idx1];
            T elem2 = list[idx2];
            list[idx1] = elem2;
            list[idx2] = elem1;
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var boxes = new List<Box<int>>();
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                var box = new Box<int>(num);
                boxes.Add(box);
            }

            var command = Console.ReadLine();
            var indexes = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            SwapMethod(boxes, indexes[0], indexes[1]);

            foreach (var box in boxes)
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
}
