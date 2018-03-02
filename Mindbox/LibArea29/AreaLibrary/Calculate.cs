using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary
{
    public class Calculate
    {
        public static double Area(Figure figure)
        {
            if (figure is RightTriangle)
            {
                RightTriangle t = figure as RightTriangle;

                return (t.SideA * t.SideC) / 2;
            }
            else if (figure is Circle)
            {
                Circle c = figure as Circle;
                return Math.PI * c.Radius * c.Radius;

            }
            else
            {
                return 0;
            }
        }
    }
}
