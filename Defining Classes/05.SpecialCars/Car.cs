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
        private List<List<Engine>> engines;
        private List<List<Tyre>> tyres;


        public Car(List<List<Engine>> carEngine)
        {
            this.Engine = engines; 
        }

        public Car(List<List<Tyre>> carTyres)
        {
            this.Tyres = tyres;
        }


        public Car(string marke, string model, int year, double fuelQuantity,
            double fuelConsumption, int engineIndex, int tiresIndex, int horsePower, double sumOfCarPressure)

        {
            this.marke = marke;
            this.model = model;
            this.year = year;
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            this.EngineIndex = engineIndex;
            this.TiresIndex = tiresIndex;
            this.HorsePower = horsePower;
            this.SumOfCarPressure = sumOfCarPressure;
        }

        public string Marke { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public List<List<Engine>> Engine { get; set; }
        public List<List<Tyre>> Tyres { get; set; }
        public int EngineIndex { get; set; }
        public int TiresIndex { get; set; }
        public int HorsePower { get; set; }
        public double SumOfCarPressure { get; set; }
        

        public double Drive20Kilometers (double fuelQuantity, double fuelConsumption)
        {
            fuelQuantity -= (fuelConsumption / 100) * 20;
            return fuelQuantity;
        }
        
    }
}
