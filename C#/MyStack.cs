using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyStack
    {
        Stack<int> stack;
        public MyStack()
        {
            stack = new Stack<int>();
        }

        public void Push(int x)
        {
            stack.Push(x);
        }

        public int Pop()
        {
            return stack.Pop();
        }

        public int Top()
        {
            return stack.Last();
        }

        public bool Empty()
        {
            return stack.Count == 0;
        }
    }
}
