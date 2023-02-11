using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string marke;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public Car()
        {
            Marke = "VW";
            Model = "Golf";
            Year = 2025;
            fuelQuantity = 200;
            fuelConsumption = 10;
        }
        public Car(string marke , string model , int year)
            :this()
        {
            Marke = marke;
            Model = model;
            Year = year;
        }
        public Car(string marke, string model, int year, double fuelQuantity, double fuelConsumption)
            :this(marke, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public string  Marke { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double fuelQuantityForExcursion = distance * FuelConsumption;

            if (fuelQuantity >= fuelQuantityForExcursion)
            {
                fuelQuantity -= fuelQuantityForExcursion;
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Marke}\nModel: {this.Model}\nYear: {Year}\nFuel:{this.FuelQuantity:f2}";        
        }

    }
}
