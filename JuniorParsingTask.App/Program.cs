using JuniorParsingTask;
using System.ComponentModel.Design.Serialization;


//tree for searching
Tree tree = TreeService.Create();

Console.WriteLine(tree.Size);

Console.WriteLine(tree.Root.Value); //node root
Console.WriteLine(tree.Root.Children.Count); //tree root

Console.WriteLine(tree.Root.Children[0].Children.Count);

Console.WriteLine("Reader");
Read();

Console.WriteLine("TEST");
for (int i = 0; i < tree.Root.Children.Count; i++)
{
    Node z = tree.Root.Children[i];
    Console.WriteLine(z.Value);

    Console.WriteLine(TryGetNode("xyz",out z));
    tree.Root.Children[i] = z;
    Console.WriteLine(tree.Root.Children[i].Value);
    //Console.WriteLine("[" + tree.Root.Children[i].Value + "]");
}

Tree tree1;

Console.WriteLine("TEST");


//tree.Root.Children[0] = n;


Read();

void Read()
{
    for (int i = 0; i < tree.Root.Children.Count; i++)
    {
        Console.WriteLine("[" + tree.Root.Children[i].Value + "]");
        for (int j = 0; j < tree.Root.Children[i].Children.Count; j++)
        {
            Console.WriteLine("\t[" + tree.Root.Children[i].Children[j].Value + "]");
            for (int k = 0; k < tree.Root.Children[i].Children[j].Children.Count; k++)
            {
                Console.WriteLine("\t\t" + tree.Root.Children[i].Children[j].Children[k].Value);
                for (int l = 0; l < tree.Root.Children[i].Children[j].Children[k].Children.Count; l++)
                {
                    Console.WriteLine("\t\t\t" + tree.Root.Children[i].Children[j].Children[k].Children[l].Value);
                }
            }
            Console.WriteLine("\t[" + tree.Root.Children[i].Children[j].Value + "]");
        }
        Console.WriteLine("[" + tree.Root.Children[i].Value + "]");
    }
}

bool TryGetNode(string value, out Node node)
{
    node = new Node("root");


    for (int i = 0; i < tree.Root.Children.Count; i++)
    {
        if (tree.Root.Children[i].Value == value)
        {
            return true;
        }
        else
        {
            node = new Node("null");
            return false;
        }
    }
    return false;
}
Console.ReadKey();