namespace _7._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<Car> cars = new();
            for (int i = 0; i < n; i++)
            {
                var parameters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = parameters[0];
                var engine = new Engine(int.Parse(parameters[2]), int.Parse(parameters[1]));
                var cargo = new Cargo(int.Parse(parameters[3]), parameters[4]);
                var tire1 = new Tire(int.Parse(parameters[6]), double.Parse(parameters[5]));
                var tire2 = new Tire(int.Parse(parameters[8]), double.Parse(parameters[7]));
                var tire3 = new Tire(int.Parse(parameters[10]), double.Parse(parameters[9]));
                var tire4 = new Tire(int.Parse(parameters[12]), double.Parse(parameters[11]));
                var car = new Car(model, engine, cargo, tire1, tire2, tire3, tire4);
                cars.Add(car);
            }

            var filter = Console.ReadLine();
            if (filter == "fragile")
            {
                var filteredCars = cars.Where(car => car.Cargo.Type == "fragile" && car.Tires.Any(tire => tire.Pressure < 1)).ToList();
                foreach (var car in filteredCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (filter == "flammable")
            {
                var filteredCars = cars.Where(car => car.Cargo.Type == "flammable" && car.Engine.Power > 250).ToList();
                foreach (var car in filteredCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
