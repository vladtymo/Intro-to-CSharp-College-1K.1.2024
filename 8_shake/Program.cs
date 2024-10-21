//Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);

Console.CursorVisible = false;

const int delay = 300;

const int sizeX = 16 * 2;
const int sizeY = 16;

const int empty = 0;
const int fruit = 1;

int snakeX = sizeX / 2;
int snakeY = sizeY / 2;

// "Left", "Right", "Up", "Down"
string direction = "Right";

int[,] map = new int[sizeY, sizeX];

PrintMap();
PrintSnake();

while (true)
{
    GetDirection();
    Move();
    Thread.Sleep(delay);

    if (CheckFail())
    {
        Console.WriteLine("Game Over");
        break;
    }
}

Console.ReadKey();

void GetDirection()
{
    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey().Key;

        switch (key)
        {
            case ConsoleKey.LeftArrow:
                direction = "Left";
                break;
            case ConsoleKey.RightArrow:
                direction = "Right";
                break;
            case ConsoleKey.UpArrow:
                direction = "Up";
                break;
            case ConsoleKey.DownArrow:
                direction = "Down";
                break;
        }
    }
        
}

void Move()
{
    ClearSnake();
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
    PrintSnake();
}

bool CheckFail()
{
    return snakeX < 0 || 
           snakeX >= sizeX || 
           snakeY - 2 < 0 || 
           snakeY - 2 >= sizeY;
}

void ClearSnake()
{
    Console.SetCursorPosition(snakeX + 1, snakeY + 1);
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("#");
}
void PrintSnake()
{
    Console.SetCursorPosition(snakeX + 1, snakeY + 1);
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("@");
}

void PrintMap()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    for (int y = 0; y < sizeX + 2; y++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
    
    for (int y = 0; y < sizeY; y++)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("#");
        
        for (int x = 0; x < sizeX; x++)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (map[y, x] == empty)
                Console.Write("#");
        }
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("#");
        
        Console.WriteLine();
    }
    
    Console.ForegroundColor = ConsoleColor.DarkRed;
    for (int y = 0; y < sizeX + 2; y++)
    {
        Console.Write("#");
    }
    
    Console.ResetColor();
}

