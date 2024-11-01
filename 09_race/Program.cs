using System.Diagnostics;

internal class Program
{
    // обєкт для генерації рандомних чисел
    static Random rand = new();
    
    // розміри карти
    const int width = 100;
    const int height = 20;
    
    // позиція авто, на початку по центру
    static int positionX = width / 2;
    
    // розміри авто (в символах)
    const int carWidth = 5;
    const int carHeight = 4;

    // швидкість генерації бобм (в мілісекундах)
    static int bombInterval = 2000;
    // швидкість падіння бобм (в мілісекундах)
    static int bombSpeed = 500;
    
    // кількість пройдених бомб
    static int score = 0;
    
    // колекція активних бомб
    static List<Boomb> boombs = new();
    
    // таймер генерації бобм
    static Stopwatch bombTimer = new();
    // таймер падіння бобм
    static Stopwatch bombFallTimer = new();
    
    public static void Main(string[] args)
    {
        InitialSettings();
        PrintCar();

        bombTimer.Start();
        bombFallTimer.Start();
        
        while (!IsFail())
        {
            // чи настав час генерувати нову бомбу
            if (bombTimer.ElapsedMilliseconds >= bombInterval)
            {
                GenerateBomb();
                IncreaseSpeed();
                bombTimer.Restart();
            }
            // чи настав час падіння бобм
            if (bombFallTimer.ElapsedMilliseconds >= bombSpeed)
            {
                MoveAllBombs();
                bombFallTimer.Restart();
            }
            
            Move();
        }

        Console.WriteLine($"Your score: {score}");
    }

    static void GenerateBomb()
    {
        int x = rand.Next(width);
        var bomb = new Boomb(x, 0);
        boombs.Add(bomb);
        PrintBomb(bomb);
        score++;
    }

    static void MoveAllBombs()
    {
        foreach (var i in boombs)
        {
            ClearBomb(i); 
            i.Y += 1;
            PrintBomb(i);
        }
    }
    static void PrintBomb(Boomb bomd)
    {
        Console.SetCursorPosition(bomd.X, bomd.Y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('*');
        Console.ResetColor();
    }
    static void ClearBomb(Boomb bomd)
    {
        Console.SetCursorPosition(bomd.X, bomd.Y);
        Console.Write(' ');
    }
    static void InitialSettings()
    {
        Console.SetWindowSize(width, height);
        Console.CursorVisible = false;
        Console.Clear();
    }
    static void Move()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey().Key;

            ClearCar();
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (OnLeftSide()) break;
                    positionX -= carWidth;
                    break;
                case ConsoleKey.RightArrow:
                    if (OnRightSide()) break;
                    positionX += carWidth;
                    break;
            }
            PrintCar();
        }
    }

    static bool IsFail()
    {
        foreach (var i in boombs)
        {
            if (i.X >= positionX && i.X < positionX + carWidth &&
                i.Y >= height && i.Y <= height + carHeight - 1)
                return true;
        }

        return false;
    }
    static void IncreaseSpeed()
    {
        if (bombInterval > 400)
            bombInterval -= 50;
        if (bombSpeed > 50)
            bombSpeed -= 10;
    }
    static bool OnLeftSide()
    {
        return positionX <= 0;
    }
    static bool OnRightSide()
    {
        return positionX + carWidth >= width;
    }
    static void PrintCar()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(positionX, height);
        Console.Write(@"_/|\_");
        Console.SetCursorPosition(positionX, height + 1);
        Console.Write("O _ O");
        Console.SetCursorPosition(positionX, height + 2);
        Console.Write("| _ |");
        Console.SetCursorPosition(positionX, height + 3);
        Console.Write("O | O");
        Console.ResetColor();
    }
    static void ClearCar()
    {
        for (var y = 0; y < carHeight; y++)
        {
            Console.SetCursorPosition(positionX, height + y);
            Console.Write(new string(' ', carWidth));
        }
    }
}

public class Boomb
{
    public int X, Y;

    public Boomb(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}