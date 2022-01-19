using System;

namespace TurboCollections
{

    public class Data
    {
        public int aValue;
    }
    
    public class Node
    {
        public Node Next;
        public Node Previous;
        public int data;

        public Node(int d)
        {
            data = d;
            Next = null;
        }
    }


    public class TurboLinkedStack<T>
    {
        public TurboStack<Node> stack = new();

        public Node Head;
        public Node node2;
        public Node node3;
        

        public void Test()
        {
            Head = new Node(1);
            node2 = new Node(2);
            node3 = new Node(3);

            Head.Next = node2;
            node2.Next = node3;
        }
        
        public TurboLinkedStack()
        {
            Head = new Node(4);
            stack.Push(Head);
        }
        
        public void PrintList()
        {
            Node n = Head;
            while (n != null) 
            {
                Console.Write(n.data + " ");
                n = n.Next;
            }
        }
        
        
        public void Insert()
        {
            Node newNode = new Node(5);
            if (stack.Count != 0)
            {
                Node nextNode = stack.Peek();
                newNode.Next = stack.Peek();
            }

            stack.Push(newNode);
        }
    }
}