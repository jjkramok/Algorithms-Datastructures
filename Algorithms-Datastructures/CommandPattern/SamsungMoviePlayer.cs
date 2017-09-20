using System;

namespace CommandPattern
{
    public class SamsungMoviePlayer : IMoviePlayer
    {
        public void PauseMovie()
        {
            Console.WriteLine(ToString() + ": Movie Paused");
        }

        public void PlayMovie()
        {
            Console.WriteLine(ToString() + ": Movie Resumed");
        }

        public void StopMovie()
        {
            Console.WriteLine(ToString() + ": Movie Stopped");
        }
        
        public override string ToString()
        {
            return "Samsung Player";
        }
    }
}