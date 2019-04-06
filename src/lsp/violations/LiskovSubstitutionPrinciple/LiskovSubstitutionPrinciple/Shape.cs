using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class Shape
    {
        private readonly ShapeType _type;

        public Shape(ShapeType t)
        {
            _type = t;
        }

        public void DrawShape(Shape s)
        {
            if (s._type == ShapeType.square)
                (s as Square).Draw();
            else if (s._type == ShapeType.circle)
            {
                (s as Circle).Draw();
            }
        }
    }
}
