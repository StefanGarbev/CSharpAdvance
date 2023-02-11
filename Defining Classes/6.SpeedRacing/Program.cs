namespace Car;

public class StartUp
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        
        Dictionary<string, Car> carInfo = new();

        for (int i = 0; i < number; i++)
        {
            //AudiA4 23 0.3
            string[] carParameters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Car car = new()
            {
                Model = carParameters[0],
                FuelAmount = double.Parse(carParameters[1]),
                FuelConsumptionPerKilometer = double.Parse(carParameters[2])
            };

            carInfo.Add(car.Model, car);

        }

        string commandArgs = string.Empty;

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "End")
            {
                break;
            }

            string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string carModel = tokens[1];
            double amountOfKilometers = double.Parse(tokens[2]);

            Car car = carInfo[carModel];

            car.Drive(amountOfKilometers);

        }

        foreach (var car in carInfo.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
        }

    }
}