using System;


namespace MyCollections.Collections
{
    public class Stack<T>
    {
        private T[] _arrayStack;

        private const int _defaultSizeOfStack = 10;

        public int StackCounter { get; private set; }

        public int StackSize { get; private set; }

        public Stack()
        {
            StackCounter = 0;
            _arrayStack = new T[_defaultSizeOfStack];
            StackSize = _defaultSizeOfStack;
        }

        public Stack(int stackSize)
        {
            if (stackSize <= 0)
            {
                Console.WriteLine("Invalid data input");
                throw new ArgumentException();
            }
            else
            {
                StackCounter = 0;
                _arrayStack = new T[stackSize];
                StackSize = stackSize;
            }
        }

        public void Push(T element)
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

        public T Pop()
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
            if (StackCounter == 0)
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
