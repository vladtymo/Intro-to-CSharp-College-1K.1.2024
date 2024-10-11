var rand = new Random();

Console.Write("Put your money $: ");
double money = int.Parse(Console.ReadLine());

while (money > 0)
{
    Console.Write("Guess the number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Clear();

    int dice = rand.Next(1, 7);

    DrawDice(dice);

    if (number == dice)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You won! +50%");
        money = Math.Round(money * 1.5, 2, MidpointRounding.ToZero);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You loose! -20%");
        money = Math.Round(money / 1.2, 2, MidpointRounding.ToZero);
    }
    Console.ResetColor();

    Console.WriteLine($"Balance: {money}$");
}

static void DrawDice(int roll)
{
    switch (roll)
    {
        case 1:
            Console.WriteLine("+-------+");
            Console.WriteLine("|       |");
            Console.WriteLine("|   o   |");
            Console.WriteLine("|       |");
            Console.WriteLine("+-------+");
            break;
        case 2:
            Console.WriteLine("+-------+");
            Console.WriteLine("| o     |");
            Console.WriteLine("|       |");
            Console.WriteLine("|     o |");
            Console.WriteLine("+-------+");
            break;
        case 3:
            Console.WriteLine("+-------+");
            Console.WriteLine("| o     |");
            Console.WriteLine("|   o   |");
            Console.WriteLine("|     o |");
            Console.WriteLine("+-------+");
            break;
        case 4:
            Console.WriteLine("+-------+");
            Console.WriteLine("| o   o |");
            Console.WriteLine("|       |");
            Console.WriteLine("| o   o |");
            Console.WriteLine("+-------+");
            break;
        case 5:
            Console.WriteLine("+-------+");
            Console.WriteLine("| o   o |");
            Console.WriteLine("|   o   |");
            Console.WriteLine("| o   o |");
            Console.WriteLine("+-------+");
            break;
        case 6:
            Console.WriteLine("+-------+");
            Console.WriteLine("| o   o |");
            Console.WriteLine("| o   o |");
            Console.WriteLine("| o   o |");
            Console.WriteLine("+-------+");
            break;
    }
}