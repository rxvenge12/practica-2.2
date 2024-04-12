using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2._2
{
    public class Rectangle
    {
        public Point BottomLeft { get; set; }
        public Point TopRight { get; set; }

        public Rectangle(Point bottomLeft, Point topRight)
        {
            BottomLeft = bottomLeft;
            TopRight = topRight;
        }
    }
}
