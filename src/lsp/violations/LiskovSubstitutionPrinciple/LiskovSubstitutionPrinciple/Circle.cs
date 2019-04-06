using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class Circle : Shape
    {
        private readonly Point _center = new Point
        {
            _x = 50,
            _y = 20
        };
        private readonly double _radius = 10;

        public Circle() : base(ShapeType.circle)
        {
        }

        public void Draw()
        {
            //draws circle
        }
    }
}
