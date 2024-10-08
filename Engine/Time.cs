using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDefense.Engine
{
    class Time
    {    
        static int frame =0 ;
        static int interval;
        public static void Frame_Tick(object sender, EventArgs e )=> frame++;
        public static int GetMiliSeconds()=> frame + (int)interval;
        public static double GetSeconds() => GetMiliSeconds() / 1000;
        public static double GetMinets() => GetSeconds() / 60;
        public static int deltaTime => interval;

    }
}
