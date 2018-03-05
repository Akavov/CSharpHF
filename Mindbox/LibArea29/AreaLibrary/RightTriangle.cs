using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary
{
    public class RightTriangle:Figure
    {
        public int SideA { get; set; }
        public int SideC { get; set; }

        public override double GetSquare()
        {
            return (SideA * SideC) / 2;
        }
    }
}
