StackQueue.Stack stack = new StackQueue.Stack();
StackQueue.Queue queue = new StackQueue.Queue();
Console.WriteLine("Which Data Structure you want to choose:\n1.Stack\n2.Queue\nEnter your choice:");
int ds = Convert.ToInt32(Console.ReadLine());
switch (ds)
{
    case 1:
        Console.WriteLine("Stack Operations\n0.Exit\n1.Push Data\n2.Pop Data\n3.Display Peak\nEnter your choice:");
        int choice = Convert.ToInt32(Console.ReadLine());
        while (choice != 0)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter data to add in Stack: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    stack.addData(data);
                    break;
                case 2:
                    stack.popData();
                    break;
                case 3:
                    stack.stackPeak();
                    break;
                default:
                    Console.WriteLine("Invalid Chioce.");
                    break;
            }
            Console.WriteLine("Stack Operations\n0.Exit\n1.Push Data\n2.Pop Data\n3.Display Peak\nEnter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
        }
        break;
    case 2:
        Console.WriteLine("Queue Operations\n0.Exit\n1.Enqueue\n2.Dequeue\n3.Display\nEnter your choice:");
        int ch = Convert.ToInt32(Console.ReadLine());
        while (ch != 0)
        {
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter data to add in Queue: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    queue.Enqueue(data);
                    break;
                case 2:
                    queue.Dequeue();
                    break;
                case 3:
                    queue.Display();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine("Queue Operations\n0.Exit\n1.Enqueue\n2.Dequeue\n3.Display\nEnter your choice:");
            ch = Convert.ToInt32(Console.ReadLine());
        }
        break;
}
