using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class Square : Shape
    {
        private readonly Point _position = new Point
        {
            _x = 50,
            _y = 10
        };

        private int _side = 20;

        public Square() : base(ShapeType.square)
        {
        }

        public void Draw()
        {
            string lt_corner = "╔";
            string rt_corner = "╗";
            string bl_corner = "╚";
            string br_corner = "╝";
            string drawShape = "";
            string horizontal = "=";
            string vertical= "║";
            drawShape += lt_corner;
            string space = "";

            for (int i = 0; i < _side; i++)
            {
                space += " ";
                drawShape += horizontal;
            }

            drawShape += rt_corner;
            for (int i = 0; i < _side/2 ; i++)
            {
                drawShape += "\n";
                drawShape += space.PadRight(_position._x);
                drawShape += vertical + space + vertical;
            }

            drawShape += "\n";
            drawShape += space.PadRight(_position._x);
            drawShape += bl_corner;

            for (int i = 0; i < _side; i++)
            {
                drawShape += horizontal;
            }

            drawShape += br_corner;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.CursorTop = _position._y;
            Console.CursorLeft = _position._x;
            Console.Write(drawShape);
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
