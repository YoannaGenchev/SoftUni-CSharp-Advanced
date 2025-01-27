namespace _2._Sum_Matrix_Columns
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
                int[] colElements = Console.ReadLine().Split()
                                    .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }

            }

            int[] sums = new int[matrix.GetLength(1)];
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sums[col] = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sums[col] += matrix[row, col];
                }
            }

            Console.WriteLine(string.Join("\n", sums));
        }
    }
}
