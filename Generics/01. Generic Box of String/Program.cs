namespace _01._Generic_Box_of_String;
public class StartUp
{
    public static void Main(string[] args)
    {
        Box <string> box = new Box<string>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string index = Console.ReadLine();
            box.Add(index);
        }

        Console.WriteLine(box.ToString());
    }
}