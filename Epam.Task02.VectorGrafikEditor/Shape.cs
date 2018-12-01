using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Round
{
    public abstract class Shape : IVectorGraficsEditor
    {
        public abstract void Show(Point p);
    }
    public class Line : Shape
    {
        public override void Show(Point p)
        {
            Console.WriteLine($"Drawing \"Line\" located at the coordinates:{Environment.NewLine}" +
                $"X:{p.X}{Environment.NewLine}" +
                $"Y:{p.Y}{Environment.NewLine}");
        }
    }

    public class Circle : Shape
    {
        public override void Show(Point p)
        {
            Console.WriteLine($"Drawing \"Circle\" located at the coordinates:{Environment.NewLine}" +
                $"X:{p.X}{Environment.NewLine}" +
                $"Y:{p.Y}{Environment.NewLine}");
        }
    }
    public class Ring : Circle
    {
        public override void Show(Point p)
        {
            Console.WriteLine($"Drawing \"Ring\" located at the coordinates:{Environment.NewLine}" +
                $"X:{p.X}{Environment.NewLine}" +
                $"Y:{p.Y}{Environment.NewLine}");
        }
    }

    public class NewRound : Circle
    {
        public override void Show(Point p)
        {
            Console.WriteLine($"Drawing \"Round\" located at the coordinates:{Environment.NewLine}" +
                $"X:{p.X}{Environment.NewLine}" +
                $"Y:{p.Y}{Environment.NewLine}");
        }
    }
    public class Rectangle : Shape
    {
        public override void Show(Point p)
        {
            Console.WriteLine($"Drawing \"Rectangle\" located at the coordinates:{Environment.NewLine}" +
                $"X:{p.X}{Environment.NewLine}" +
                $"Y:{p.Y}{Environment.NewLine}");
        }
    }


}
