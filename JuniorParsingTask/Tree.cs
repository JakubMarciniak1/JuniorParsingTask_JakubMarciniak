namespace JuniorParsingTask;

public class Tree
{
    public readonly Node Root;
    //public int Size { get; set; }

    public Tree(Node root)
    {
        Root = root;
    }

    public bool TryGetNode(string value, out Node node)
        =>  TryGetNode_Core(value, out node, Root);

    private bool TryGetNode_Core(string value, out Node node, Node currentNode)
    {
        if (value == currentNode.Value)
        {
            node = currentNode;
            return true;
        }

        for (int i = 0; i < currentNode.Children.Count; i++)
        {
            if (TryGetNode_Core(value, out node, currentNode.Children[i]))
                return true;
        }
        node = null;
        return false;
    }





}