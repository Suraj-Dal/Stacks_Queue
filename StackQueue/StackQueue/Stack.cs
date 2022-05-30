using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StackQueue
{
    internal class Stack
    {
        
        Node top;
        public void StackQueue()
        {
            this.top = null;
        }
        public void addData(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("Data added at the top: "+ data);
        }
        public void stackPeak()
        {
            if (this.top == null)
                Console.WriteLine("Stack is Empty.");
            else
                Console.WriteLine("Data at the peak of stack is: "+ this.top.data +"\n");
        }
        public void popData()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty.");
                return;
            }
            Console.WriteLine(this.top.data + " is popped from stack.\n");
            this.top = this.top.next;
            stackPeak();
        }
    }
}
