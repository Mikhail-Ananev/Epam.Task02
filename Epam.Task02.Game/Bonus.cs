using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Game
{
    public abstract class Bonus : GameObject
    {
        public abstract int SkillBonus();
    }

    public class Apple : Bonus
    {
        public override void Draw()
        {
            Console.WriteLine("Nice apple!");
        }
        public override int SkillBonus()
        {
            return 10;
        }
    }
    public class Strawberry : Bonus
    {
        public override void Draw()
        {
            Console.WriteLine("I love strawberry!");
        }
        public override int SkillBonus()
        {
            return 30;
        }
    }
    public class RottenTangerin : Bonus
    {
        public override void Draw()
        {
            Console.WriteLine("Oh shit...");
        }
        public override int SkillBonus()
        {
            return -5;
        }
    }
}
