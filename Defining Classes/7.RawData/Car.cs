using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.RawData
{
    internal class Car
    {
        private string model;

        public Car(string model,
        int speed,
        int power,
        int weight,
        string type,
        double tyre1pressure,
        int tyre1age,
        double tyre2pressure,
        int tyre2age,
        double tyre3pressure,
        int tyre3age,
        double tyre4pressure,
        int tyre4age) 
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
            Tires = new Tires[4];
            Tires[0] = new(tyre1age, tyre1pressure);
            Tires[1] = new(tyre2age, tyre2pressure);
            Tires[2] = new(tyre3age, tyre3pressure);
            Tires[3] = new(tyre4age, tyre4pressure);
        }

        public string Model
        { 
            get { return model; }
            set { model = value; }
        }
        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tires[] Tires { get; set; }
    }
}
