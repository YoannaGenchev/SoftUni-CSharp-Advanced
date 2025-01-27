namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static long[] GetCurrentRow(long[] prevRow)
        {
            int prevRowSize = prevRow.Length;
            long[] curretnRow = new long[prevRowSize + 1];
            curretnRow[0] = 1;
            for (int i = 1; i < prevRowSize; i++)
            {
                curretnRow[i] = prevRow[i - 1] + prevRow[i];
            }
            curretnRow[prevRowSize] = 1;

            return curretnRow;
        }

        static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine());

            if (rowSize <= 0)
            {
                return;
            }

            long[][] matrix = new long[rowSize][];
            matrix[0] = new long[] { 1 };
            for (int row = 1; row < rowSize; row++)
            {
                matrix[row] = GetCurrentRow(matrix[row -1]);
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
