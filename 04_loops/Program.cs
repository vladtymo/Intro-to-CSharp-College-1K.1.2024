Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");

Console.Write("Enter iteration count: ");
int number = int.Parse(Console.ReadLine()!);

// for - цикл який дозволяє створити лічильник
// шаблон:
/* 
    for(створення змінний [1]; умови [2]; вираз [4]) 
    { 
        код [3]
    }
*/

for (int count = 0; count < number; count++)
{
    Console.WriteLine("...Iteration...");
}