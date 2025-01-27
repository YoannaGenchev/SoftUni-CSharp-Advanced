namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray().ToArray();
            Dictionary<double, int> dic = new Dictionary<double, int>();
            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic[num] = 1;
                }
            }

            foreach (var pair in dic)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
