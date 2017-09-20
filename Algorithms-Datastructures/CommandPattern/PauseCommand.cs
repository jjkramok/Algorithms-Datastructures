namespace CommandPattern
{
    public class PauseCommand : ICommand
    {
        public IMoviePlayer Player { get; set; }
        
        public void Execute()
        {
            Player.PauseMovie();
        }

        public void Undo()
        {
            Player.PlayMovie();
        }

        public PauseCommand(IMoviePlayer player)
        {
            Player = player;
        }
    }
}