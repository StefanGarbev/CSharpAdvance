using System;

namespace CarManufacturer;
public class StartUp
{
    public static void Main(string[] args)
    {
        string marke = Console.ReadLine();
        string model = Console.ReadLine();
        int year = int.Parse(Console.ReadLine());
        double fuelQuantity = double.Parse(Console.ReadLine());
        double fuelConsumption = double.Parse(Console.ReadLine());
        

        Car firstCar = new Car();
        Car secondCar = new Car(marke, model, year);
        Car thirdCar = new Car(marke, model, year, fuelQuantity, fuelConsumption);

       Console.WriteLine($"{thirdCar.Marke} {thirdCar.Model} {thirdCar.Year} {thirdCar.FuelQuantity} {thirdCar.FuelConsumption}");
    }
}