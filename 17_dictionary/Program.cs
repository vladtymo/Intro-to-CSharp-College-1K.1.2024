List<string> fruits = new() { "apple", "banana", "orange", "strawberry" };

fruits[1] = "lemon";

// колекція словник - зберігає елементи як пара (ключ + значення)
Dictionary<string, string> cars = new()
{
    { "AA5656BB", "Audi A8 Sport" },
    { "777", "Rolls-Royce Spectre" },
    { "DR3435GG", "Toyora Prius" },
    { "BB7878FF", "Kia Sportage" },
    { "4554", "Lamborthini Huracan" },
};

// змінюємо значення
cars["777"] = "Rolls-Royce Spectre Laxury";

// додаємо нове значення
cars["1000"] = "Lada Calina";
cars.Add("2000", "Nissan GT-R");

foreach (var i in cars)
{
    Console.WriteLine($"{i.Key}: {i.Value}");
}

cars.Remove("2000");

if (cars.ContainsKey("2000"))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Car with number [2000] found!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Car with number [2000] not found!");
}
Console.ResetColor();

cars.Clear();