namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new HashSet<string>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandArgs = command.Split(", ");
                string direction = commandArgs[0];
                string carNumber = commandArgs[1];
                if (direction == "IN")
                {
                    cars.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    cars.Remove(carNumber);
                }

                command = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                Console.WriteLine(string.Join("\n", cars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
