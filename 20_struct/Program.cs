using System.Threading.Channels;

struct Airplane
{
    // список властивостей літака
    public string Model { get; set; }
    public int Seats { get; set; }
    public int Passengers { get; set; }
    public string PilotName { get; set; }

    public Airplane(string model, int seats, string pilotName)
    {
        Passengers = 0;
        Model = model;
        Seats = seats;
        PilotName = pilotName;
    }

    // список методів (функцій) літака
    public void Print()
    {
        Console.WriteLine($"---- Airplane [{this.Model}] ----");
        Console.WriteLine($"Passengers: {this.Passengers} / {this.Seats}");
        Console.WriteLine($"Pilot: {this.PilotName}");
    }
    
    public void AddPassengers(int count)
    {
        if (Passengers + count > Seats)
        {
            this.Passengers = Seats;
            Console.WriteLine("Not enough seats!");
        }
        else
            this.Passengers += count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Airplane plane1 = new();
        // plane1.Model = "Boeing 656";
        // plane1.Seats = 63;
        // //...

        Airplane plane1 = new("Boeing 325", 49, "Vitia");
        Airplane plane2 = new("Mriya", 120, "Luda");

        // Console.WriteLine($"---- Airplane [{plane1.Model}] ----");
        // Console.WriteLine($"Passengers: {plane1.Passengers} / {plane1.Seats}");
        // Console.WriteLine($"Pilot: {plane1.PilotName}");
        
        plane1.AddPassengers(2);
        plane1.AddPassengers(40);
        plane1.AddPassengers(30);
        
        plane1.Print();
        plane2.Print();
    }
}


