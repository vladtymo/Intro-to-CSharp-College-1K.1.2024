internal class Program
{
    public static void Main(string[] args)
    {
        Point ball = new Point();

        ball.x = 20;
        ball.Print();

        ball.y = 10;
        ball.Print();
    }
}


// class (heap: many mb) vs struct (stack: 1-2mb)

public struct Point
{
    // properties
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public char symbol = '*';

    public Point() {}
    
    // methods
    public void Reset()
    {
        x = y = z = 0;
    }

    public void Print()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
        Console.ResetColor();
    }
}



