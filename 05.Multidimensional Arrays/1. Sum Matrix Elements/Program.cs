﻿namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ")
                          .Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            int sum = 0;
            for (int row = 0;row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ")
                                    .Select(int.Parse).ToArray();
                for (int col = 0;col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = colElements[col];
                    sum += matrix[row, col];
                }

            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);

        }
    }
}
