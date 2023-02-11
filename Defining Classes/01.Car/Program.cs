namespace CarManufacturer;
public class StartUp
{
    public static void Main(string[] args)
    {
       Car car = new Car();

        car.Marke = "Vw";
        car.Model = "Polo";
        car.Year = 2012;


        Console.WriteLine($"Make: {car.Marke}\nModel: {car.Model}\nYear: {car.Year}");
    }
}