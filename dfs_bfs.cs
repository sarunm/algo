using System;
using System.Collections;

public class dfs_bfs
{
    public void bfs_traversal(Node node)
    {
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(node);

        while (q.Count > 0)
        {
            node = q.Dequeue();
            Console.WriteLine(node.Data + " ");
            if (node.Left != null)
            {
                q.Enqueue(node.Left);
            }

            if (node.Right != null)
            {
                q.Enqueue(node.Right);
            }
        }

    }

    public void dfs_traversal(Node node){
        if(node == null){
            return;
        }
        Console.WriteLine(node.Data + " ");
        dfs_traversal(node.Left);
        dfs_traversal(node.Right);
    }

    public Node sampleNode()    
    {
        return new Node("A", new Node("B", new Node("C"), new Node("D")), new Node("E", new Node("F"), new Node("G", new Node("H"), null)));
    }
}
public class Node
{
    public Node Left { get; set; }
    public Node Right { get; set; }

    public string Data { get; set; }

    public Node(string Data, Node left, Node right)
    {
        this.Left = left;
        this.Right = right;
        this.Data = Data;
    }

    public Node(string Data)
    {
        this.Left = null;
        this.Right = null;
        this.Data = Data;
    }
}