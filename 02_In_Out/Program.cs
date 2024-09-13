//Console.WriteLine(2 + 2 * 2);   // 6
//Console.WriteLine((2 + 2) * 2); // 8

//------------- Завдання: користувач вводить милі, а програма повинна відобразити в км

// 1. введення значення
// 2. обрахунок значення
// 3. показ результату

Console.WriteLine("------------- Miles to Km Converter -------------");

Console.Write("Enter miles: ");

double miles = double.Parse(Console.ReadLine()!);

double kms = miles * 1.60934;

Console.WriteLine($"Result: {kms} km");

//------------- Завдання: користувач вводить радіус кола, визначити та показати його площу

Console.WriteLine("------------- Calculate Circle Area -------------");

Console.Write("Enter radius (cm): ");

double r = double.Parse(Console.ReadLine()!);
double area = Math.PI * Math.Pow(r, 2);

double rounded = Math.Round(area, 1);

Console.WriteLine($"Circle area: {rounded} cm");

//------------- Завдання: користувач вводить периметр квадрату, а додаток відображає довжину сторони

Console.WriteLine("------------- Calculate Side Length -------------");

Console.Write("Enter P (cm): ");

double p = double.Parse(Console.ReadLine()!);
double side = p / 4;

Console.WriteLine($"Square side length: {side} cm");