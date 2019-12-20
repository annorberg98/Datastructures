using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    class Stack<T>
    {
        private T[] arrayData; //Array of items
        private int N; //Number of elements on the Stack

        public Stack()
        {
            this.arrayData = new T[1];
        }

        public void Push(T item)
        {
            if (N == this.Size)
                this.Rezise(2 * this.Size);
            arrayData[N++] = item;
        }

        public T Pop()
        {
            T item = arrayData[--N];
            arrayData[N] = default(T);
            if (N > 0 && N == this.Size / 4)
                this.Rezise(this.Size / 2);
            return item;
        }

        public T Peek()
        {
            if (this.IsEmpty)
                throw new InvalidOperationException("Exception: Empty stack");
            return arrayData[--N];
        }

        private void Rezise(int capacity)
        {
            T[] copy = new T[capacity];
            for(int i = 0; i < Size; i++)
                copy[i] = arrayData[i];
            arrayData = copy;
        }

        public int Size
        {
            get { return this.arrayData.Length;  }
        }

        public Boolean IsEmpty
        {
            get { return N == 0; }
        }
    }
}
