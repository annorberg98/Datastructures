using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    class LinkedListNode
    {
        public LinkedListNode next;
        public Object data;
    }
    class LinkedList
    {
        private LinkedListNode head;

        public void PrintAllNodes()
        {
            LinkedListNode current = head;
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddLast(Object data)
        {
            if(head == null)
            {
                head = new LinkedListNode();

                head.data = data;
                head.next = null;
            } else
            {
                LinkedListNode toAdd = new LinkedListNode();
                toAdd.data = data;

                LinkedListNode current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }


    }
}
