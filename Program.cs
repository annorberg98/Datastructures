using System;

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack<int> stack = new Stack<int>();
            stack.Push(1998);

            Console.WriteLine(stack.Peek());

            Console.ReadLine();
        }
    }
}
