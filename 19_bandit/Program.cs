internal class Program
{
    static Random rand = new();
    private static int speed = 100; // чим менша затримка, тим швидше обертаються барабани

    static Queue<char> drum1 = new(new[] {'7', '3', '♦', '♡', '$'});
    static Queue<char> drum2 = new(new[] {'7', '3', '♦', '♡', '$'});
    static Queue<char> drum3 = new(new[] {'7', '3', '♦', '♡', '$'});
    
    static void RotateDrum(Queue<char> drum)
    {
        for (int i = 0; i < rand.Next(5, 20); i++)
        {
            drum.Enqueue(drum.Dequeue());
            Thread.Sleep(speed);
            Console.Clear();
            Console.WriteLine($"Result: [{drum1.Peek()}] [{drum2.Peek()}] [{drum3.Peek()}]");
        }
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine($"Result: [{drum1.Peek()}] [{drum2.Peek()}] [{drum3.Peek()}]");

        while (true)
        {
            RotateDrum(drum1);
            RotateDrum(drum2);
            RotateDrum(drum3);

            Console.WriteLine("Press any key to play again...");
            Console.ReadKey();
        }
    }
}