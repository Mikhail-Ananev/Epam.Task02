using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Game
{
    public abstract class GameMovable : GameObject, IGameMovable
    {
        public abstract void Move();
    }

    public class User : GameMovable
    {
        public override void Draw()
        {
            Console.WriteLine("Here I am!");
        }

        public override void Move()
        {
            ;
        }
        public int Skill()
        {
            return 1;
        }
        public void Death()
        {
            Console.WriteLine("Game over!");
        }
    }
    public abstract class Monster : GameMovable
    {
        public abstract void Shout();
    }

    public class Bear : Monster
    {
        public override void Draw()
        {
            Console.WriteLine("I am bear!");
        }

        public override void Move()
        {
            ;
        }
        public override void Shout()
        {
            Console.WriteLine("I`ll crush you!");
        }
    }

    public class Wolf : Monster
    {
        public override void Draw()
        {
            Console.WriteLine("I am wolf!");
        }

        public override void Move()
        {
            ;
        }
        public override void Shout()
        {
            Console.WriteLine("I`ll eat you!");
        }
    }

}
