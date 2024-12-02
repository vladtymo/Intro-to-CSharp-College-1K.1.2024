string email = "vlad.tymo@gmail.com";

Console.WriteLine($"Email address: {email}");

Console.WriteLine($"First s: {email[0]}");

if (email[0] == '.')
    Console.WriteLine("Error");
else
    Console.WriteLine("Normal daki!");

if (email.Contains("@") && email.Contains("com"))
    Console.WriteLine("Has @ and com inside!");

Console.WriteLine(email.Replace('.', '_'));

email = " vlad.tymo@gmail.com  ";
email = email.Trim();
Console.WriteLine($"Trimmed: {email}");

Console.WriteLine($"Removed: {email.Remove(10)}");

email.ToLower();
email.ToUpper();

string line = "Hello, Nazar! Ejyk Pyjyk, super star!";
string[] words = line.Split(' ', ',', '!').Where(x => x != "").ToArray();

foreach (var i in words)
    Console.WriteLine(i);

// for (int i = 0; i < words.Length; i++)
//     Console.WriteLine(words[i]);