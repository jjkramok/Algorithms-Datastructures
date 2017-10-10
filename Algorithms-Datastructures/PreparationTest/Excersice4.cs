using System;
using System.Collections.Generic;

namespace PreparationTest
{
    public class Excersice4
    {
        private HashSet<Vertex> vertices;

        public Excersice4() {
            vertices = new HashSet<Vertex>();
        }
    
        public void AddVertex(String label) {
            vertices.Add(new Vertex(label));
        }
        public void AddVertex(Vertex v) {
            vertices.Add(v);
        }
    
        public void AddEdge(String src, String dest, double cost) {
            Vertex s = GetVertex(src);
            Vertex d = GetVertex(dest);
            if (s == null) {
                Console.WriteLine("src vertex does not exist");
                return;
            } else if (d == null) {
                Console.WriteLine("dest vertex does not exist");
                return;
            }
            s.Adj.Add(new Edge(d, cost));
        }

        public void AddEdge(String src, String dest)
        {
            AddEdge(src, dest, 1);
        }
    
        protected Vertex GetVertex(String label) {
            foreach (Vertex v in vertices) {
                if (v.Label.Equals(label))
                    return v;
            }
            return null;
        }
    
        public override String ToString() {
            String res = "";
            foreach (Vertex v in vertices)
                res += v + "\n";
            return res;
        }
    
        //Initializes a graph with complexity O(V,E) = V + E
        public void Unweighted(String label) {
            Vertex s = GetVertex(label);
            if (s == null) {
                Console.WriteLine("Vertex (" + label + ") does not exist");
                return;
            }
            Queue<Vertex> q = new Queue<Vertex>();
            foreach (Vertex v in vertices) {
                v.Dist = Double.PositiveInfinity;
                v.Known = false;
            }
            s.Dist = 0;
            q.Enqueue(s);
    
            while (q.Count > 0) {
                Vertex v = q.Dequeue();
    
                foreach (Edge e in v.Adj) {
                    Vertex w = e.Dest;
                    if (Double.IsPositiveInfinity(w.Dist)) {
                        w.Dist = v.Dist + 1;
                        w.Prev = v;
                        q.Enqueue(w);
                    }
                }
            }
        }
    
        //Initializes a graph with complexity O(N) = N^2
        public void UnweightedNSquared(String label) {
            Vertex s = GetVertex(label);
            if (s == null) {
                Console.WriteLine("Vertex ("+ label +") does not exist");
                return;
            }
            foreach (Vertex v in vertices) {
                v.Dist = Double.MaxValue;
                v.Known = false;
            }
            s.Dist = 0;
    
            for (int currDist = 0; currDist < vertices.Count; currDist++) {
                foreach (Vertex v in vertices) {
                    if (!v.Known && Double.IsPositiveInfinity(v.Dist)) {
                        v.Known = true;
                        foreach (Edge e in v.Adj) {
                            Vertex w = e.Dest;
                            if (!Double.IsPositiveInfinity(w.Dist)) {
                                w.Dist = currDist + 1;
                                w.Prev = v;
                            }
                        }
                    }
                }
            }
        }
    
        //Initializes a graph
        public void Dijkstra(String label) {
            Vertex v = FindSmallestUnknownDistance();
            if (v == null) {
                Console.WriteLine("Vertex ("+ label +") does not exist");
                return;
            }
            foreach (Vertex vv in vertices) {
                vv.Dist = Double.MaxValue;
                vv.Known = false;
            }
            GetVertex(label).Dist = 0;
            GetVertex(label).Prev = null;
    
            while (v != null) {
                v.Known = true;
    
                foreach (Edge e in v.Adj) {
                    Vertex w = e.Dest;
                    if (!w.Known) {
                        if (v.Dist + e.Cost < w.Dist) {
                            w.Dist = v.Dist + e.Cost;
                            w.Prev = v;
                        }
                    }
                }
                v = FindSmallestUnknownDistance();
            }
        }
    
        private Vertex FindSmallestUnknownDistance() {
            double smallestDist = Double.MaxValue;
            Vertex res = null;
    
            foreach (Vertex v in vertices) {
                if (!v.Known && v.Dist < smallestDist) {
                    smallestDist = v.Dist;
                    res = v;
                }
            }
            return res;
        }

        public class Vertex
        {
            
            public string Label;
            public HashSet<Edge> Adj;
            public Vertex Prev;
            public double Dist;
            public bool Known;

            public Vertex(string label) {
                Label = label;
                Adj = new HashSet<Edge>();
                Prev = null;
            }

            public override string ToString() {
                string prevLabel = (Prev == null) ? "none" : Prev.Label;
                string result = "Vertex: " + Label + " prev: " + prevLabel + " dist: " +
                                Dist + " known: " + Known + " {";
                foreach (Edge e in Adj)
                    result += e;
                return result + "}";
            }
        }

        public class Edge
        {
            public Vertex Dest;
            public double Cost;

            public Edge(Vertex dest, double cost) {
                Dest = dest;
                Cost = cost;
            }

            public override string ToString() {
                return "{c = " + Cost + ", d = " + Dest.Label + "} ";
            }
        }
    }
}