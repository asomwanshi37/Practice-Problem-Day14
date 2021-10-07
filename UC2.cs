using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Stack_UC1_UC2
    {
        private NodeStack top;

        public void LinkedListStack()
        {
            this.top = null;
        }
	internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);
        }

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }

        internal void EmptyStack()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            this.top=null;
        }

        public void Printstack()
        {
            NodeStack temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
