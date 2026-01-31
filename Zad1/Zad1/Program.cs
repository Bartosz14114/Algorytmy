class LinkedList
{
    Node first = null;
    public Object First
    {
        get { return first?.Data; }
    }
    public void AddFirst(Object data)
    {
        first = new Node(data, first);
    }
    public Object RemoveFirst()
    {
        Node oldNode = first;
        if (oldNode == null)
            return null;
        first = oldNode.Next;
        return oldNode.Data;
    }
    public void AddLast(Object data)
    {
        if (first == null)
        {
            first = new Node(data, null);
            return;
        }

        Node current = first;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = new Node(data, null);
    }
    class Node
    {
        public Object Data;
        public Node Next;
        public Node(Object data, Node next)
        {
            Data = data;
            Next = next;
        }
    }
}