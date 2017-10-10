using System;
using System.Collections.Generic;

namespace Algorithms_Datastructures.Graphs
{
    // Graph from the SE excersices
    public class SEGraph : IGraph
    {
        private HashSet<Vertex> vertices;

        public SEGraph()
        {
            vertices = new HashSet<Vertex>();
        }

        public void AddVertex(String label)
        {
            vertices.Add(new Vertex(label));
        }

        public void AddVertex(Vertex v)
        {
            vertices.Add(v);
        }

        public void AddEdge(string src, string dest, double cost)
        {
            Vertex s = GetVertex(src);
            Vertex d = GetVertex(dest);
            if (s == null)
            {
                Console.WriteLine("src vertex does not exist");
                return;
            }
            else if (d == null)
            {
                Console.WriteLine("dest vertex does not exist");
                return;
            }
            s.Adj.Add(new Edge(d, cost));
        }

        public Vertex GetVertex(string label)
        {
            foreach (Vertex v in vertices)
            {
                if (v.Label.Equals(label))
                    return v;
            }
            return null;
        }

        public override String ToString()
        {
            String res = "";
            foreach (Vertex v in vertices)
                res += v + "\n";
            return res;
        }

        //Initializes a graph with complexity O(V,E) = V + E
        public void Unweighted(String label)
        {
            Vertex s = GetVertex(label);
            if (s == null)
            {
                Console.WriteLine("Vertex (" + label + ") does not exist");
                return;
            }
            Queue<Vertex> q = new Queue<Vertex>();
            foreach (Vertex v in vertices)
            {
                v.Dist = -1;
                v.Known = false;
            }
            s.Dist = 0;
            q.Enqueue(s);

            while (q.Count > 0)
            {
                Vertex v = q.Dequeue();

                foreach (Edge e in v.Adj)
                {
                    Vertex w = e.Dest;
                    if (w.Dist == -1)
                    {
                        w.Dist = v.Dist + 1;
                        w.Prev = v;
                        q.Enqueue(w);
                    }
                }
            }
        }

        //Initializes a graph with complexity O(N) = N^2
        public void UnweightedNSquared(String label)
        {
            Vertex s = GetVertex(label);
            if (s == null)
            {
                Console.WriteLine("Vertex (" + label + ") does not exist");
                return;
            }
            foreach (Vertex v in vertices)
            {
                v.Dist = -1;
                v.Known = false;
            }
            s.Dist = 0;

            for (int currDist = 0; currDist < vertices.Count; currDist++)
            {
                foreach (Vertex v in vertices)
                {
                    if (!v.Known && v.Dist == -1)
                    {
                        v.Known = true;
                        foreach (Edge e in v.Adj)
                        {
                            Vertex w = e.Dest;
                            if (w.Dist != -1)
                            {
                                w.Dist = currDist + 1;
                                w.Prev = v;
                            }
                        }
                    }
                }
            }
        }

        //Initializes a graph
        public void Dijkstra(String label)
        {
            Vertex v = FindSmallestUnknownDistance();
            if (v == null)
            {
                Console.WriteLine("Vertex (" + label + ") does not exist");
                return;
            }
            foreach (Vertex vv in vertices)
            {
                vv.Dist = 900;
                vv.Known = false;
            }
            GetVertex(label).Dist = 0;
            GetVertex(label).Prev = null;

            while (v != null)
            {
                v.Known = true;

                foreach (Edge e in v.Adj)
                {
                    Vertex w = e.Dest;
                    if (!w.Known)
                    {
                        if (v.Dist + e.Cost < w.Dist)
                        {
                            w.Dist = v.Dist + e.Cost;
                            w.Prev = v;
                        }
                    }
                }
                v = FindSmallestUnknownDistance();
            }
        }

        private Vertex FindSmallestUnknownDistance()
        {
            double smallestDist = 900;
            Vertex res = null;

            foreach (Vertex v in vertices)
            {
                if (!v.Known && v.Dist < smallestDist)
                {
                    smallestDist = v.Dist;
                    res = v;
                }
            }
            return res;
        }

        public class Vertex : IVertex
        {

            public string Label;
            public HashSet<Edge> Adj;
            public Vertex Prev;
            public double Dist;
            public bool Known;

            public Vertex(string label)
            {
                Label = label;
                Adj = new HashSet<Edge>();
                Prev = null;
            }

            public void Reset()
            {
                Adj.Clear();
                Prev = null;
                Known = false;
                Dist = -1;
            }

            public override string ToString()
            {
                string result = Label + "";
                if (Adj.Count > 0)
                    result += " -->";
                foreach (Edge e in Adj)
                    result += " " + e;
                return result;
            }
        }

        public class Edge
        {
            public Vertex Dest;
            public double Cost;

            public Edge(Vertex dest, double cost)
            {
                Dest = dest;
                Cost = cost;
            }

            public override string ToString()
            {
                return Dest + "(" + Cost + ")";
            }
        }
    }
}