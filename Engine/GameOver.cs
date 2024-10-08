using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDefense.Engine
{
    class GameOver
    {
        public static bool isGameOver;
        public static void DrawGameOverScreen(Graphics g)
        {
            g.DrawString($"Game over \n Time: {Convert.ToUInt32(Time.GetMinets())}", new Font("Stencil", 25),
            new SolidBrush(Color.Red), Render.Resolution.X / 2 - 100, Render.Resolution.Y / 2 -100);
		}
    }
}
