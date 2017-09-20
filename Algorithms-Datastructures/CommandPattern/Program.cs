using System;
using System.Collections.Generic;

namespace CommandPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IMoviePlayer sonyp = new SonyMoviePlayer();
            ICommand sonyPause = new PauseCommand(sonyp);
            ICommand sonyPlay = new PlayCommand(sonyp);
            RemoteControl sonyRemote = new RemoteControl();
            sonyRemote.Command = sonyPlay;
            
            IMoviePlayer samp = new SamsungMoviePlayer();
            ICommand samPause = new PauseCommand(samp);
            ICommand samPlay = new PlayCommand(samp);
            RemoteControl samRemote = new RemoteControl();
            samRemote.Command = samPlay;
            
            sonyRemote.PressExecute();
            sonyRemote.PressUndo();
            
            samRemote.PressExecute();
            samRemote.Command = samPause;
            samRemote.PressExecute();
        }
    }
}