using _21_class;

class Conditioner
{
    private string name;
    private int temperature;
    private string mode;

    private const int minT = 16;
    private const int maxT = 32;

    // конструктори
    public Conditioner()
    {
        name = "No model";
        mode = "Auto";
        temperature = minT;
    }
    public Conditioner(string model) : this()
    {
        this.name = model;
    }

    public void Show()
    {
        Console.WriteLine($"Conditioner: [{this.name}]\n" +
                          $"T: {temperature} (C)\n" +
                          $"Mode: {mode}");
    }

    public void Plus()
    {
        // валідація даних
        if (temperature + 2 <= maxT)
            temperature += 2;
    }
    public void Minus()
    {
        // валідація даних
        if (temperature - 2 >= minT)
            temperature -= 2;
    }
}

class CeeperHunterPro : Conditioner
{
    private bool isPreventWind;
    private int dryingLevel;
    
    public CeeperHunterPro(string model) : base(model)
    {
        this.isPreventWind = false;
        this.dryingLevel = 3;
    }
    
    public void Dry()
    {
        Console.WriteLine($"Drying: {dryingLevel}");
    }
}


internal class Program
{
    public static void Main(string[] args)
    {
        Conditioner conditioner = new(); // виклик конструктора

        for (int i = 0; i < 10; i++)
            conditioner.Plus();

        //conditioner.temperature *= 1000;
        conditioner.Plus();
        conditioner.Show();

        Conditioner con2 = new("Honda Dio 2"); // виклик конструктора
        con2.Minus();
        con2.Show();
        
        CeeperHunterPro con3 = new("MG5563 UI");
        
        con3.Plus();
        con3.Dry();
        con3.Show();
        
        // ------------- Bicycle -------------
        Bicycle bicycle = new();
        
        bicycle.Go();
        
        Bicycle ukraine = new("Ukraine", 1991, "Blue", 1);
        ukraine.Go();
        ukraine.Go();

        ElectricBike patriot = new("Patriot", 2023, "Red", 21, 40);
        patriot.Drive();
        patriot.Drive();
        patriot.Drive();
        
        patriot.ChargeBattery();
    }
}