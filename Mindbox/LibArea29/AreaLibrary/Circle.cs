using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary
{
    public class Circle:Figure
    {
        public int Radius { get; set; }

        public override double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
