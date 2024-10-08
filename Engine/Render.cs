using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using CityDefense.Game;
using CityDefense.Engine;

namespace CityDefense
{
    class Render
    {
        static Vector resolution;
        static IScene scene;
		public static void SetResolution(int x, int y)
		{
			resolution = new Vector(x, y);
		}

		public static void SetScene(IScene customisation) => scene = customisation;
        public static Image DrawFrame()
        {
            Bitmap bitmap = new Bitmap(resolution.X, resolution.Y);
            Graphics g = Graphics.FromImage(bitmap);
            scene.DrawObject(g);
            if (GameOver.isGameOver)
            {
                GameOver.DrawGameOverScreen(g);

            }
            return bitmap;
        }
        public static Vector Resolution => resolution;

    }
}
