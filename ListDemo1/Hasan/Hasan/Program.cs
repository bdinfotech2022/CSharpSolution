using System;
using System.Collections.Generic;  // by default
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasan
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Stack<int> myStack = new Stack<int>();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);

            Console.WriteLine(string.Join(", ", myStack));
            myStack.Pop();
            Console.WriteLine(string.Join(", ", myStack));

            myStack.Pop();
            Console.WriteLine(string.Join(", ", myStack));

            Console.WriteLine(myStack.Count());

            Console.WriteLine(myStack.Contains(6));

           // myStack.Clear();
            Console.WriteLine();

        foreach(int i in myStack)
            {
                Console.WriteLine(i);
            }








            Queue<int> numberQueue = new Queue<int>();

            numberQueue.Enqueue(101);
            numberQueue.Enqueue(505);
            numberQueue.Enqueue(606);
            numberQueue.Enqueue(202);
            numberQueue.Enqueue(303);
            numberQueue.Enqueue(404);
            numberQueue.Enqueue(101);


            Console.WriteLine(string.Join(", ", numberQueue));

            // Console.WriteLine(numberQueue.Peek());    the very first item from the queue without removing it

            Console.WriteLine(numberQueue.Count);











        }
    }
}
