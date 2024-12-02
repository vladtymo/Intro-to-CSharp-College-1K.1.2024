void PrintList<MyType>(List<MyType> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine($"Element: {list[i]}...");
    }
}

List<int> scores = new() { 10, 50 };

scores.Add(957);
scores.Add(1100);
scores.Add(1001);
scores.Add(2099);
scores.Add(2200);

Console.WriteLine($"Count: {scores.Count}");
Console.WriteLine($"Average: {scores.Average()}");
Console.WriteLine($"Sum: {scores.Sum()}");
Console.WriteLine($"Max: {scores.Max()}");
Console.WriteLine($"Min: {scores.Min()}");

Console.WriteLine(scores);

for (int i = 0; i < scores.Count; i++)
{
    Console.WriteLine($"Score: {scores[i]}...");
}

List<string> countries = new()
{
    "Ukraine", 
    "France", 
    "Italy", 
    "Spain", 
    "USA", 
    "Andora", 
    "Antlantida", 
    "Abidna", 
    "Canada"
};

Console.WriteLine($"Italy: {countries.Contains("Italy")}");
Console.WriteLine($"China: {countries.Contains("China")}");

if (countries.Contains("China"))
{
    countries.Add("Japan");
    Console.WriteLine("Japan added together with China!");
}

if (countries.Contains("France"))
    countries.Remove("Germany");

countries.Sort();
countries.Reverse();

Console.WriteLine("------ Sorted Countries -------");
PrintList(countries);

int result = scores.Find((x) => x > 2000);
Console.WriteLine($"Found: {result}");

string? aa = countries.Find((country) => country.First() == 'A' && country.Last() == 'a');
Console.WriteLine($"Country: {aa}");
