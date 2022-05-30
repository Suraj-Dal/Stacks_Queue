StackQueue.Stack stack = new StackQueue.Stack();
int choice = 1;
while (choice != 2)
{
    Console.WriteLine("Enter data to add in Stack: ");
    int data = Convert.ToInt32(Console.ReadLine());
    stack.addData(data);
    Console.WriteLine("1.Add\n2.Exit");
    choice = Convert.ToInt32(Console.ReadLine());
}