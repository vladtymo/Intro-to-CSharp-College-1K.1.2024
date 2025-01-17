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

