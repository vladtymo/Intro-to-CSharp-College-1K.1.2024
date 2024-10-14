// створення гри П'ятнашки

const int size = 4;
int emptyX = 2;
int emptyY = 2;

int[,] puzzle = new int[size, size]
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 0, 12},
    {13, 14, 15, 11}
};
ShowPuzzle();

while (true)
{
    var key = Console.ReadKey().Key;
    
    switch (key)
    {
        case ConsoleKey.LeftArrow:
            // left
            Swap(ref puzzle[emptyY, emptyX], ref puzzle[emptyY, emptyX + 1]);
            ++emptyX;
            break;
        case ConsoleKey.RightArrow:
            // right
            Swap(ref puzzle[emptyY, emptyX], ref puzzle[emptyY, emptyX - 1]);
            --emptyX;
            break;
    }

    Console.Clear();
    ShowPuzzle();
}

void ShowPuzzle()
{
    for (int r = 0; r < size; r++)
    {
        for (int c = 0; c < size; c++)
        {
            if (puzzle[r, c] == 0)
                Console.Write("[  ] ");
            else
                Console.Write($"[{puzzle[r, c],2}] ");
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