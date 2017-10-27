using Algorithms_Datastructures.Graphs;

namespace PreparationTest
{
    public interface IGraph
    {
        SEGraph.Vertex GetVertex(string name);
        void AddEdge(string source, string dest, double cost);
        string ToString();
    }
}