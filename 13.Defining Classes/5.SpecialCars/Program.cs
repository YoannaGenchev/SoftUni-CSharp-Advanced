namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public int HorsePower
        {
            get { return this.horsePower; }
            set { this.horsePower = value; }
        }

        public double CubicCapacity
        {
            get { return this.cubicCapacity; }
            set { this.cubicCapacity = value; }
        }

        public Engine()
        {
            this.HorsePower = 0;
            this.CubicCapacity = 0;
        }

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }
    public class Tire
    {
        private int year;
        private double pressure;

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }

        public Tire()
        {
            this.Year = 0;
            this.Pressure = 0;
        }

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }
        public Tire[] Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }

        public Car()
        {
            this.make = "VW";
            this.model = "Golf";
            this.year = 2025;
            this.fuelQuantity = 200;
            this.fuelConsumption = 10;
            this.Engine = new Engine();
            this.Tires = new Tire[4]
            {
                new(),
                new(),
                new(),
                new()
            };
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public void Drive(double distance)
        {
            bool canDrive = this.fuelQuantity - (this.fuelConsumption * distance / 100.0) >= 0;
            if (canDrive)
            {
                this.fuelQuantity -= (this.fuelConsumption * distance / 100.0);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public double GetAllTiresPressure()
        {
            double sum = 0;
            foreach (Tire t in this.Tires)
            {
                sum += t.Pressure;
            }
            return sum;
        }
        public string WhoAmI()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            return $"Make: {this.make}\nModel: {this.model}\nYear: {this.year}\nHorsePowers: {this.Engine.HorsePower}\nFuelQuantity: {this.fuelQuantity}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            string command = Console.ReadLine();
            while (command != "No more tires")
            {
                string[] commandArgs = command.Split();
                int year1 = int.Parse(commandArgs[0]);
                double pressure1 = double.Parse(commandArgs[1]);
                var tire1 = new Tire(year1, pressure1);

                int year2 = int.Parse(commandArgs[2]);
                double pressure2 = double.Parse(commandArgs[3]);
                var tire2 = new Tire(year2, pressure2);

                int year3 = int.Parse(commandArgs[4]);
                double pressure3 = double.Parse(commandArgs[5]);
                var tire3 = new Tire(year3, pressure3);

                int year4 = int.Parse(commandArgs[6]);
                double pressure4 = double.Parse(commandArgs[7]);
                var tire4 = new Tire(year4, pressure4);

                Tire[] currentTires = new Tire[4]
                {
                    tire1, tire2 , tire3 , tire4
                };
                tires.Add(currentTires);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            List<Engine> engines = new List<Engine>();
            while (command != "Engines done")
            {
                string[] commandArgs = command.Split();
                int horsePower = int.Parse(commandArgs[0]);
                double engineCapacity = double.Parse(commandArgs[1]);
                var engine = new Engine(horsePower, engineCapacity);
                engines.Add(engine);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            List<Car> cars = new List<Car>();
            while (command != "Show special")
            {
                string[] commandArgs = command.Split();
                string make = commandArgs[0];
                string model = commandArgs[1];
                int year = int.Parse(commandArgs[2]);
                double fuelQuantity = double.Parse(commandArgs[3]);
                double fuelConsumption = double.Parse(commandArgs[4]);
                int engineIndex = int.Parse(commandArgs[5]);
                int tireIndex = int.Parse(commandArgs[6]);

                var carEngine = engines[engineIndex];
                var carTires = tires[tireIndex];

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, carEngine, carTires);
                cars.Add(car);

                command = Console.ReadLine();
            }

            var filteredCars = cars.Where(car => car.Year >= 2017)
                                   .Where(car => car.Engine.HorsePower > 330)
                                   .Where(car => (car.GetAllTiresPressure() >= 9 && car.GetAllTiresPressure() <= 10))
                                   .ToList();

            foreach (var car in filteredCars)
            {
                car.Drive(20);
            }

            foreach (var car in filteredCars)
            {
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
