namespace _21_class;

public class Bicycle
{
    private string model;
    private int year;
    private string color;
    private int transmissions;
    private int currentTransmission;
    private int speed;

    public Bicycle()
    {
        model = "No model";
        year = DateTime.Now.Year;
        color = "White";
        transmissions = 1;
        currentTransmission = 1;
        speed = 0;
    }
    public Bicycle(string model, int year, string color, int transmissions)
    {
        this.model = model;
        this.year = year;
        this.color = color;
        this.transmissions = transmissions;
        currentTransmission = 1;
        speed = 0;
    }
    
    public void Go()
    {
        Console.WriteLine($"Let's go on {model} with {currentTransmission} transmission...");
        speed += 5 * currentTransmission;
    }

    public void Stop()
    {
        Console.WriteLine("Bicycle stopped!");
        speed = 0;
    }
    
    public void TransmissionUp()
    {
        Console.WriteLine("Transmission up!");
        if (currentTransmission < transmissions)
            currentTransmission++;
        else
            Console.WriteLine("We have Highest transmission level!");
    }
    public void TransmissionDown()
    {
        Console.WriteLine("Transmission down!");
        if (currentTransmission > 1)
            currentTransmission--;
        else
            Console.WriteLine("We have Lowest transmission level!");
    }
}

public class ElectricBike : Bicycle
{
    private int enginePower;
    private int batteryPercentage;

    public ElectricBike(string model, int year, string color, int transmissions, int enginePower)
        : base(model, year, color, transmissions)
    {
        this.enginePower = enginePower;
        this.batteryPercentage = 100;
    }
    
    public void Drive()
    {
        Console.WriteLine($"Driving with engine of {enginePower}kw...");
        batteryPercentage -= 10;
        
        if (batteryPercentage < 0) 
            batteryPercentage = 0;
    }

    public void ChargeBattery()
    {
        while (batteryPercentage < 100)
        {
            Console.WriteLine($"Charging battery {batteryPercentage}% ...");
            batteryPercentage += 10;
        }
        if (batteryPercentage > 100)
            batteryPercentage = 100;
        
        Console.WriteLine("Battery charging complete 100%!");
    }
}