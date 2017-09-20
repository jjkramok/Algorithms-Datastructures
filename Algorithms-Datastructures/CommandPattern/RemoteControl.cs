namespace CommandPattern
{
    public class RemoteControl
    {
        public ICommand Command { get; set; }

        public void PressExecute()
        {
            Command.Execute();
        }

        public void PressUndo()
        {
            Command.Undo();
        }
    }
}