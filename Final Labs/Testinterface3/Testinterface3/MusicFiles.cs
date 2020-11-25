using System;
using System.Collections.Generic;
using System.Text;

namespace Testinterface3
{
    class MusicFiles
    {
        private string title;
        private string artist;
        private int yearOfRelease;
        private float durationInSeconds;

        public MusicFiles()
        {
            title = "Chander Bati";
            artist = "Biplob";
            yearOfRelease = 2010;
            durationInSeconds = 4.4f;
        }
        public MusicFiles(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }
        public void changeTitle(string title)
        {
            this.title = title;
        }
    }
}
