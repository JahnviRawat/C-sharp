using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day4
{
    internal interface Iplayable
    {
        void play();
    }
    internal class MusicPlayer: Iplayable
    {
        void Iplayable.play()
        {
            Console.WriteLine("Play Music Player ");
        }
    }

    internal class VideoPlayer : Iplayable
    {
        void Iplayable.play()
        {
            Console.WriteLine("Play Video Player ");
        }
    }
}
