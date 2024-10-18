// створення гри П'ятнашки
Console.OutputEncoding = System.Text.Encoding.UTF8;

const int size = 4;
int emptyX = size - 1;
int emptyY = size - 1;
const int empty = 16;

int[,] puzzle = new int[size, size]
{
    {1, 2, 3, 4 },
    {5, 6, 7, 8 },
    {9, 10, 11, 12 },
    {13, 14, 15, empty } // порожня комірка має бути вкінці
};

ShufflePuzzle();
ShowPuzzle();

while (true)
{
    var key = Console.ReadKey().Key;
    
    switch (key)
    {
        case ConsoleKey.LeftArrow:
            // left
            if (emptyX < size - 1)
            {
                Swap(ref puzzle[emptyY, emptyX], ref puzzle[emptyY, emptyX + 1]);
                ++emptyX;
            }
            break;
        case ConsoleKey.RightArrow:
            // right
            if (emptyX > 0)
            {
                Swap(ref puzzle[emptyY, emptyX], ref puzzle[emptyY, emptyX - 1]);
                --emptyX;
            }
            break;
        case ConsoleKey.UpArrow:
            // up
            if (emptyY < size - 1)
            {
                Swap(ref puzzle[emptyY, emptyX], ref puzzle[emptyY + 1, emptyX]);
                ++emptyY;
            }
            break;
        case ConsoleKey.DownArrow:
            // dowm
            if (emptyY > 0)
            {
                Swap(ref puzzle[emptyY, emptyX], ref puzzle[emptyY - 1, emptyX]);
                --emptyY;
            }
            break;
    }

    Console.Clear();
    ShowPuzzle();

    CheckFinish();
}

void CheckFinish()
{
    int count = 1;
    for (int r = 0; r < size; r++)
    {
        for (int c = 0; c < size; c++)
        {
            if (puzzle[r, c] != count)
                return;
            ++count;
        }
    }

    Console.WriteLine("Перемога!");
}

void ShufflePuzzle()
{
    var random = new Random();
    
    for (int i = 0; i < size; )
    {
        int x = random.Next(0, size);
        int y = random.Next(0, size);
        
        int x2 = random.Next(0, size);
        int y2 = random.Next(0, size);
        
        if (x == size - 1 && y == size - 1)
            continue;
        if (x2 == size - 1 && y2 == size - 1)
            continue;
        
        Swap(ref puzzle[y, x], ref puzzle[x2, y2]);
        ++i;
    }
}

void ShowPuzzle()
{
    for (int r = 0; r < size; r++)
    {
        for (int c = 0; c < size; c++)
        {
            if (r * size + (c + 1) == puzzle[r, c])
                Console.ForegroundColor = ConsoleColor.Green;
            
            if (puzzle[r, c] == empty)
                Console.Write("[  ] ");
            else
                Console.Write($"[{puzzle[r, c],2}] ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

static void Swap(ref int first, ref int second)
{
    int temp = first;
    first = second;
    second = temp;
}