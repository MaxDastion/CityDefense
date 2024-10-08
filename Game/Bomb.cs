using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDefense.Game
{
    class Bomb : Transform, IGameObject
    {
        int speed;
        int speedofset;
        int curSpeed;
        Scene scene;
        Random rand = new Random();
        public Bomb(int sx, int sy, int speed, int offspeed, Scene scene)
        {
            this.scene= scene;
            SetSize(new Vector(sx, sy));
            this.speed = speed; 
            this.speedofset = offspeed;
            NextPlane();
        }
        public void NextPlane()
        {
            curSpeed = speed + rand.Next(-speedofset, speedofset);
            SetPosition(scene.planes[rand.Next(0, scene.planes.Count)]);
        }
        public void Draw(Graphics g)
        {AddPostion(new Vector(0, curSpeed));
            g.DrawImage(Resources.GetFrae("Bomb"), Position.X, Position.Y, Size.X, Size.Y);
            if (Position.Y> Render.)
            {

            }

        }
    }
}
