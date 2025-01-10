string password = "Qw43er7-1234";

if (password.Length < 8)
    Console.WriteLine("Password must be at least 8 characters long.");

if (password.Contains("1234"))
    Console.WriteLine("Password contains '1234'.");

Console.WriteLine(password.Remove(2, 1));

Console.WriteLine(password.Replace('-', '_'));

Console.WriteLine($"Hidden password: {new string('*', password.Length)}");

if (password.Any(c => char.IsUpper(c)))
    Console.WriteLine("Password has at least one uppercase.");
else
    Console.WriteLine("Password must contain at least one uppercase.");

for (int i = 0; i < password.Length; i += 2)
{
    if (char.IsNumber(password[i]))
        Console.ForegroundColor = ConsoleColor.Green;
    
    Console.Write(password[i]);
    Console.ResetColor();
}

while (!Console.ReadLine().Contains("end"))
{
    Console.WriteLine("Continue...");
}

Console.Write("Enter average rozhides (l/100km): ");
double rozhid = double.Parse(Console.ReadLine());

Console.Write("Enter last month distances (km): ");
int distance = int.Parse(Console.ReadLine());

const float pricePerL = 52.99F;

Console.WriteLine($"Cost of last month: {pricePerL * rozhid / 100 * distance} UAH");

// ------------- Array Algorithms -------------

int[] prices = new int[distance];

List<string> colors = new() {"red", "yellow", "green", "blue", "purple"};

for (int i = 0; i < 5; i++)
{
    Console.Write("Enter color: ");
    colors.Add(Console.ReadLine()!);
}

Console.WriteLine($"List: {string.Join(", ", colors)}");

colors.Add("white");
colors.Remove("purple");
colors.RemoveAt(0);

Console.WriteLine($"Index of orange: {colors.IndexOf("orange")}");

if (colors.Contains("orange"))
    Console.WriteLine("Green color is present!");
    
colors.Sort();
colors.Reverse();

Console.WriteLine($"Color 4-len: {colors.Find(c => c.Length == 4)}");
Console.WriteLine($"Color 1-st upper: {colors.Find(c => char.IsUpper(c[0]))}");

