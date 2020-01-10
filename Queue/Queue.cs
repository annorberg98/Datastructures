using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.Queue
{
    class Queue<T> : IQueue<T>
    {
        private T[] arrayData;
        private int N;

        private static int front, rear, capacity;


        public Queue(int size)
        {
            front = rear = 0;
            capacity = size;
            arrayData = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if(capacity == rear)
            {
                throw new OverflowException("Queue is full");
            } else
            {
                arrayData[rear] = item;
                rear++;
            }
            return;
        }

        public T Dequeue()
        {
            if(front == rear)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            // shift all the elements from index 2 till rear  
            // to the right by one  
            else
            {
                for(int i = 0; i < rear; i++)
                {
                    arrayData[i] = arrayData[i + 1];
                }

                if(rear < capacity)
                {
                    arrayData[rear] = default(T);
                }
                rear--;
            }
            return default(T);
        }        
    }
}
