using System.CodeDom;
using System.Diagnostics;

namespace ObserverPattern
{
    public class GameWorld : Observable
    {
        private Stopwatch _gametime;
        private GameWorld instance;
        public bool shutdown { get; set; } = false;
        private const long TimePerTick = 1000;

        private GameWorld()
        {
            _gametime = new Stopwatch();
        }

        public void StartGame()
        {
            // Gives of a signal that updates all game components
            _gametime.Start();
            while (!shutdown)
            {
                if (_gametime.ElapsedMilliseconds >= TimePerTick)
                {
                    _gametime.Restart();
                    notify();
                }
            }
            _gametime.Reset();
        }

        public GameWorld getInstance()
        {
            if (instance == null)
            {
                instance = new GameWorld();
            }
            return instance;
        }
        
    }
}