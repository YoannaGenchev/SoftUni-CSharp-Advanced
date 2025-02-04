namespace SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new();
            for (int i = 0; i < n; i++)
            {
                var parameters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var car = new Car(parameters[0], double.Parse(parameters[1]), double.Parse(parameters[2]));
                cars[parameters[0]] = car;
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                var commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commandArgs[0] == "Drive" && cars.ContainsKey(commandArgs[1]) && double.Parse(commandArgs[2]) > 0)
                {
                    cars[commandArgs[1]].Drive(double.Parse(commandArgs[2]));
                }

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:F2} {car.Value.TravelledDistance}");
            }
        }
    }
}
