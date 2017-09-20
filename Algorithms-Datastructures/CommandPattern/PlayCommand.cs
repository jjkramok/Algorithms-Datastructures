namespace CommandPattern
{
    public class PlayCommand : ICommand
    {
        public IMoviePlayer Player { get; set; }
        
        public void Execute()
        {
            Player.PlayMovie();
        }

        public void Undo()
        {
            Player.PauseMovie();
        }

        public PlayCommand(IMoviePlayer player)
        {
            Player = player;
        }
    }
}