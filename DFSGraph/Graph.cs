using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSGraph
{
    class Graph
    {
        int nodes;
        List<List<int>> adj = new List<List<int>>();

        public Graph(int V)
        {
            this.nodes = V;
            for(int i = 0; i<V; i++)
            {
                adj.Add(new List<int>());
            }
        }

        public void AddEdge(int Source, int Destination)
        {
            adj[Source].Add(Destination);
        }

        public void DFS(int StartNode)
        {
            bool[] Visited = new bool[nodes];
            DFSUtil(StartNode, Visited);
        }

        public void DFSUtil(int StartNode, bool[] Visited)
        {
            Visited[StartNode] = true;
            Console.Write(StartNode + " , ");
            List<int> vNode = adj[StartNode];
            foreach(var vchild in vNode)
            {
                if (!Visited[vchild])
                    DFSUtil(vchild, Visited);
            }
        }
    }
}
