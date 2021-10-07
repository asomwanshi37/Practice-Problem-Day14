using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Queue_UC3_UC4
    {
        NodeQueue head, tail;

        public void Queue()
        {
            this.head = this.tail = null;
        }

        //UC3 to add a queue
        public void enqueue(int key)
        {

            
            NodeQueue temp = new NodeQueue(key);

            
            if (this.tail == null)
            {
                this.head = this.tail = temp;
                return;
            }

            
            this.tail.next = temp;
            this.tail = temp;
            
        }
    }
}
