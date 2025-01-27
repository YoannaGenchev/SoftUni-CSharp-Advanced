namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rowSize][];
            for (int row = 0; row < rowSize; row++)
            {
                int[] columns = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                matrix[row] = columns;
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);
                if (row < 0 || row >= matrix.Length || col < 0 || col >= matrix[row].Length )
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (action == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (action == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
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
