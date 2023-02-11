namespace _02.GenericBoxOfInteger;
public class StartUp
{
    public static void Main(string[] args)
    {
        Box<int> boxItems = new();
        int n = int.Parse(Console.ReadLine());
       
        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            boxItems.Add(input);
        }

        Console.WriteLine(boxItems.ToString());
    }
}