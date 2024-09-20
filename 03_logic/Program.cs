// Завдання: користувач вводить рік народження, перевірити чи може він купити вино

Console.Write("Enter your birth year: ");

int birthYear = int.Parse(Console.ReadLine());
int age = 2024 - birthYear;

// логічні оператори: > < >= <= == !=

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