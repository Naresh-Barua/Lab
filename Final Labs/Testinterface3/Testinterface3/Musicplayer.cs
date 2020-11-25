using System;
using System.Collections.Generic;
using System.Text;

namespace Testinterface3
{
    interface Musicplayer
    {
        //void switch(Boolean on);
        void play(Boolean on);
        void setVolume(int loudness);
        void playNext();
        void playPrevious();




    }
}
