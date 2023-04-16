using System.Security.Cryptography;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("BFS");

        int[,] grid = { { 0, 0, 0, 0 }, { 1, 0, 1, 0 }, { 0, 1, 1, 0 }, { 0, 0, 0, 0 } };

        var node = new dfs_bfs();

        var n = node.sampleNode();

        node.bfs_traversal(n);

        Console.WriteLine("DFS");

        node.dfs_traversal(n);

    }
}