using System;


namespace MyCollections.Collections
{
    public class Queue<T>
    {

        private T[] _arrayQueue;


        private const int _defaultSizeOfQueue = 10;

        
        private int _head;


        private int _tail;


        private int _counter = 0;


        public int QueueSize { get; private set; }


        public Queue()
        {
            _arrayQueue = new T[_defaultSizeOfQueue];

            QueueSize = _defaultSizeOfQueue;

            _head = 0;
            _tail = 0;
        }

        public Queue(int queueSize)
        {

            if (QueueSize <= 0)
            {
                Console.WriteLine("Invalid data input");
                throw new ArgumentException();
            }
            else
            {
                _arrayQueue = new T[queueSize];

                QueueSize = queueSize;

                _head = 0;
                _tail = 0;
            }
        }

        public void Enqueue(T newElement)
        {

            if(_counter > QueueSize - 1)
            {
                Console.WriteLine("Sorry, but queue is already full, please dequeue and try again!");
            }
            else
            {

                _arrayQueue[_tail] = newElement;

                _tail++;

                if(_tail >= QueueSize)
                {
                    _tail = 0;
                }

                _counter++;

            }
        }

        public T Dequeue()
        {

            if (IsEmpty())
            {
                Console.WriteLine("Sorry, but queue is empty, first you must enqueue!");
                throw new InvalidOperationException();
            }
            else
            {

                if (_head >= QueueSize)
                {
                    _head = 0;
                }

                _counter--;

                return _arrayQueue[_head++];

            }
        }

        public bool IsEmpty()
        {

            if(_counter == 0)
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
