// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Snake snake = new();
        
        snake.Print();

        Console.WriteLine();
    }
    
    
}

class Snake
{
    // properties (numbers, strings and etc)
    public int size = 1;
    public ConsoleColor color = ConsoleColor.Red;
    public int x = 0;
    public int y = 0;
    public char symbol = '@';

    // methods (actions)
    public void Print()
    {
        Console.ForegroundColor = color;
        Console.SetCursorPosition(x, y);

        Console.Write(symbol);
        
        Console.ResetColor();
    }
}