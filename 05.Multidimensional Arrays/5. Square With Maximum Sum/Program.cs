namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ")
                          .Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ")
                                    .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int maxSum = 0;
            int[] maxElems = new int[4];
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxElems[0] = matrix[row, col];
                        maxElems[1] = matrix[row, col + 1];
                        maxElems[2] = matrix[row + 1, col];
                        maxElems[3] = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine($"{maxElems[0]} {maxElems[1]}");
            Console.WriteLine($"{maxElems[2]} {maxElems[3]}");
            Console.WriteLine(maxSum);
        }
    }
}
