using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFOWithTwoStacks.Data
{
    public class Queue
    {
        private Stack _tailStack;

        private Stack _headStack;

        public int QueueSize { get; private set; }

        public Queue(Stack firstStack, Stack secondStack)
        {
            if (firstStack == null && secondStack == null)
            {
                Console.WriteLine("Invalid data input");
                throw new ArgumentException();
            }
            else
            {
                this._tailStack = firstStack;
                this._headStack = secondStack;
                QueueSize = _tailStack.StackSize + _headStack.StackSize;
            }
        }

        public void Add(int element)
        {
            if (_tailStack.StackCounter >= _tailStack.StackSize && _headStack.IsEmpty())
            {
                TransferElementsFromTailToHead();
            }
            _tailStack.Push(element);
        }

        public int Take()
        {
            if(_headStack.IsEmpty())
            {
                TransferElementsFromTailToHead();
            }
            return _headStack.Pop();
        }

        private void TransferElementsFromTailToHead()
        {
            while (!_tailStack.IsEmpty())
            {
                _headStack.Push(_tailStack.Pop());
            }
        }
    }
}
