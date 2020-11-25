using System;

namespace Testinterface3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile = new Mobile();
            mobile.songs();
            mobile.changeChannel();
            mobile.play(true);
            mobile.playNext();
            mobile.playPrevious();
            mobile.Switch(true);
        }
    }
}
