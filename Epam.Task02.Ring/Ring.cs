﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Round
{
    class Ring
    {
        private Point center = new Point();
        private Round innerRound = new Round();
        private Round outerRound = new Round();

        public Ring(double outer, double inner)
        {
            if (outer < inner)
            {
                throw new ArgumentException("Incorrect inner and outer radius value");
            }
            innerRound.Radius = inner;
            outerRound.Radius = outer;
        }
        public double InnerRadius
        {
            get => innerRound.Radius;
            set
            {
                if (value >= outerRound.Radius)
                {
                    throw new ArgumentException("Inner radius must be smaller than outer radius",nameof(innerRound.Radius));
                }
                innerRound.Radius = value;
            }
        }
        public double OuterRadius
        {
            get => outerRound.Radius;
            set
            {
                if (value <= innerRound.Radius)
                {
                    throw new ArgumentException("Outer radius must be bigger than inner radius", nameof(outerRound.Radius));
                }
                innerRound.Radius = value;
            }
        }

        public double RingArea
        {
            get => outerRound.GetArea - innerRound.GetArea;
        }

        public double RingLength
        {
            get => outerRound.GetLength + innerRound.GetLength;
        }
        internal Point Center { get => this.center; set => this.center = value; }
    }
}
