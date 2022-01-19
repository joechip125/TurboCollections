using System;

namespace TurboCollections
{

    public class Node<T>
    {
        public Node<T> Next;
        public Node<T> Previous;
        public T Data;
        
        public Node(T d)
        {
            Data = d;
            Next = null;
        }
    }


    public class TurboLinkedStack<T>
    {
        public Node<T> Head;
       
        public TurboLinkedStack(T headValue)
        {
            Head = new Node<T>(headValue);
        }

        public void RemoveFromFront()
        {
            Node<T> n = Head.Next;
            Head = n;
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
        
        
        public void InsertAtFront(T someValue)
        {
            Node<T> newNode = new Node<T>(someValue)
            {
                Next = Head
            };

            Head = newNode;
        }
    }
}