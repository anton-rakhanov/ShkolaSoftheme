using System;

namespace DoubleLinkedList.Data
{
    public class Node<T> where T: class
    {

        public T Data { get; set; }


        public Node<T> Next { get; set; }


        public Node<T> Prev { get; set; }
        

        public Node(T data)
        {
            this.Data = data;
        }

    }
}
