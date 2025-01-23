namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> startIdxs = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    startIdxs.Push(i);
                }
                else if (expression[i]  == ')')
                {
                    int startPos = startIdxs.Pop();
                    int endPos = i;
                    string substr = expression.Substring(startPos, endPos - startPos + 1);
                    Console.WriteLine(substr);
                }
            }
        }
    }
}
