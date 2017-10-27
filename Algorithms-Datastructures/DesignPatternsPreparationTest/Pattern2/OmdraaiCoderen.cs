namespace DesignPatternsPreparationTest.Pattern2
{
    public class OmdraaiCoderen : ICodeerStrategy
    {
        public string Codeer(string message)
        {
            string res = "";
            for (int i = message.Length; i > 0; i--)
            {
                res += message[i];
            }
            return res;
        }
    }
}