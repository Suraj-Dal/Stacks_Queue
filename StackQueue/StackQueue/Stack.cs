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
    }
}
