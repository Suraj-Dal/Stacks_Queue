StackQueue.Stack stack = new StackQueue.Stack();
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