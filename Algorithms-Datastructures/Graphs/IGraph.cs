namespace Algorithms_Datastructures.Graphs
{
    public interface IGraph
    {
        SEGraph.Vertex GetVertex(string name);
        void AddEdge(string source, string dest, double cost);
        string ToString();
    }
}