namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] board = new int[n][];
            
            for (int row = 0; row < board.Length; row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                board[row] = input;
            }

            int leftSum = 0;
            int rightSum = 0;

            for (int row = 0; row < board[0].Length; row++)
            {
                leftSum += board[row][row];
            }

            int colDiag = board[0].Length - 1;
            for (int row = 0; row < board.GetLength(0); row++)
            {
                rightSum += board[row][colDiag--];
            }

            Console.WriteLine(Math.Abs(leftSum - rightSum));
        }
    }
}
