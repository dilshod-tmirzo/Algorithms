using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsGeeksForGeeks
{
    internal class BreadthFirstSearch
    {
        private int V; // Number of vertices
        private List<int>[] adj; // Adjacency lists

        public BreadthFirstSearch()
        {
            
        }
        public BreadthFirstSearch(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        public void BFS(int s)
        {
            bool[] visited = new bool[V];
            Queue<int> queue = new Queue<int>();
            visited[s] = true;
            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                s = queue.Dequeue();
                Console.Write(s + " ");

                foreach (int i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
        }

        public void BreadthFirst()
        {
            BreadthFirstSearch g = new BreadthFirstSearch(4);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.WriteLine("Breadth First Traversal (starting from vertex 2):");
            g.BFS(2);
        }
    }
}
