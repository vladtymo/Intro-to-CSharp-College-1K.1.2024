//Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
using System.Diagnostics;
using _8_shake;

Console.CursorVisible = false;
var rand = new Random();

int score = 0;

Queue<Coord> coords = new();

// швидкість руху змійки
int delay = 300;

// розмір поля
const int sizeX = 16 * 2;
const int sizeY = 16;

const int empty = 0;
const int fruit = 1;

// координати голови змійки
int snakeX = sizeX / 2; 
int snakeY = sizeY / 2;

coords.Enqueue(new(snakeX, snakeY));

// "Left", "Right", "Up", "Down"
string direction = "Right";

int[,] map = new int[sizeY, sizeX]; // на початку все 0

Console.Clear();
PrintMap();
PrintSnake();
PutApple();

// очікуємо нажаття для старту
Console.ReadKey();

while(true)
{
    GetDirection();
    if (!Move()) break;

    if (IsApple())
        EatApple();

    Thread.Sleep(delay);
}

Console.WriteLine("Game Over!");
Console.ReadKey();

void IncreaseSpeed()
{
    if (delay > 50)
        delay -= 10;
}

void GetDirection()
{
    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey().Key;

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
    var head = new Coord(snakeX, snakeY);
    
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
    return map[snakeY, snakeX] == fruit;
}

void EatApple()
{
    map[snakeY, snakeX] = empty;
    PutApple();
    score++;
    PrintScore();
    IncreaseSpeed();
}
void ClearSnake()
{
    var tail = coords.Dequeue();
    
    Console.SetCursorPosition(tail.X + 1, tail.Y + 1);
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(" ");
}

void PrintSnake()
{
    Console.SetCursorPosition(snakeX + 1, snakeY + 1);
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("@");
}
void PrintBody(Coord head)
{
    Console.SetCursorPosition(head.X + 1, head.Y + 1);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write((char)219);
}

void PrintScore()
{
    Console.SetCursorPosition(0, sizeY + 2);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Score: {score}");
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
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("*");
}

bool IsWin()
{
    return score == 33;
}
void PutApple()
{
    int x, y;
    do
    {
        x = rand.Next(sizeX);
        y = rand.Next(sizeY);

    } while (map[y, x] != empty);
    
    map[y, x] = fruit;
    PrintApple(x, y);
}