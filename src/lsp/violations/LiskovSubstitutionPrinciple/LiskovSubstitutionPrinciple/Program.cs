using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {  
        static void Main(string[] args)
        {
            var s = new Shape(ShapeType.square);
            s.DrawShape(new Square());
        }
    }
}
