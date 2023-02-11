using System;

namespace CarManufacturer;
public class StartUp
{
    public static void Main(string[] args)
    {
        var tires = new Tyre[4]
            {
                new Tyre(1, 2.5),
                new Tyre(1, 2.1),
                new Tyre(1, 1.5),
                new Tyre(1, 2.3)
            };

        var engine = new Engine(560, 6300);

        var car = new Car("Lamborgini", "Urus", 2010, 250, 9, engine, tires);

    }
}