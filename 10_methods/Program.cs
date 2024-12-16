// method: return_type name(parameters) { code }
// void - нічого

void PrintMessage(int count, string separator)
{
    for (int i = 0; i < count; ++i)
    {
        Console.Write("Hello" + separator);
    }
    Console.WriteLine();
}

PrintMessage(7, "-");
PrintMessage(2, " ");
PrintMessage(3, " <!> ");

Console.Write("Enter count: ");
int c = int.Parse(Console.ReadLine());
PrintMessage(c, ", ");

// ...code

void PrintRectangle(int w, int h, char filler, ConsoleColor color)
{
    Console.ForegroundColor = color;
    for (int i = 0; i < h; i++)
    {
        Console.WriteLine(new string(filler, w));
    }
    Console.ResetColor();
}

PrintRectangle(10, 7, '%', ConsoleColor.Yellow);
PrintRectangle(3, 3, '#', ConsoleColor.Blue);