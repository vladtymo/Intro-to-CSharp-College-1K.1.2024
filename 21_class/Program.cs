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

internal class Program
{
    public static void Main(string[] args)
    {
        Conditioner conditioner = new(); // виклик конструктора

        for (int i = 0; i < 10; i++)
            conditioner.Plus();

        //conditioner.temperature *= 1000;
        conditioner.Show();

        Conditioner con2 = new("Honda Dio 2"); // виклик конструктора
        con2.Minus();
        con2.Show();
    }
}