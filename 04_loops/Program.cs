// Console.WriteLine("Hello");
// Console.WriteLine("Hello");
// Console.WriteLine("Hello");
// Console.WriteLine("Hello");
// Console.WriteLine("Hello");
//
// Console.Write("Enter iteration count: ");
// int number = int.Parse(Console.ReadLine()!); // 10
//
// // for - цикл який дозволяє створити лічильник
// // шаблон:
// /* 
//     for(створення змінний [1]; умови [2]; вираз [4]) 
//     { 
//         код [3]
//     }
// */
//
// for (int count = 0; count < 10; count++)
// {
//     Console.WriteLine("...Iteration...");
// }
//
// // вічний цикл
//
// Console.Write("Enter your name: ");
// string name = Console.ReadLine();
//
// while (!char.IsUpper(name[0]))
// {
//     Console.WriteLine("Name must start with upper case letter!");
//     Console.Write("Enter name again: ");
//     name = Console.ReadLine();
// }
//
//
// int level = 0;
//
// do 
// {
//     Console.Write("Enter game level (1-3): ");
//     level = int.Parse(Console.ReadLine());
// } while (level < 1 || level > 3);
//
// Console.WriteLine("Have a good day!");

// -------- цикли
// while(умову) { }

Console.Write("Enter age: ");
int age = int.Parse(Console.ReadLine());

while (age < 0)
{
    Console.WriteLine("Invalid age. Please try again: ");
    age = int.Parse(Console.ReadLine());
}

int discount;
do 
{
    Console.WriteLine("Enter discount (0-100%): ");
    discount = int.Parse(Console.ReadLine());
} while(discount < 0 || discount > 100);

int width = 12;

for (int i = 0; i < width; i++)
{
    Console.Write("|");
}