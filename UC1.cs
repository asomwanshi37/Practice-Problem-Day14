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

        // UC1 Push to Stack
        internal void Push(int value)
        {
            NodeStack node = new NodeStack(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
    }
}
