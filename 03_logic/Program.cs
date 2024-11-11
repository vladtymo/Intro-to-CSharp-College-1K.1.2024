// Завдання: користувач вводить рік народження, перевірити чи може він купити вино

Console.Write("Enter your birth year: ");

int birthYear = int.Parse(Console.ReadLine());
int age = 2024 - birthYear;

// логічні оператори: > < >= <= == !=
// всі логічні оператори повертають bool (true/false)

// перевірити чи користувач повнолітній
if(age >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You can buy a wine!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You can not buy a wine! Suggest milk)");
    Console.ResetColor();
}
      
// Завдання: користувач вводить номер дня в тижні, відобразити його назву
Console.WriteLine("Enter weekday (1-7):");
int weekday = int.Parse(Console.ReadLine());

if (weekday == 1) 
{
    Console.WriteLine("Monday!");
}
else if (weekday == 2) 
{
    Console.WriteLine("Tuesday!");
}
else if (weekday == 3) 
    Console.WriteLine("Wednesday!");
else if (weekday == 4) 
    Console.WriteLine("Thursday!");
else
    Console.WriteLine("Invalid value!");
    
// switch - конструкція множинного вибору
switch (weekday) {
    case 1: Console.WriteLine("Monday!"); break;
    case 2: Console.WriteLine("Tuesday!"); break;
    case 3: Console.WriteLine("Wednesday!"); break;
    case 4: Console.WriteLine("Thursday!"); break;
    default: Console.WriteLine("Invalid value!"); break;
}

// Завдання: користувач вводить напрямок, показати реверсивний
Console.WriteLine("Enter direction:");
string direction = Console.ReadLine();

switch (direction.ToLower()) {
    case "forward": Console.WriteLine("Backward!"); break;
    case "backward": Console.WriteLine("Forward!"); break;
    case "left": Console.WriteLine("Right!"); break;
    case "right": Console.WriteLine("Left!"); break;
}
