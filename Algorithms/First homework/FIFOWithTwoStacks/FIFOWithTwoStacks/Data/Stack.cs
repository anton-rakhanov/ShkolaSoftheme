using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFOWithTwoStacks.Data
{
    public class Stack
    {
        private int[] _arrayStack;

        private const int _defaultSizeOfStack = 10;

        public int StackCounter { get; private set; }

        public int StackSize { get; private set; }

        public Stack()
        {
            StackCounter = 0;
            _arrayStack = new int[_defaultSizeOfStack];
            StackSize = _defaultSizeOfStack;
        }

        public Stack(int stackSize)
        {
            if(stackSize <= 0)
            {
                Console.WriteLine("Invalid data input");
                throw new ArgumentException();
            }
            else
            {
                StackCounter = 0;
                _arrayStack = new int[stackSize];
                StackSize = stackSize;
            }
        }

        public void Push(int element)
        {
            if (StackCounter >= StackSize)
            {
                Console.WriteLine("Stack is full, you can't push anymore");
            }
            else
            {
                _arrayStack[StackCounter++] = element;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty, there is no element that you could pop");
                throw new InvalidOperationException();
            }
            else
            {
                return _arrayStack[--StackCounter];
            }
        }

        public bool IsEmpty()
        {
            if(StackCounter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
