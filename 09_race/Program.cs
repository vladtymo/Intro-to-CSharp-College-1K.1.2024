using System.Diagnostics;

internal class Program
{
    // обєкт для генерації рандомних чисел
    static Random rand = new();
    
    // розміри карти
    const int rides = 4;   // кількість доріг по ширині
    const int height = 20; // кількість комірок по висоті
    
    // позиція авто, на початку на першій доріжці
    static int currentRide = 0;
    
    // розміри авто (в символах)
    const int carWidth = 5;
    const int carHeight = 4;

    // швидкість генерації бобм (в мілісекундах)
    //static int bombInterval = 2000;
    // швидкість падіння бобм (в мілісекундах)
    static int speed = 400;
    
    // кількість пройдених бомб
    static int score = 0;
    // кількість падінь
    static int count = 0;
    
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

        //bombTimer.Start();
        bombFallTimer.Start();
        
        while (!IsFail())
        {
            // чи настав час генерувати нову бомбу
            if (count % (carHeight * 2 + 1) == 0)//bombTimer.ElapsedMilliseconds >= bombInterval)
            {
                GenerateBomb();
                IncreaseSpeed();
                ++count;
                //bombTimer.Restart();
            }
            // чи настав час падіння бобм
            if (bombFallTimer.ElapsedMilliseconds >= speed)
            {
                MoveAllBombs();
                ++count;
                bombFallTimer.Restart();
            }
            
            Move();
        }

        Console.WriteLine($"Your score: {score}");
    }

    static void GenerateBomb()
    {
        int r = rand.Next(rides);
        var bomb = new Boomb(r);
        boombs.Add(bomb);
        PrintBomb(bomb);
        score++;
    }

    static void MoveAllBombs()
    {
        for (int x = 0; x < boombs.Count; x++)
        {
            var i = boombs[x];
            
            ClearBomb(i);
            if (i.Y >= height + carHeight)
            {
                boombs.Remove(i);
                --x;
            }
            else
            {
                i.Y += 1;
                PrintBomb(i);
            }
        }
    }
    static void PrintBomb(Boomb bomd)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(bomd.ride * carWidth, bomd.Y);
        Console.Write(@"_/|\_");
        Console.SetCursorPosition(bomd.ride * carWidth, bomd.Y + 1);
        Console.Write("O _ O");
        Console.SetCursorPosition(bomd.ride * carWidth, bomd.Y + 2);
        Console.Write("| _ |");
        Console.SetCursorPosition(bomd.ride * carWidth, bomd.Y + 3);
        Console.Write("O | O");
        Console.ResetColor();
    }
    static void ClearBomb(Boomb bomd)
    {
        for (var y = 0; y < carHeight; y++)
        {
            Console.SetCursorPosition(bomd.ride * carWidth, bomd.Y + y);
            Console.Write(new string(' ', carWidth));
        }
        
        // Console.SetCursorPosition(bomd.ride * carWidth, bomd.Y);
        // Console.Write(' ');
    }
    static void InitialSettings()
    {
        //Console.SetWindowSize(width, height);
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
                    currentRide--;
                    break;
                case ConsoleKey.RightArrow:
                    if (OnRightSide()) break;
                    currentRide++;
                    break;
            }
            PrintCar();
        }
    }

    static bool IsFail()
    {
        foreach (var i in boombs)
        {
            if (i.ride == currentRide &&
                i.Y >= height && i.Y <= height + carHeight - 1)
                return true;
        }

        return false;
    }
    static void IncreaseSpeed()
    {
        //if (bombInterval > 200)
        //    bombInterval -= 25;
        if (speed > 70)
            speed -= 10;

        Console.SetCursorPosition(0, 0);
        Console.Write(new string(' ', 30));
        Console.SetCursorPosition(0, 0);
        Console.WriteLine(speed);
    }
    static bool OnLeftSide()
    {
        return currentRide <= 0;
    }
    static bool OnRightSide()
    {
        return currentRide >= rides - 1;
    }
    static void PrintCar()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(currentRide * carWidth, height);
        Console.Write(@"_/|\_");
        Console.SetCursorPosition(currentRide * carWidth, height + 1);
        Console.Write("O _ O");
        Console.SetCursorPosition(currentRide * carWidth, height + 2);
        Console.Write("| _ |");
        Console.SetCursorPosition(currentRide * carWidth, height + 3);
        Console.Write("O | O");
        Console.ResetColor();
    }
    static void ClearCar()
    {
        for (var y = 0; y < carHeight; y++)
        {
            Console.SetCursorPosition(currentRide * carWidth, height + y);
            Console.Write(new string(' ', carWidth));
        }
    }
}

public class Boomb
{
    public int Y;
    public int ride;

    public Boomb(int ride)
    {
        this.ride = ride;
        this.Y = 0;
    }
}