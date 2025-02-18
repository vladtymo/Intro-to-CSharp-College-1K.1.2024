using System.Threading.Channels;

interface ICar
{
    int Speed { get; set; }
    bool HighBeamOn { get; set; }
    string Color { get; set; }
    
    void Drive();
    void Stop();
    void TurnLeft();
    void TurnRight();
    void ShowInfo();
}

class SportCar : ICar
{
    public int Speed { get; set; }
    public bool HighBeamOn { get; set; }
    public string Color { get; set; }
    public void Drive()
    {
        Console.WriteLine("Sport car is driving!");
        Speed += 15;

        if (Speed > 100)
            HighBeamOn = true;

        if (Speed > 167)
            Speed = 167;
    }

    public void Stop()
    {
        Console.WriteLine("Sport is stopping...!");
        Speed -= 30;
        
        if (Speed < 0)
            Speed = 0;
    }

    public void TurnLeft()
    {
        Console.WriteLine("Sport car is turning left!");
    }

    public void TurnRight()
    {
        Console.WriteLine("Sport car is turning right!");
    }

    public void ShowInfo()
    {
        Console.WriteLine("--------- INFO ---------");
        Console.WriteLine("Speed: {0}", Speed);
        Console.WriteLine("High Beam On: {0}", HighBeamOn);
    }
}


internal class Program
{
    public static void Main(string[] args)
    {
        SportCar car = new SportCar();
        
        car.Drive();
        car.Drive();
        car.Drive();
        car.ShowInfo();
        
        car.Stop();
        car.TurnLeft();
        car.TurnRight();
        car.ShowInfo();
    }
}