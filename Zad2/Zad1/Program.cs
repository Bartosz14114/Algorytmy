public class BST
{
    Node Root = null;
    public bool Add(int key)
    {
        if (Root == null)
        {
            Root = new Node(key);
            return true;
        }

        Node current = Root;
        Node parent = null;

        while (current != null)
        {
            if (key == current.Key) return false;

            parent = current;
            if (key < current.Key)
                current = current.Left;
            else
                current = current.Right;
        }

        Node newNode = new Node(key, parent);
        if (key < parent.Key)
            parent.Left = newNode;
        else
            parent.Right = newNode;

        return true;
    }

    public bool Contains(int key)
    {
        Node node = Root;
        while (node != null)
            if (key == node.Key)
                return true;
            else if (key < node.Key)
                node = node.Left;
            else
                node = node.Right;
        return false;
    }

    class Node
    {
        public Node
            Parent = null,
            Left = null,
            Right = null;
        public int
            Key;
        public Node(
            int key,
            Node parent = null
        )
        {
            Key = key;
            Parent = parent;
        }
    }
}