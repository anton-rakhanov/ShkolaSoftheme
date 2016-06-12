using System;


namespace DoubleLinkedList.Data
{
    public class DoubleLinkList<T> where T: class
    {

        private Node<T> _head;


        private Node<T> _current;


        private Node<T> _tail;


        private uint _listLenght;


        public uint ListLenght
        {
            get { return _listLenght; }
        }


        public bool isEmpty
        {
            get
            {
                return _listLenght == 0;
            }
        }


        public DoubleLinkList()
        {
            _listLenght = 0;

            _head = null;
            _current = null;
            _tail = null;
        }


        public void PushFront(T newElement)
        {

            Node<T> newNode = new Node<T>(newElement);


            if (_head == null)
            {
                _head = _tail = newNode;
            }
            else
            {

                newNode.Next = _head; 


                _head = newNode; //_head и newNode указывают на один и тот же объект


                newNode.Next.Prev = _head;

            }


            _listLenght++;

        }


        public Node<T> PopFront()
        {

            if (_head == null)
            {
                throw new InvalidOperationException();
            }
            else
            {

                Node<T> popedNode = _head;


                if (_head.Next != null)
                {
                    _head.Next.Prev = null;
                }


                _head = _head.Next;


                _listLenght--;


                return popedNode;
            }
        }


        public void PushBack(T newElement)
        {

            Node<T> newNode = new Node<T>(newElement);


            if (_head == null)
            {
                _head = _tail = newNode;
            }
            else
            {

                _tail.Next = newNode;


                newNode.Prev = _tail;


                _tail = newNode;

            }


            _listLenght++;
        }


        public Node<T> PopBack()
        {

            if (_tail == null)
            {
                throw new InvalidOperationException();
            }
            else
            {

                Node<T> popedNode = _tail;


                if (_tail.Prev != null)
                {
                    _tail.Prev.Next = null;
                }


                _tail = _tail.Prev;


                _listLenght--;


                return popedNode;

            }
        }


        public void DeleteElement(uint index)
        {

            if (index < 1 || index > _listLenght)
            {
                throw new InvalidOperationException();
            }
            else if (index == 1)
            {
                PopFront();
            }
            else if (index == _listLenght)
            {
                PopBack();
            }
            else
            {

                uint count = 1;


                _current = _head;


                while (_current != null && count != index)
                {
                    _current = _current.Next;
                    count++;
                }


                _current.Prev.Next = _current.Next;


                _current.Next.Prev = _current.Prev;

                _listLenght--;
            }
        }


        public bool Contains(T elementToFind)
        {

            _current = _head;


            while (_current != null)
            {

                if(elementToFind.Equals(_current.Data))
                {
                    return true;
                }


                _current = _current.Next;

            }

            return false;

        }


        public T[] ToArray()
        {

            if(isEmpty)
            {
                return null;
            }
            else
            {

                T[] arrayToReturn = new T[_listLenght];


                int arrIndexIterator = 0;


                _current = _head;


                while (_current != null)
                {
                    arrayToReturn[arrIndexIterator++] = _current.Data;


                    _current = _current.Next;
                }


                return arrayToReturn;
            }
        }

    }
}
