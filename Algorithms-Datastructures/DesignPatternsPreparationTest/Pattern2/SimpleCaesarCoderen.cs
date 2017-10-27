namespace DesignPatternsPreparationTest.Pattern2
{
    public class SimpleCaesarCoderen : ICodeerStrategy
    {
        public string Codeer(string message)
        {
            string res = "";
            foreach (char c in message)
            {
                res += c + 1;
            }
            return res;
        }
    }
}