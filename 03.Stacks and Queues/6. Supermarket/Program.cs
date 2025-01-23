namespace _6._Supermarket
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customer = new Queue<string>();
            string command = Console.ReadLine();
            while(command != "End")
            {
                if(command != "Paid")
                {
                    customer.Enqueue(command);
                }
                else
                {
                    while(customer.Count > 0)
                    {
                        Console.WriteLine(customer.Dequeue());
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{customer.Count} people remaining.");
        }
    }
}
