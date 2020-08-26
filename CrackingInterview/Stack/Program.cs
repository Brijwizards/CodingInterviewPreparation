using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Stack
    {
        public int[] stack;
        public int top;
        public int max;
        public Stack(int size)
        {
            stack = new int[size];
            top = -1;
            max = size;
        }
        public void Push(int element)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack overflows");
                return;
            }
            else
            {
                stack[++top] = element;
            }
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }

            int p = stack[top--];
            return p;
        }

        public void PrintStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
