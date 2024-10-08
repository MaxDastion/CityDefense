using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDefense.Game
{
    class Plane : Transform, IGameObject
    {
        int speed;
        public Plane(int x, int y, int sx, int sy, int speed, int offsetSpeed)
        {
            Random random= new Random();
            SetPosition(new Vector(x, y));
            SetSize(new Vector(sx, sy));
            this.speed = speed+ random.Next(-offsetSpeed, offsetSpeed);
        }
    }
}
