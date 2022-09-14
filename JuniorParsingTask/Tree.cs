namespace JuniorParsingTask;

public class Tree
{
    public readonly Node Root;
    public int Size { get; set; }

    public Tree(Node root)
    {
        Root = root;
    }
}