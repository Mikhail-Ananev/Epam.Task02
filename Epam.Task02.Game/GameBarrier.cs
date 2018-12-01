using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Game
{
    public abstract class GameBarrier : GameObject
    {
    }
    public class Wall : GameBarrier
    {
        public override void Draw()
        {
            Console.WriteLine($"Wall:{Position.X}, {Position.Y}");
        }
    }

    public class Stone : GameBarrier
    {
        public override void Draw()
        {
            Console.WriteLine($"Stone:{Position.X}, {Position.Y}");
        }
    }
    public class Tree : GameBarrier
    {
        public override void Draw()
        {
            Console.WriteLine($"Tree:{Position.X}, {Position.Y}");
        }
    }

}
