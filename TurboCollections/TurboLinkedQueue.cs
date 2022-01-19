namespace TurboCollections
{
    public class TurboLinkedQueue<T>
    {
        public Node<T> Head;
       
        public TurboLinkedQueue(T headValue)
        {
            Head = new Node<T>(headValue);
        }
    }
}