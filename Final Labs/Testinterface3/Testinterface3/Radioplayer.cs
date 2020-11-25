using System;
using System.Collections.Generic;
using System.Text;

namespace Testinterface3
{
    interface Radioplayer
    {
        void Switch(Boolean on);
        void Retune(double frequency);
        void setVolume(int loudness);
        void changeChannel();
    }
}
