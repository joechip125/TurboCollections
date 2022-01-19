using System;

namespace TurboCollections
{

    public class Node<T>
    {
        public Node<T> Next;
        public Node<T> Previous;
        public T someData;
        
        public Node(T d)
        {
            someData = d;
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

        public void Remove()
        {
            
        }
        
        public void PrintList()
        {
            Node<T> n = Head;
            while (n != null) 
            {
                Console.Write(n.someData + " ");
                n = n.Next;
            }
        }
        
        
        public void Insert(T someValue)
        {
            Node<T> newNode = new Node<T>(someValue)
            {
                Next = Head
            };

            Head = newNode;
        }
    }
}