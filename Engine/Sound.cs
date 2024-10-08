using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDefense.Engine
{
    class Sound
    {
        public   static void Play(string key) => Resources.GetSound(key);
    }
}
