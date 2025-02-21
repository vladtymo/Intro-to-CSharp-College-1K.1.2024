class Kettle
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Temperature { get; set; }
    public int Volume { get; set; }
    public bool IsOn { get; set; }

    public Kettle(string m, string c, int v)
    {
        Model = m;
        Color = c;
        Temperature = 0;
        IsOn = false;
        Volume = v;
    }
    
    public void Show()
    {
        Console.WriteLine($"------ Kettle [{Model}] ------\n" +
                          $"Model: {Model}\n" +
                          $"Color: {Color}\n" +
                          $"Volume: {Volume}\n" +
                          $"Status: {(IsOn ? "ON" : "OFF")}\n");
    }

    public static Kettle operator+(Kettle a, Kettle b)
    {
        Kettle result = new(a.Model, a.Color, a.Volume + b.Volume);
        result.IsOn = false;
        result.Temperature = a.Temperature + b.Temperature;
        return result;
    }
    
    public static bool operator>(Kettle a, Kettle b)
    {
        return a.Volume > b.Volume;
    }
    public static bool operator<(Kettle a, Kettle b)
    {
        return !(a > b);
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        // unary operators: ++ -- ! -
        // binary operators: + - * / > < ==
        int c = 10 + 44;
        c++;
        string str = "red" + "green";

        Kettle k1 = new("Tefal", "White", 2000);
        Kettle k2 = new("Samsung", "Black", 1600);

        Kettle k3 = k1 + k2;
        k3.Show();

        if (k1 > k2)
            Console.WriteLine("K1 is bigger than K2");
        else
            Console.WriteLine("K1 is not bigger than K2");
    }
}