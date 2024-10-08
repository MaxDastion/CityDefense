using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using CityDefense.Engine;

namespace CityDefense
{
    class Resources
    {
        static Dictionary<string, Image> frames = new Dictionary<string, Image>();
        public static Dictionary<string, SoundPlayer> SoundPlayer = new Dictionary<string, SoundPlayer>();
        static public void InitializatorResourse()
        {
            frames = FileSystem.LoadFrames("Res.int");
            SoundPlayer = FileSystem.LoadSounds("Sound.int");

        }
        static public Image GetFrae(string key) => frames[key];
        static public SoundPlayer GetSound(string key)=> SoundPlayer[key];  

    }
}
