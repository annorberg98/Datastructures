using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.Queue
{
    interface IQueue<T>
    {
        void Enqueue(T item);

        T Dequeue();
    }
}
