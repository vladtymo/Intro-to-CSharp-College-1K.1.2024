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