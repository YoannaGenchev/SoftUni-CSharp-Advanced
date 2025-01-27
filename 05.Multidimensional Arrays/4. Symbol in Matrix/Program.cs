namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
