using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsGeeksForGeeks
{
    internal class Graph
    {
        private int vertices;
        private List<int>[] adjacencyList;
        public Graph()
        {
            
        }
        public Graph(int v)
        {
            vertices = v;
            adjacencyList = new List<int>[v];
            for (int i = 0; i < v; ++i)
            {
                adjacencyList[i] = new List<int>();
            }
        }
        public void AddEdge(int v, int w)
        {
            adjacencyList[v].Add(w);
        }
        public void DFS(int start)
        {
            bool[] visited = new bool[vertices];
            DFSUtil(start, visited);
        }
        private void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");

            foreach (int neighbor in adjacencyList[v])
            {
                if (!visited[neighbor])
                {
                    DFSUtil(neighbor, visited);
                }
            }
        }

        public void DepthFirst()
        {
            Graph graph = new Graph(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            Console.WriteLine("DFS starting from vertex 2:");
            graph.DFS(2);
        }
    }
}
