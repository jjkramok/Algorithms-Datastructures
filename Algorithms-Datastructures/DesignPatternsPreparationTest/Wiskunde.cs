using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace DesignPatternsPreparationTest
{
    public class Wiskunde
    {
        // Houd instance bij; omdat het 1 variabele is kan er maar één intance bestaan
        private Wiskunde _inst;

        public int Optellen(int a, int b)
        {
            return a + b;
        }

        public int Aftrekken(int a, int b)
        {
            return a - b;
        }

        public int Vermenigvuldigen(int a, int b)
        {
            return a * b;
        }

        public int Delen(int a, int b)
        {
            return b == 0 ? -1 : a / b;
        }
        
        // Private constructor zodat je van buiten af geen objecten van deze class kan maken
        private Wiskunde()
        {
            
        }

        // Geeft instance van de Wiskunde class, of maak er één aan als dat nog niet gebeurd is.
        public Wiskunde getInstance()
        {
            if (_inst == null)
            {
                _inst = new Wiskunde();
            }
            return _inst;
        }
    }
}