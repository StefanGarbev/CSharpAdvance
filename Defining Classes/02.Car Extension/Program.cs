﻿namespace CarManufacturer;
public class StartUp
{
    public static void Main(string[] args)
    {
        Car car = new Car();

        car.Marke = "VW";
        car.Model = "Golf";
        car.Year = 1992;
        car.FuelQuantity = 200;
        car.FuelConsumption = 200;
        car.Drive(2000);

        Console.WriteLine(car.WhoAmI());
    }
}