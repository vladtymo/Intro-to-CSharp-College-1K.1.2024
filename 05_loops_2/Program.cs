// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

for (int i = 1; i <= 10; i++) // 0 1 ... 8 9 10
{
    Console.WriteLine(i);
}

for (int i = 10; i >= 1; i--) // 10 9 8 ... 1
{
    Console.WriteLine(i);
}

Console.WriteLine("The the of the program!");

// Завдання: Користувач вводить сторони прямокутника. Відобразити його на консолі символом #
/* 4x3
        ####
        ####
        ####
*/

Console.Write("Enter width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter height: ");
int height = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    // for (int k = 0; k < width; k++)
    // {
    //     Console.Write("#");
    // }
    // Console.WriteLine();    
    Console.WriteLine(new string('3', width));
}

