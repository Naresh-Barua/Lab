using System;
using System.Collections.Generic;
using System.Text;

namespace Testinterface3
{
    class Mobile : Musicplayer, Radioplayer
    {
        MusicFiles[] musicFile = new MusicFiles[500];


        public void songs()
        {
            MusicFiles song = new MusicFiles();
            musicFile[0] = song;
            musicFile[1] = song;
        }

        public void Return(double frequency)
        {
            Console.WriteLine("Return");
        }

        public void setVolume(int loudness)
        {
            Console.WriteLine("Set volume");
        }

        public void Switch(bool on)
        {
            Console.WriteLine("Switch");
        }

        public void changeChannel()
        {
            Console.WriteLine("Change Chanale");
        }

        public void play(bool on)
        {
            Console.WriteLine("Play");
        }

        public void playNext()
        {
            Console.WriteLine("Play next");
        }

        public void playPrevious()
        {
            Console.WriteLine("Play previous");
        }


    }
}