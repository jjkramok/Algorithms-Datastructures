using System.Collections.Generic;

namespace CommandPattern
{
    public class RemoteControl
    {
        public ICommand Command { get; set; }
        public Stack<ICommand> PrevCommands = new Stack<ICommand>();

        public void PressExecute()
        {
            Command.Execute();
            PrevCommands.Push(Command);
        }

        public void PressUndo()
        {
            if (PrevCommands.Count > 0)
            {
                Command.Undo();
                PrevCommands.Pop(); 
            }
            //TODO work with PrevCommands stack for undoing stuff
        }
    }
}