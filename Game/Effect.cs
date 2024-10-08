using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using CityDefense.Engine;

namespace CityDefense.Game
{
    class Effect : Transform, IGameObject
    {
        int countTiles = 5;
        int curTile = 0;
		Scene scene;
        public Effect(Vector postion, int sx, int sy, Scene scene)
        {
            Sound.Play("Exp");
            SetPosition(postion);
            SetSize(new Vector(sx, sy));
            this.scene = scene;

        }
        public void Draw(Graphics g)
        {
            if (curTile == countTiles)
            {
                scene.effects.Remove(this);
                g.DrawImage(Resources.GetFrae("Exp" + curTile.ToString()),
                    Postion.X, Postion.Y, Size.X, Size.Y);
                curTile++;
            }
        }
	}
}
