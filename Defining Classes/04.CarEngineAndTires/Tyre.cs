using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Tyre
    {
        private int year;
        private double pressure;
        public Tyre(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }

        public int Year { get; set; }
        public double Pressure { get; set; }
    }


}
