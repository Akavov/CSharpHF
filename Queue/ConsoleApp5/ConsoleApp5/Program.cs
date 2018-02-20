using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("first in line");
            int howMany = myQueue.Count;
            myQueue.Clear();
            string takeAlook = myQueue.Peek();
            string getFirst = myQueue.Dequeue();

            Stack<string> myStack = new Stack<string>();
            myStack.Push("first in line");
            myStack.Pop();
            string get = myStack.Peek();
        }
    }
}
