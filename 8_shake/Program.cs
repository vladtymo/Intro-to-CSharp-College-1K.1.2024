/*
 TODO:
 * game over screen +
 * snake body symbol
 * progress +
 * super apple +
 */

//Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
using System.Diagnostics;
using _8_shake;

Console.CursorVisible = false;
var rand = new Random();

int score = 0;

Queue<Coord> coords = new();

// швидкість руху змійки
int delay = 200;

// розмір поля
const int sizeX = 10 * 2;
const int sizeY = 16;

const int empty = 0;
const int fruit = 1;
const int superFruit = 2;
const int snake = 3;

const int winCount = 50;
const int superSuperFruitFrequency = 7;

// координати голови змійки
int snakeX = sizeX / 2; 
int snakeY = sizeY / 2;

coords.Enqueue(new(snakeX, snakeY));

// "Left", "Right", "Up", "Down"
string direction = "Right";

int[,] map = new int[sizeY, sizeX]; // на початку все 0

Console.Clear();
PrintMap();
PrintProgressBar();
PrintSnake();
PutApple();

// очікуємо нажаття для старту
Console.ReadKey();

while(!IsWin())
{
    GetDirection();
    if (!Move()) break;

    if (IsApple())
        EatApple();

    Thread.Sleep(delay);
}

if (IsWin())
    PrintYouWonPhrase();
else
    PrintGameOver();

void IncreaseSpeed()
{
    if (delay > 100)
        delay -= 5;
}

void GetDirection()
{
    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey().Key;

        while (Console.KeyAvailable)
        {
            key = Console.ReadKey().Key;
        }
        
        switch (key)
        {
            case ConsoleKey.LeftArrow:
                if (direction == "Right") break;
                direction = "Left";
                break;
            case ConsoleKey.RightArrow:
                if (direction == "Left") break;
                direction = "Right";
                break;
            case ConsoleKey.UpArrow:
                if (direction == "Dowm") break;
                direction = "Up";
                break;
            case ConsoleKey.DownArrow:
                if (direction == "Up") break;
                direction = "Down";
                break;
        }
    }
        
}

bool Move()
{
    switch (direction)
    {
        case "Right":
            snakeX += 1;
            break;
        case "Down":
            snakeY += 1;
            break;
        case "Left":
            snakeX -= 1;
            break;
        case "Up":
            snakeY -= 1;
            break;
    }

    if (CheckFail()) return false;

    if (!IsApple())
        ClearSnake();
    //else
        //PrintBody(head);
    
    coords.Enqueue(new(snakeX, snakeY));
    
    PrintSnake();
    return true;
}

bool CheckFail()
{
    return snakeX < 0 || 
           snakeX >= sizeX || 
           snakeY < 0 || 
           snakeY >= sizeY;
}

bool IsApple()
{
    return map[snakeY, snakeX] == fruit || map[snakeY, snakeX] == superFruit;
}
bool IsNextSuperApple()
{
    return score > 1 && score % superSuperFruitFrequency == 0;
}

void EatApple()
{
    map[snakeY, snakeX] = empty;
    AddScore();
    PutApple();
    IncreaseSpeed();
}
void ClearSnake()
{
    var tail = coords.Dequeue();
    
    Console.SetCursorPosition(tail.X + 1, tail.Y + 1);
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(" ");
    map[tail.Y, tail.X] = empty;
}

void PrintSnake()
{
    Console.SetCursorPosition(snakeX + 1, snakeY + 1);
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("@");
    map[snakeY, snakeX] = snake;
}
void PrintBody(Coord head)
{
    Console.SetCursorPosition(head.X + 1, head.Y + 1);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write((char)219);
}

void AddScore()
{
    Console.SetCursorPosition(10 + score, sizeY + 2);
    if (IsNextSuperApple())
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("***");
        score += 3;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("*");
        score++;
    }
}
void PrintProgressBar()
{
    Console.SetCursorPosition(0, sizeY + 2);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Progress: ");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(new string('*', winCount));
}

void PrintMap()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    for (int y = 0; y < sizeX + 2; y++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
    
    for (int y = 0; y < sizeY; y++)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("#");
        
        for (int x = 0; x < sizeX; x++)
        {
            //Console.Write(map[y, x]);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (map[y, x] == empty)
                Console.Write(" ");
        }
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("#");
        
        Console.WriteLine();
    }
    
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    for (int y = 0; y < sizeX + 2; y++)
    {
        Console.Write("#");
    }
    
    Console.ResetColor();
}

void PrintApple(int x, int y)
{
    Console.SetCursorPosition(x + 1, y + 1);
    Console.ForegroundColor = IsNextSuperApple() ? ConsoleColor.Yellow : ConsoleColor.Red;
    Console.Write("*");
}

bool IsWin()
{
    return score == winCount;
}
void PutApple()
{
    int x, y;
    do
    {
        x = rand.Next(sizeX);
        y = rand.Next(sizeY);

    } while (map[y, x] != empty);
    
    if (IsNextSuperApple())
        map[y, x] = superFruit;
    else
        map[y, x] = fruit;
    PrintApple(x, y);
}

static void PrintGameOver()
{
    Console.Clear();
    // ASCII Art for "Game Over"
    string[] gameOverArt = {
        @"  ____                         ___                ",
        @" / ___| __ _ _ __ ___   ___   / _ \__   _____ _ __ ",
        @"| |  _ / _` | '_ ` _ \ / _ \ | | | \ \ / / _ \ '__|",
        @"| |_| | (_| | | | | | |  __/ | |_| |\ V /  __/ |   ",
        @" \____|\__,_|_| |_| |_|\___|  \___/  \_/ \___|_|   "
    };

    // Set Console Colors
    Console.ForegroundColor = ConsoleColor.Red;
    Console.BackgroundColor = ConsoleColor.Black;

    // Print each line with a delay for effect
    foreach (string line in gameOverArt)
    {
        foreach (char c in line)
        {
            Console.Write(c);
            Thread.Sleep(2); // Delay for dramatic effect
        }
        Console.WriteLine();
    }

    Console.ResetColor();
    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
}

static void PrintYouWonPhrase()
{
    Console.Clear();
    // ASCII Art for "You Won!"
    string[] youWonArt = {
        @" ██    ██  ██████  ██    ██     ██     ██  ██████  ███    ██ ",
        @" ██    ██ ██    ██ ██    ██     ██     ██ ██    ██ ████   ██ ",
        @" ██    ██ ██    ██ ██    ██     ██  █  ██ ██    ██ ██ ██  ██ ",
        @"  ██  ██  ██    ██ ██    ██     ██ ███ ██ ██    ██ ██  ██ ██ ",
        @"   ████    ██████   ██████       ███ ███   ██████  ██   ████ ",
        @"                                                             ",
        @"                         YOU WON!                            "
    };

    // Set Console Colors
    Console.ForegroundColor = ConsoleColor.Green;
    Console.BackgroundColor = ConsoleColor.Black;

    // Print each character with a delay for a dramatic effect
    foreach (string line in youWonArt)
    {
        foreach (char c in line)
        {
            Console.Write(c);
            Thread.Sleep(5); // Delay per character for suspense
        }
        Console.WriteLine();
        Thread.Sleep(10); // Slight delay after each line
    }

    Console.ResetColor();
    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
}