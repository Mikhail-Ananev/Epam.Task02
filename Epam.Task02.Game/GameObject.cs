using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Game
{
    public abstract class GameObject : IGameObject
    {
        public Point Position
        {
            get => Position;
            set
            {
                if (value.X > Program.mapWidth && value.X < 0)
                {
                    throw new ArgumentException("Incorrect coordinate:", nameof(value.X));
                }
                else
                {
                    Position.X = value.X;
                }
                if (value.Y > Program.mapHeight && value.Y < 0)
                {
                    throw new ArgumentException("Incorrect coordinate:", nameof(value.Y));
                }
                else
                {
                    Position.Y = value.Y;
                }
            }
        }

        public abstract void Draw();
    }


}
