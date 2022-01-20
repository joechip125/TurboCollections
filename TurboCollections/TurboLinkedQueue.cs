using System;

namespace TurboCollections
{
    public class TurboLinkedQueue<T>
    {
        public Node<T> Head;
        
        public int Count { get; private set; }
       
        public TurboLinkedQueue(T headValue)
        {
            Head = new Node<T>(headValue);
        }
        
        
        public void PrintList()
        {
            Node<T> n = Head;
            while (n != null) 
            {
                Console.Write(n.Data + " ");
                n = n.Next;
            }
        }

        private Node<T> GetLastNode()
        {
            Node<T> n = Head;
            for (int i = 0; i < Count; i++)
            {
                if (n.Next == null)
                {
                    break;
                }
                n = n.Next;
            }
            return n;
        }
        
        public void Enqueue(T item)
        {
            Node<T> n = GetLastNode();
            Node<T> newNode = new Node<T>(item);
            n.Next = newNode;

            Count++;
        }


        public T Peek()
        {
            return GetLastNode().Data;
        }
            
        public T Dequeue()
        {
            Node<T> n = Head;
            T outValue = n.Data;

            for (int i = 0; i < Count; i++)
            {
                if (i == Count - 1)
                {
                    outValue = n.Data;
                    n.Next = null;
                    break;
                }
                n = n.Next;
            }
            
            Count--;

            return outValue;
        }
    }
}