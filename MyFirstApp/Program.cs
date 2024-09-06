// ------------------------- вивід на консоль
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

// скидуємо кольори на стандартні
Console.ResetColor();

// ------------------------- змінні
// створення змінної: тип назва = значення;

// -------- типи даних:
// string - пошта, адреса, імя, колір
// short/int float/double - вік, ціна, ріст, ширина

// формат назви: accountLogin productPrice 
string username = "anonymous";

username = "Blalba";
username = "no name";

Console.Write("Enter your name: ");
username = Console.ReadLine();

// інтерполяція рядка: $"...{вираз}..."
Console.WriteLine($"Hello, dear {username}!");

// ------------------------- ЗАВДАННЯ: запитати рік народження та показати вік
Console.Write("Enter your birth year: ");
int dateOfBirth = int.Parse(Console.ReadLine());

Console.WriteLine($"You are {2024 - dateOfBirth} years old!");