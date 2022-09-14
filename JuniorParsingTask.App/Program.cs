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
    Node z = tree.Root.Children[0];
Console.WriteLine("z = " + z + " z.Value= " + z.Value +" " + " tree.Root.Children[0] = " + tree.Root.Children[0] + " tree.Root.Children[0].Velue = "+ tree.Root.Children[0].Value);
    Console.WriteLine(TryGetNode("aaa",out z));

    //tree.Root.Children[i] = z;

    Console.WriteLine(tree.Root.Children[0].Value);
    Console.WriteLine("[tree.Root.Children[0].Value=" + tree.Root.Children[0].Value + "]");

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
    node = tree.Root.Children[0];
    Console.WriteLine("POCZATEK TryGetNode: node = " + node +" " + node.Value + " Value = " + value);
    Console.WriteLine("tree.Root.Children[].Value = " + tree.Root.Children[0].Value);

    for (int i = 0; i < tree.Root.Children.Count; i++)
    {
        Console.WriteLine("Przed zmianą: [" + tree.Root.Children[i].Value + "]");
        if (tree.Root.Children[i].Value == value)
        {
            Console.WriteLine("tree.Root.Children[i].Value == value || "+ tree.Root.Children[i].Value + " == " + value);
            //return true;
        }
        else
        {
           // node = new Node("null");
           // return false;
        }
        for (int j = 0; j < tree.Root.Children[i].Children.Count; j++)
        {
            Console.WriteLine("\tPrzed zmianą: [" + tree.Root.Children[i].Children[j].Value + "]");
            if (tree.Root.Children[i].Children[j].Value == value)
            {
               // return true;
            }
            else
            {
               // node = new Node("null");
               // return false;
            }
            Console.WriteLine("\t Po zmianie: [" + tree.Root.Children[i].Children[j].Value + "]");
            for (int k = 0; k < tree.Root.Children[i].Children[j].Children.Count; k++)
            {
                Console.WriteLine("\t\tPrzed zmianą: [" + tree.Root.Children[i].Children[j].Children[k].Value + " ] ");
                if (tree.Root.Children[i].Children[j].Children[k].Value == value)
                {
                   // return true;
                }
                else
                {
                    //node = new Node("null");
                    //return false;
                }
                Console.WriteLine("\t\tPo zmianie: [" + tree.Root.Children[i].Children[j].Children[k].Value + " ] ");
                for (int l = 0; l < tree.Root.Children[i].Children[j].Children[k].Children.Count; l++)
                {
                    Console.WriteLine("\t\t\t Przed zmianą: #[" + tree.Root.Children[i].Children[j].Children[k].Children[l].Value + "]");
                    if (tree.Root.Children[i].Children[j].Children[k].Children[l].Value == value)
                    {
                       // return true;
                    }
                    else
                    {
                        //node = new Node("null");
                        //return false;
                    }
                    Console.WriteLine("\t\t\t Po zmianie: #[" + tree.Root.Children[i].Children[j].Children[k].Children[l].Value+"]");
                }

            }
        }
    }


    Console.WriteLine("KONIEC TryGetNode: node = " + node + " " + node.Value);
    return false;
}
Console.ReadKey();