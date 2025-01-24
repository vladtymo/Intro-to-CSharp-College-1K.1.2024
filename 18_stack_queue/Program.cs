// ----------- Stack -----------
Stack<string> stack = new();

stack.Push("Ivan");
stack.Push("Nazar");
stack.Push("Olga");
stack.Push("Kolya");
stack.Push("Vika");

Console.WriteLine(stack.Peek()); // відобразити елемент на черзі
Console.WriteLine("Stack size: " + stack.Count);

while (stack.Count > 0)
    Console.WriteLine(stack.Pop());

Console.WriteLine("Stack is empty!\n");

// ----------- Queue -----------
Queue<string> queue = new();

queue.Enqueue("Ivan");
queue.Enqueue("Nazar");
queue.Enqueue("Olga");
queue.Enqueue("Kolya");
queue.Enqueue("Vika");

Console.WriteLine(queue.Peek()); // відобразити елемент на черзі
Console.WriteLine("Queue size: " + queue.Count);

while (queue.Count > 0)
    Console.WriteLine(queue.Dequeue());

Console.WriteLine("Queue is empty!");

// ---------- Stack -----------
Stack<char> brackets = new();
Dictionary<char, char> pairs = new()
{
    // ключ = значення
    [')'] = '(',
    [']'] = '[',
    ['}'] = '{',
    ['>'] = '<',
};

string expression = "2 + 2 ({x- x}) <{9 * 7 (4 + 4) {y + x}}>";

foreach (var s in expression)
{
    // якщо це відкриваюча дужка
    if (pairs.Values.Contains(s))
        brackets.Push(s);

    if (pairs.Keys.Contains(s))
        if (pairs[s] == brackets.Pop())
            Console.WriteLine($"{s} is closed!");
        else
            Console.WriteLine($"{s} does not closed!");
}

if (brackets.Count == 0)
    Console.WriteLine("Expression is correct!");
else
    Console.WriteLine("Expression is incorrect!");

// ---- Tower of Hanoi -----
Stack<int> tower1 = new();
Stack<int> tower2 = new();
Stack<int> tower3 = new();

tower1.Push(4);
tower1.Push(3);
tower1.Push(2);
tower1.Push(1);

// Завдання: перекласти всі диски з вежі 1 на вежу 3.
// єдина умова: не можна класти більший диск на менший

tower2.Push(tower1.Pop());  
tower3.Push(tower1.Pop());
tower3.Push(tower2.Pop());

tower2.Push(tower1.Pop());
tower1.Push(tower3.Pop());
tower2.Push(tower3.Pop());
tower2.Push(tower1.Pop());

tower3.Push(tower1.Pop());
tower3.Push(tower2.Pop());
tower1.Push(tower2.Pop());
tower2.Push(tower3.Pop());
tower3.Push(tower1.Pop());

tower1.Push(tower3.Pop());
tower1.Push(tower2.Pop());
tower3.Push(tower2.Pop());
tower2.Push(tower1.Pop());
tower3.Push(tower1.Pop());
tower3.Push(tower2.Pop());

Console.WriteLine("----- Tower 1 -----");
foreach (var disk in tower1)
    Console.WriteLine($"Disk: {disk}");

Console.WriteLine("----- Tower 2 -----");
foreach (var disk in tower2)
    Console.WriteLine($"Disk: {disk}");

Console.WriteLine("----- Tower 3 -----");
foreach (var disk in tower3)
    Console.WriteLine($"Disk: {disk}");