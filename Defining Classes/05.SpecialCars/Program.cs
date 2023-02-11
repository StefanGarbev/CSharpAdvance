using System;

namespace CarManufacturer;
public class StartUp
{
    public static void Main(string[] args)
    {
        string command = string.Empty;
        List<Car> cars = new List<Car>();
        List<Tyre> tyres = new List<Tyre>();
        List<Engine> engines = new List<Engine>();
        List<List<Tyre>> carTyres = new();
        List<List<Engine>> carEngine = new();

        while ((command = Console.ReadLine()) != "No more tires")
        {
            string[] tireInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int tyre1Year = int.Parse(tireInfo[0]);
            double tyre1Pressure = double.Parse(tireInfo[1]);
            int tyre2Year = int.Parse(tireInfo[2]);
            double tyre2Pressure = double.Parse(tireInfo[3]);
            int tyre3Year = int.Parse(tireInfo[4]);
            double tyre3Pressure = double.Parse(tireInfo[5]);
            int tyre4Year = int.Parse(tireInfo[6]);
            double tyre4Pressure = double.Parse(tireInfo[7]);

            tyres.Add(new Tyre(tyre1Year, tyre1Pressure));
            tyres.Add(new Tyre(tyre2Year, tyre2Pressure));
            tyres.Add(new Tyre(tyre3Year, tyre3Pressure));
            tyres.Add(new Tyre(tyre4Year, tyre4Pressure));

            carTyres.Add(tyres);
            Car carTyre = new Car(carTyres);
        }

        while ((command = Console.ReadLine()) != "Engines done")
        {
            string[] engineInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int horsePower = int.Parse(engineInfo[0]);
            double cubicCapacity = double.Parse(engineInfo[1]);

            engines.Add(new Engine(horsePower, cubicCapacity));
            carEngine.Add(engines);
            Car carEngines = new Car(carEngine);

        }

        while (true)
        {
            if ((command = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string marke = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tyreIndex = int.Parse(carInfo[6]);
                Engine engine = engines[engineIndex];
                int horsePower = engine.HorsePower;
                List<Tyre> tyresForCar = carTyres[tyreIndex];
                int count = 0;
                double sumOfTyrePressure =0;
                foreach (Tyre tyre in tyresForCar)
                {
                    count++;
                    if (count <= 4)
                    { 
                        sumOfTyrePressure += tyre.Pressure;
                    }
                }
                cars.Add(new Car(marke, model, year, fuelQuantity, fuelConsumption, engineIndex,
                    tyreIndex, horsePower, sumOfTyrePressure));
            }

            else if ((command = Console.ReadLine()) == "Show special")
            {
                if (cars.Any(c => c.Year >= 2017))
                {
                    Console.WriteLine($"Model: {cars[1].Model}");
                }
            }
        }
    }
}