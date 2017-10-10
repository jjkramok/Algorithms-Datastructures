namespace PreparationTest
{
    public interface IGraph
    {
        Excersice4.Vertex GetVertex(string name);
        void AddEdge(string source, string dest, double cost);
        string ToString();
    }
}