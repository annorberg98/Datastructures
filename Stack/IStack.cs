using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.Stack
{
    interface IStack<T>
    {
        void Push(T item);

        T Pop();

        T Peek();
    }
}
