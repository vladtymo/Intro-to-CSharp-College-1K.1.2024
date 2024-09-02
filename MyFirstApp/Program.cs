// це рядковий коментар
// Ctrl + F5 - запуск програми

using System.Text;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello! How are you?");

// cw + TAB = Console.WriteLine();
Console.WriteLine("Enter your age:");

// WriteLine - ставить новий рядок вкінці
// Write - не переводить на новий рядок
Console.WriteLine("My name is Vlad!");
Console.WriteLine("My name is Vlad!");

Console.Write("Good");
Console.Write("Good");

Console.OutputEncoding = Encoding.UTF8;

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Yellow;

// Escape sequences: \n \t \' \"
Console.WriteLine("\n\nПривіт!\nЯк\tв тебе\t\t\"справи\"?");
