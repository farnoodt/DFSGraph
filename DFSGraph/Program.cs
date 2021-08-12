using System;

namespace DFSGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph G = new Graph(4);
            G.AddEdge(0, 1);
            G.AddEdge(0, 2);
            G.AddEdge(1, 2);
            G.AddEdge(2, 0);
            G.AddEdge(2, 3);
            G.AddEdge(3, 3);

            G.DFS(2);
            Console.ReadLine();
        }
    }
}
