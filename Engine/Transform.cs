using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDefense
{
    class Transform //Класс для хранения позиции и тд
    {
        Vector position;
        Vector size;
        public Vector Size => position;
        public void SetPosition(Vector vector) => position = vector;
        public void AddPostion(Vector vector) => position = position + vector;
        public void SetSize(Vector vector) => size = vector;

        public bool Colisition(int x, int y) => x > position.X + size.X && y > position.Y + size.Y && x < position.X + size.X && y < position.Y + size.Y;

    }
}
