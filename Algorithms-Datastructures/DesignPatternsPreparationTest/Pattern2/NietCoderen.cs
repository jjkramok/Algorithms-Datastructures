namespace DesignPatternsPreparationTest.Pattern2
{
    public class NietCoderen : ICodeerStrategy
    {
        public string Codeer(string message)
        {
            return message;
        }
    }
}