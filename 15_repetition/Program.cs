// типи даних

using System.Threading.Channels;

byte weather = 22;      // 1 b

short age = 30;         // 2 b

int quantity = 1045;    // 4 b

float width = 52.90f;   // 4 b

double koef = 45.46445534; // 8

decimal price = 45.46445534m; // 16

string surname = "Surname"; // 2 b per symbol

char gender = 'M'; // 2 b

// арифметичні оператори: + - * / % (остача від ділення)

Console.WriteLine(10 % 2); // 0
Console.WriteLine(11 % 2); // 1
Console.WriteLine(12 % 2); // 0

Console.WriteLine(24 % 7); // 3 = 24 / 7 = 3.2

// логічні оператори: > < >= <= == !=
// обєднання: && (і) || (або)

Console.WriteLine(30 >= 29); // true
Console.WriteLine(52 == 52); // true
Console.WriteLine(52 != 52); // false

price = int.Parse(Console.ReadLine());

if (price >= 5000)
    Console.WriteLine("You have a bonus of 50%");

string name = Console.ReadLine();

if (char.IsDigit(name[0]))
    Console.Write("Digit");

while (name[0] != 'A')
{
    Console.Write("First lette must be A!... Enter again: ");
    name = Console.ReadLine();
}

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.Write(".");
}
Console.WriteLine();

double[] prices = new double[] { 120, 10, 3079, 52.52, 10.95, 890 };

for (int i = 0; i < prices.Length; i++)
{
    if (prices[i] >= 100)
        Console.Write(prices[i] + " ");
}
Console.WriteLine();

int magicNumber = new Random().Next(500, 1000); // від включно і до не включно
Console.WriteLine(magicNumber);

